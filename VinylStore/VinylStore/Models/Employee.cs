using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace VinylStore.Models
{
    public class Employee
    {
        public int Id { get; set; }
        [Required]
        [Display(Name ="First name.")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name =" Last name")]
        public string LastName { get; set; }
        [Display(Name ="Name")]
        public string FullName {
            get
            {
                return this.FirstName + " " + this.LastName; 
            }
            set
            {
                FullName = value;
            }
        }
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