using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreT.Models
{
    public class ImageUser
    {
        public int Id { get; set; }
        public string ImageAddress { get; set; }
        public string UserId { get; set; }
        public virtual User Users { get; set; }
    }
}
