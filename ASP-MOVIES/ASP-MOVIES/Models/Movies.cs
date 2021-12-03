using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASP_MOVIES.Models
{
    public enum Genre
    {
        Comedy, Drama, Action, Thriller
    }
    public class Movies
    {
        [Key]
        public int ID { get; set; }
        
        public string Title { get; set; }
       
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public Genre Genre { get; set; }
        public decimal Price { get; set; }

    }
}
