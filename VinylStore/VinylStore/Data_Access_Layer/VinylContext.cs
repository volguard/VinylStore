using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Data.SqlClient;
using System.Data.Entity;
using System.Data.Entity.SqlServer;

namespace VinylStore.Data_Access_Layer
{
    public class VinylContext : DbContext
    {
        public VinylContext() : base("name=VinylContext") { }
            public DbSet<VinylStore.Models.Vinyl> Vinyls { get; set; }
            public DbSet<VinylStore.Models.Customer> Customers { get; set; }
            public DbSet<VinylStore.Models.Employee> Employees { get; set; }
        
    }
}