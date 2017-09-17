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
        public VinylContext() : base("DefaultConnection") { }
        public DbSet<VinylStore.Models.SellVinyl> SellVinyls { get; set; }
        public DbSet<VinylStore.Models.LendVinyl> LendVinyls { get; set; }
        public DbSet<VinylStore.Models.Customer> Customers { get; set; }
        public DbSet<VinylStore.Models.Employee> Employees { get; set; }

        public System.Data.Entity.DbSet<VinylStore.Models.ForumPost> ForumPosts { get; set; }
        public DbSet<VinylStore.Models.ForumTopic> ForumTopics { get; set; }
    }
}