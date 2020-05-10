using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PrivateBlog.Models
{
    public class BlogContext : DbContext
    {
        public DbSet<Blogs> db{get;set;}
    }
}