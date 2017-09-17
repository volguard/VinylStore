using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VinylStore.Models
{
    public class ForumPost : NonPersonEntity
    {
        public string Author { get; set; }
        public string Content { get; set; }
        internal string Subject { get; set; } 
    }
}