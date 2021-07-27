using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logitech.Models
{
    public class Rating
    {
        public int Id { get; set; }

        public float Star { get; set; }

        public string Comments { get; set; }

        public DateTime? CreateDate { get; set; }

        public int ProductId { get; set; }

        public int AccountId { get; set; }

        public virtual Product Product { get; set; }

        public virtual Account Account { get; set; }
    }
}
