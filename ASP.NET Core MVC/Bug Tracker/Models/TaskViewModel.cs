using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace PatrykKaczynskiLab4ZadDom.Models
{
    public class TaskViewModel
    {
        [Key]
        public int TaskId { get; set; }
        [DisplayName("Nazwa aplikacji")]
        [Required(ErrorMessage = "Pole \"Nazwa aplikacji\" jest wymagane")]
        [MaxLength(50)]
        public string ApplicationName { get; set; }
        [DisplayName("Tytuł")]
        [Required(ErrorMessage = "Pole \"Tytuł\" jest wymagane")]
        [MaxLength(50)]
        public string Title { get; set; }
        [DisplayName("Priorytet")]
        public string Priority { get; set; }
        [Required(ErrorMessage = "Pole \"Opis\" jest wymagane")]
        [MaxLength(2000)]
        [DisplayName("Opis")]
        public string Description { get; set; }
        public bool Done { get; set; }
        public DateTime timeCreation { get; set; }
        public DateTime timeEdition { get; set; }
    }
}
