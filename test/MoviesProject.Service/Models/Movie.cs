using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieProject.Service.Models
{
    public class Movie
    {
        [Key]
        public int Id { get; set; }
        public string Title { get; set; }
        public int Year { get; set; }
        public int Runtime { get; set; }
        public string Genres { get; set; }
        public string Directors { get; set; }
        public string Actors { get; set; }
        public string Plot { get; set; }
        public string ImageUrl { get; set; }
    }
}
