using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VinylStore.Models
{
    public class Employee : Person
    {
        
        [Required]
        [Display(Name ="Initial salary.")]
        public decimal? StartSalary { get; set; }
        [Display(Name ="Current salary")]
        public decimal? CurrentSalary { get; set; }
        [Display(Name ="Monday")]
        public bool WorkingMonday { get; set; }
        [Display(Name = "Tuesday")]
        public bool WorkingTuesday { get; set; }
        [Display(Name = "Wednesday")]
        public bool WorkingWednesday { get; set; }
        [Display(Name ="Thursday")]
        public bool WorkingThursday { get; set; }
        [Display(Name = "Friday")]
        public bool WorkingFriday { get; set; }
        [Display(Name = "Saturday")]
        public bool WorkingSaturday { get; set; }
        [Display(Name = "Sunday")]
        public bool WorkingSunday { get; set; }
    }
}