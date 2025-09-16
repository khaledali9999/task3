using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P02_SalesDatabase.Models
{
    public class Store
    {
        public int StoreId { get; set; }
        public string Name { get; set; } 
        public ICollection<Sale> Sales { get; set; } = new HashSet<Sale>();
    }
}
