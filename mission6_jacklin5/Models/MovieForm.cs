using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace mission6_jacklin5.Models
{
    public class MovieForm
    {
        [Required]
        [Key]
        public int MovieID { get; set; }

        [Required(ErrorMessage ="Please enter the movie's title")]
        public string Title { get; set; }
        
        [Required(ErrorMessage = "Please enter the movie's release year")]
        public ushort Year { get; set; }

        [Required(ErrorMessage = "Please enter the movie's director")]
        public string Director { get; set; }

        [Required(ErrorMessage = "Please enter the movie's rating")]
        public string Rating { get; set; }

        public bool Edited { get; set; }

        public string Lent { get; set; }

        [MaxLength(25)]
        public string Notes { get; set; }

        //Foreign Keys
        [Required]
        public int CategoryID { get; set; }
        public Category Category { get; set; }
    }
}
