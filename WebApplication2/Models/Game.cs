using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Game
    {
        public int Id { get; set; }
        [Required]
        public string Slika { get; set; }
        [Required]
        public string Ime { get; set; }
        [Required]
        public string Opis { get; set; }
        [Required]
        [Range(0,10)]
        public int Ocena { get; set; }
        [Required]
        public string Recenz { get; set; }
        [Required]
        public string Poster { get; set; }
        [Required]
        public string GameplaySlika { get; set; }
    }
}