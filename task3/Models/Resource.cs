using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task3.Models
{
    internal class Resource
    {
        public int ResourceId { get; set; }

        public string Name { get; set; } // up to 50 chars, Unicode

        public string Url { get; set; } // non-Unicode

        public ResourceType ResourceType { get; set; }

        public int CourseId { get; set; }
        public Course Course { get; set; }
    }
}
