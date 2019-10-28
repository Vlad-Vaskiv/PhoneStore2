using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreT.Models
{
    public class ModelPhone
    {
        public int Id { get; set; }
        public int FirmId { get; internal set; }
        public string model { get; set; }
    
        public FirmPhones FirmPhones { get; set; }
        public Charachteristic Charachteristic { get; set; }
        public ImageModel ImageModel { get; set; }
        public QuantityPhone QuantityPhone { get; set; }
    }
}
