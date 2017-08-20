using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace VinylStore.Models
{
    public class LendVinyl
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Display(Name = "Artist")]
        public string Artist { get; set; }
        [Display(Name = "Album")]
        public string Album { get; set; }
        [Display(Name = "Date of publish")]
        public DateTime? DateOfPublish { get; set; }
        [Display(Name = "Id of borrower")]
        public int? CustomerId { get; set; }
        [Display(Name = "Name of borrower")]
        public string CustomerFullName { get; set; }
        [Display(Name = "Vinyl is lend from")]
        public DateTime? LendFrom { get; set; }
        [Display(Name="Vinyl is lend to")]
        public DateTime? LendTo { get; set; }
    }
}