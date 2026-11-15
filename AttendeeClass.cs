using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFCore02
{
    public class AttendeeClass
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(150)]
        public string FName { get; set; } = string.Empty;

        [Required]
        [MaxLength(200)]
        public string Email { get; set; } = string.Empty;

        [Required]
        [MaxLength(200)]
        public string Street { get; set; } = string.Empty;

        [Required]
        [MaxLength(150)]
        public string City { get; set; } = string.Empty;


        [Required]
        [MaxLength(100)]
        public string Country { get; set; } = string.Empty;

        [Required]
        [MaxLength(20)]
        [Column("ZipCode")]
        public string PostalCode { get; set; } = string.Empty;

        [NotMapped]
        public string FullAddress => $"{Street}, {City}, {Country} - {PostalCode}";
        public BadgeClass? badge { get; set; }

    }
}
