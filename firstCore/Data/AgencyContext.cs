using firstCore.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstCore.Data
{
    public class AgencyContext:DbContext
    {
        public AgencyContext(DbContextOptions<AgencyContext> options) : base(options)
        {}
        public DbSet<About>Abouts { get; set; }
        public DbSet<Blog> Blogs { get; set; }
        public DbSet<Brand> Brands { get; set; }
        public DbSet<Section1> Section1s { get; set; }
        public DbSet<Portfolio> Portfolios { get; set; }
        public DbSet<Testimonial> Testimonials { get; set; }
        public DbSet<Service> Services { get; set; }
    }
}
