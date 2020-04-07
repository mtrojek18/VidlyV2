using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidlyV2.Models;

namespace VidlyV2.ViewModels
{
    // /movies/random
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }
        public List<Customer> Customers { get; set; }
    }
}