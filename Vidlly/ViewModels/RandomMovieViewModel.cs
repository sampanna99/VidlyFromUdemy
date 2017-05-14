using System.Collections.Generic;
using Vidlly.Models;

namespace Vidlly.ViewModels
{
    public class RandomMovieViewModel
    {
        public Movie Movie { get; set; }

        public List<Customer> Customers { get; set; }

    }
}