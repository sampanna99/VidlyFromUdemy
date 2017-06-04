using System.Collections.Generic;
using Vidlly.Models;

namespace Vidlly.ViewModels
{
    public class NewMovieViewModel
    {
        public IEnumerable<Genre> Genres { get; set; }

        public Movie Movies { get; set; }
    }
}