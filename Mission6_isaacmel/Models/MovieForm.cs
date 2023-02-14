using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

//category string, title string, year number, director string, rating dropdown string, edited bool, lent to string, notes string 25char
namespace Mission6_isaacmel.Models
{
    public class MovieForm
    {
        [Key]
        [Required]
        public int ApplicationId { get; set; }
        [Required]
        public string Category { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public int Year { get; set; }
        [Required]
        public string DirectorFirstName { get; set; }
        [Required]
        public string DirectoryLastName { get; set; }
        [Required]
        public string Rating { get; set; }
        [Required]
        public bool Edited { get; set; }
        public string LentTo { get; set; }
        [MaxLength(25)]
        public string Notes { get; set; }


    }
}
