using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logitech.Models
{
    public class ProductRating
    {
        public int Id { get; set; }
        public float Rating { get; set; }

        public virtual Account Account { get; set; }
    }
}
