using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace TheSoundsOfPlaces.Database
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Column(TypeName = ("varchar(50)"))]
        [Required]
        public string Title { get; set; }

        [Column(TypeName = ("varchar(50)"))]
        [Required]
        public string Slug { get; set; }

        public bool Status { get; set; }
        public DateTime CreatedAt { get; set; }
        public Nullable<DateTime> UpdatedAt { get; set; }
        public Nullable<DateTime> DeletedAt { get; set; }
    }
}
