using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreT.Models
{
    public class ImageModel
    {
        public int Id { get; set; }
        public int ImageModelId { get; set; }
        public ModelPhone ModelPhone { get; set; }
        public string ImageModelAddress { get; set; }
    }
}
