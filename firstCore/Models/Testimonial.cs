using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstCore.Models
{
    public class Testimonial
    {
        public int ID { get; set; }
        public string PhotoURL { get; set; }
        public string Header { get; set; }
        public string Description { get; set; }
        public int Rating { get; set; }
    }
}
