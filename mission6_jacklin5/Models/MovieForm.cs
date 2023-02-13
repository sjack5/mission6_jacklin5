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
        
        [Required]
        public string Category { get; set; }

        [Required]
        public string Title { get; set; }
        
        [Required]
        public ushort Year { get; set; }

        [Required]
        public string Director { get; set; }

        [Required]
        public string Rating { get; set; }

        public bool Edited { get; set; }

        public string Lent { get; set; }

        [MaxLength(25)]
        public string Notes { get; set; }
    }
}
