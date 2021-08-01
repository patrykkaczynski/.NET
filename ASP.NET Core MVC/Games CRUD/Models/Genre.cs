using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PatrykKaczynskiLab5ZadDom.Models
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        [Display(Name = "Gatunek")]
        public string GenreName { get; set; }

        public ICollection<Game> Games { get; set; }
    }
}
