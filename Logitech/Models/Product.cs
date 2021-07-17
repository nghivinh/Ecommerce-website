using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Logitech.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required]
        public string Image { get; set; }

        [Required]
        public string Name { get; set; }

        public string Description { get; set; }

        [Required]
        public int Price { get; set; }

        public int SaleOff { get; set; }

        [Required]
        public int Store { get; set; }

        public int Sold { get; set; }

        public bool Featured { get; set; }

        public DateTime CreatedDate { get; set; }

        public DateTime UpdatedDate { get; set; }

        public virtual Category Category { get; set; }

        public List<Rating> Rating { get; set; } = new List<Rating>();
    }
}
