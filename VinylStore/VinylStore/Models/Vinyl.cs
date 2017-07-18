using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VinylStore.Models
{
    public class Vinyl
    {
        
        int Id { get; set; }
        string Name { get; set;}
        string Artist { get; set; }
        string Album { get; set; }
        DateTime? PublishDate { get; set; }
        DateTime? LendDeadline { get; set; }
        double? Price { get; set; }
        bool ForSale { get; set; }
        string Borrower { get; set; }
        virtual public ICollection<Customer> Customers { get; set; }

    }
}