using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity;
using System.Globalization;
using System.Web.Security;


namespace JusticeWebApp.Data
{
    public class Comment
    {
        public int Id { get; set; }

        [Required]
        [Display(Name = "Name")]
        public string Name { get; set; }

        public string Email { get; set; }

        [Required]
        public string Message { get; set; }

        public DateTime Created { get; set; }

        public ICollection<Reply> Replies { get; set; }
    }
}