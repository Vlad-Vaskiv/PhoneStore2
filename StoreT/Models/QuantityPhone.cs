using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreT.Models
{
    public class QuantityPhone
    {
        public int Id { get; set; }
        public int QuantId { get; set; }
        public ModelPhone ModelPhone { get; set; }
        public int? Quantity { get; set; }
    }
}
