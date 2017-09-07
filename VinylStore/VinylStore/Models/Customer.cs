using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace VinylStore.Models
{
    public class Customer : Person
    { 
        [Display(Name = "How many vinyls does customer borrow.")]
        public int? AmountOfBorrowedVinyls { get; set; }
    }
}