using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreT.Models
{
    public class Charachteristic
    {
        public int Id { get; set; }
        public int ModelId { get; set; }
    
        public string Display { get; set; }
        public string Camera { get; set; }
        public string Processor { get; set; }
        public string Storage { get; set; }
        public string Battery { get; set; }
        public string Others { get; set; }
        public string Price { get; set; }
        public ModelPhone ModelPhone { get; set; }
    }
}
