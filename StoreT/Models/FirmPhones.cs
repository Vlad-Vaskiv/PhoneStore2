using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreT.Models
{
    public class FirmPhones
    {
        public int Id { get; set; }
        public string NameFirm { get; set; }

        public ModelPhone ModelPhone { get; set; }
    }
}
