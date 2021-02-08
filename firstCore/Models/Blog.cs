using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace firstCore.Models
{
    public class Blog
    {
        public int ID { get; set; }
        public string SubHeader { get; set; }
        public string Header { get; set; }
        public string PhotoURL { get; set; }
        public string Role { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Description { get; set; }


    }
}
