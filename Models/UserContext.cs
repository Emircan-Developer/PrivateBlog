using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace PrivateBlog.Models
{
    public class UserContext:DbContext
    {
        public DbSet<User> UserDb { get; set; }
    }
}