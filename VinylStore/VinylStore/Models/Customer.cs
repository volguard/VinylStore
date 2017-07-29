using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace VinylStore.Models
{
    [Table("Customers")]
    public class Customer
    {
        [Key]
        public int CustomerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FullName { get; set; }
        public int BorrowedVinyls { get; set; }
        public virtual int VinylId {get;set;}
        //virtual public ICollection<Vinyl> BorrowVinyls { get; set; }
    }
}