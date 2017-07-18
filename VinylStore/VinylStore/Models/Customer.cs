using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VinylStore.Models
{
    public class Customer
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string FullName { get; set; }
        virtual public ICollection<Vinyl> BorrowVinyls { get; set; }
    }
}