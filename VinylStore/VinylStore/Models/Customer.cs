using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VinylStore.Models
{
    public class Customer
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public  string LastName  { get; set; }
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
        public int AmountOfBorrowedVinyls { get; set; }
    }
}