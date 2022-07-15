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
        [Display(Name ="Tytuł")]
        public string Title { get; set; } = string.Empty;
        [Display(Name = "Data wydania")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        [Display(Name = "Gatunek")]
        public string Genre { get; set; } = string.Empty;
        [Display(Name = "Cena")]
        [Column(TypeName="decimal(18,2)")]
        public decimal Price { get; set; }
    }
}
