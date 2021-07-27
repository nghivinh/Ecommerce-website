using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Logitech.Models
{
    public class Account
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(20)]
        public string UserName { get; set; }

        [Required]
        public string Password { get; set; }

        [Required]
        [NotMapped]
        [System.ComponentModel.DataAnnotations.Compare("Password")]
        public string ConfirmPassword { get; set; }

        [Required]
        public string FullName { get; set; }

        [Required]
        [StringLength(10)]
        public string PhoneNumber { get; set; }

        public string Avarta { get; set; }

        public List<Rating> ProductRating { get; set; } = new List<Rating>();
    }
}
