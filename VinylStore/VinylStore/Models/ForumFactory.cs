using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace VinylStore.Models
{
    public interface IForumTopicsPosts
    {
         ForumPost CreatePost();
         ForumTopic CreateTopic();
    }
    public class ForumFactory : IForumTopicsPosts
    {
        public virtual ForumPost CreatePost()
        {
            ForumPost post = new ForumPost();
            return post;
        }
        public virtual ForumTopic CreateTopic()
        {
            ForumTopic topic = new ForumTopic();
            return topic;
        }
       
    }
}