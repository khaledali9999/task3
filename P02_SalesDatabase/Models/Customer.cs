using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_SalesDatabase.Models
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string Name { get; set; } // [MaxLength(100)]
        public string Email { get; set; } // [MaxLength(80)], non-Unicode
        public string CreaditCardNumber { get; set; }
        public ICollection<Sale> Sales { get; set; } = new HashSet<Sale>();
    }
}
