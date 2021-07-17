using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logitech.Models
{
    public class LoadProduct
    {
        public int Id { get; set; }

        public string Image { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public int Price { get; set; }

        public int SaleOff { get; set; }

        public int Store { get; set; }

        public int Sold { get; set; }

        public bool Featured { get; set; }

        public int CategoryId { get; set; }

        public float? Star { get; set; }
    }
}
