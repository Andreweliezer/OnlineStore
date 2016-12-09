using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineStore.Domain.Entities
{
    public class Product
    {
        public int productId { set; get; }
        public string name { set; get; }
        public string description { get; set; }
        public decimal price { get; set; }
        public string category { get; set; }
    }
}
