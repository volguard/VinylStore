using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VinylStore.Models
{
    public class SellVinyl
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Artist { get; set; }
        public string Album { get; set; }
        public DateTime DateOfPublish { get; set; }
        public decimal Price { get; set; }
        public int StorageAmount { get; set; }
    }
}