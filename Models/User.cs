using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PrivateBlog.Models
{
    public class User
    {
        [Key]
        public int id { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public DateTime RegisterDate { get; set; }

    }
}