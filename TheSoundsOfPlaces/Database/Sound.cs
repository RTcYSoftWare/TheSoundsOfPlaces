using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TheSoundsOfPlaces.Database
{
    public class Sound
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = ("varchar(50)"))]
        [Required]
        public string Title { get; set; }

        [Column(TypeName = ("varchar(MAX)"))]
        [Required]
        public string Text { get; set; }

        public int CategoryId { get; set; }

        [Column(TypeName = ("varchar(MAX)"))]
        public string BannerImage { get; set; }

        [Column(TypeName = ("varchar(MAX)"))]
        [Required]
        public string SoundUrl { get; set; }

        [Column(TypeName = ("varchar(50)"))]
        [Required]
        public string Slug { get; set; }

        public int CityId { get; set; }

        public int DistrictId { get; set; }

        [Column(TypeName = ("varchar(50)"))]
        [Required]
        public string Latitude { get; set; }

        [Column(TypeName = ("varchar(50)"))]
        [Required]
        public string Longitude { get; set; }

        public bool Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public Nullable<DateTime> UpdatedAt { get; set; }
        public Nullable<DateTime> DeletedAt { get; set; }

        public Category Category { get; set; }
    }
}
