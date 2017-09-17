using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace VinylStore.Models
{
    public class Person
    {
        public int Id { get; set; }
        [Required]
        [Display(Name = "First name.")]
        public string FirstName { get; set; }
        [Required]
        [Display(Name = " Last name")]
        public string LastName { get; set; }
        [Display(Name = "Name")]
        public string FullName
        {
            get
            {
                return this.FirstName + " " + this.LastName;
            }
            set
            {
                FullName = value;
            }
        }
    }
}