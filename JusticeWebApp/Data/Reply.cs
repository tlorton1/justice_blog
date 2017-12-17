using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JusticeWebApp.Data
{
    public class Reply
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public DateTime Created { get; set; }

        public int CommentId { get; set; }
    }
}