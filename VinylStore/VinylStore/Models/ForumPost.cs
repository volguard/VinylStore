using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace VinylStore.Models
{
    [Table("ForumPosts")]
    public class ForumPost : NonPersonEntity
    {
        [Column]
        public string Author { get; set; }
        [Column]
        public string Content { get; set; }
        [Column]
        public string Subject { get; set; } 
    }
}