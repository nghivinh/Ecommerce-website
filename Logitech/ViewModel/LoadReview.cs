using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Logitech.ViewModel
{
    public class LoadReview
    {
        public int ProductId { get; set; }

        public int AccountId { get; set; }

        public string FullName { get; set; }

        public float? Star { get; set; }

        public string Comment { get; set; }

        public DateTime? CreateDate { get; set; }
    }
}
