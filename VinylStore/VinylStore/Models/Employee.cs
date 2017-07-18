using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VinylStore.Models
{
    public class Employee
    {
        int Id { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string FullName { get; set; }
        decimal InitialSalary { get; set; }
        decimal CurrentSalary { get; set; }
    }
}