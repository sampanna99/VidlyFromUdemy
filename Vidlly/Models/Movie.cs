using System;
using System.ComponentModel.DataAnnotations;

namespace Vidlly.Models
{
    public class Movie
    {
        public int Id { get; set; }
        public string Name { get; set; }

        [Required]
        public Genre Genre { get; set; }


        public byte GenreId { get; set; }

        public DateTime ReleasedDate { get; set; }


        public string NumberInStock { get; set; }
    }
}