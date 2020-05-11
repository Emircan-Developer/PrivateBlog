using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace PrivateBlog.Models
{
    public class Blogs
    {
        [Key]
        public int id { get; set; }
        public string BlogName { get; set; }
        public string BlogContext { get; set; }
        public string UploadImage { get; set; }

        public DateTime date { get; set; }
    }
}