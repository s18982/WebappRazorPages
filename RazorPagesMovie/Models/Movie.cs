using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using Castle.MicroKernel.SubSystems.Conversion;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorPagesMovie.Models
{
    public class Movie
    {
        public int ID { get; set; }
        [Display(Name = "Tytuł")]
        [StringLength(60, MinimumLength = 3)]
        [Required]
        public string Title { get; set; } = string.Empty;
        [Display(Name = "Data wydania")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [Display(Name = "Gatunek")]
        [Required]
        [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
        [StringLength(30)]
        public string Genre { get; set; } = string.Empty;
        [Display(Name = "Cena")]
        [Column(TypeName = "decimal(18,2)")]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
        [Required]
        [StringLength(5)]
        [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
        public string Rating { get; set; } = string.Empty;

    }
}
