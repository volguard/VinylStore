using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VinylStore.Models
{
    public class ForumTopic : NonPersonEntity
    {
        public string Subject { get; set; }
        public string Autor { get; set; }
    }
}