using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace ServicesPortal.Models.Database
{
    public class ServicesPortalContext : DbContext
    {
        public ServicesPortalContext()
            : base("ServicesPortal")
        {
        }

        public DbSet<Service> Services { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Comment> Comments { get; set; }
        public DbSet<CommentCategory> CommentCategories { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<ServiceProvider> ServiceProviders { get; set; }

    }
}