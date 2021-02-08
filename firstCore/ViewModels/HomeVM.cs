using firstCore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstCore.ViewModels
{
    public class HomeVM
    {
        public Section1 Section1 { get; set; }
        public About About { get; set; }
        public List<Service>  Services { get; set; }
        public List<Blog> Blogs { get; set; }
        public List<Testimonial> Testimonials { get; set; }
    }
}
