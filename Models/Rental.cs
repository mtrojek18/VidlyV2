using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace VidlyV2.Models
{
    public class Rental
    {
        public int Id { get; set; }
        
        [Display(Name = "Customer")]
        [Required]
        public Customer Customer { get; set; }

        [Display(Name = "Movie")]
        [Required]
        public Movie Movie { get; set; }
               
        [Display(Name = "Date Rented")]
        public DateTime DateRented { get; set; }

        [Display(Name = "Date Returned")]
        public DateTime? DateReturned { get; set; }
    }
}