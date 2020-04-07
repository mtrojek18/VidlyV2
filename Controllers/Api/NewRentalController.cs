using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using VidlyV2.Models;
using VidlyV2.Dtos;
using AutoMapper;
using System.Data.Entity;

namespace VidlyV2.Controllers.Api
{
    public class NewRentalsController : ApiController
    {
        private ApplicationDbContext _context;

        public NewRentalsController()
        {
            _context = new ApplicationDbContext();
        }

        [HttpPost]
        public IHttpActionResult CreateRentals(NewRentalsDto newRental)
        {
            if (!ModelState.IsValid)
                return BadRequest();

            // load customer based on ID
            var customerInDb = _context.Customers.Single(
                c => c.Id == newRental.CustomerId);
            
            var movies = _context.Movies.Where(
                m => newRental.MovieIds.Contains(m.Id)).ToList();           

            // for each movie create rental object
            foreach (var movie in movies)
            {
                if (movie.NumberAvailable == 0)
                    return BadRequest("Movie is not available.");

                movie.NumberAvailable--;

                var rental = new Rental
                {
                    Customer = customerInDb,
                    Movie = movie,
                    DateRented = DateTime.Now
                };

                _context.Rentals.Add(rental);
            }
           
            // save changes
            _context.SaveChanges();

            return Ok();
        }
    }
}
