using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Novost
    {
        public int Id { get; set; }
        [Required]
        public string Slika { get; set; }
        [Required]
        public string Naslov { get; set; }
        [Required]
        public string Kratko { get; set; }
        [Required]
        public string Storija { get; set; }
    }
}