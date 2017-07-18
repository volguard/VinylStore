using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Data.SqlClient;
using System.Data.Entity;

namespace VinylStore.Data_Access_Layer
{
    public class VinylContext : DbContext
    {
        public VinylContext() : base("VinylContext") { }
        DbSet<VinylStore.Models.Vinyl> Vinyls { get; set; }
    }
}