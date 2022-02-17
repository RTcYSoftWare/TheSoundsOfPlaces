using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TheSoundsOfPlaces.Database
{
    public class Admin
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public Guid GUID { get; set; }

        [Column(TypeName = ("varchar(50)"))]
        [Required]
        public string NameSurname { get; set; }

        [Column(TypeName = ("varchar(50)"))]
        [Required]
        public string Email { get; set; }

        [Column(TypeName = ("varchar(50)"))]
        [Required]
        public string Password { get; set; }

        [Column(TypeName = ("char(11)"))]
        [Required]
        public string Phone { get; set; }

        public int? Gender { get; set; }

        public int? CityId { get; set; }
        public int? DistrictId { get; set; }

        public bool Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public Nullable<DateTime> UpdatedAt { get; set; }
        public Nullable<DateTime> DeletedAt { get; set; }
    }
}
