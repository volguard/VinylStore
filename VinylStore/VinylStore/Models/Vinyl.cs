using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace VinylStore.Models
{
    [Table("Vinyls")]
    public class Vinyl
    {
        [Key]
        public int VinylId { get; set; }
        public string Name { get; set;}
        public string Artist { get; set; }
        public string Album { get; set; }
        public DateTime? PublishDate { get; set; }
        public DateTime? LendDeadline { get; set; }
        public double? Price { get; set; }
        public bool ForSale { get; set; }
        public virtual int CustomerId { get; set; }
        virtual public Customer Customer { get; set; }

    }
}