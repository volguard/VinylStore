using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations.Schema;

namespace VinylStore.Models
{
    [Table("ForumTopics")]
    public class ForumTopic : NonPersonEntity
    {
        [Column]
        public string Subject { get; set; }
        [Column]
        public string Autor { get; set; }
    }
}