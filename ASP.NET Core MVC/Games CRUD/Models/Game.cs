using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace PatrykKaczynskiLab5ZadDom.Models
{
    public class Game
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Tytuł")]
        public string Title { get; set; }

        [Required]
        [Display(Name = "Rok wydania")]
        public int YearOfRelease { get; set; }

        [Required]
        [Display(Name = "Producent")]
        public int ProducerId { get; set; }

        [ForeignKey("ProducerId")]
        [Display(Name = "Producent")]
        public Producer Producer { get; set; }

        [Required]
        [Display(Name = "Gatunek")]
        public int GenreId { get; set; }

        [ForeignKey("GenreId")]
        public Genre Genre { get; set; }

        [Required]
        [Display(Name = "Tryb")]
        public int ModeId { get; set; }

        [ForeignKey("ModeId")]
        public Mode Mode { get; set; }
    }
}
