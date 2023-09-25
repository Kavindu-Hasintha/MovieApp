using System.ComponentModel.DataAnnotations;

namespace MovieApp.Models
{
    public class Movie
    {
        [Key]
        public int Episode_Id { get; set; }
        public string Title { get; set; }
        public string Opening_Crawl { get; set; }
        public string Director { get; set; } 
        public string Producer { get; set; } 
        public DateTime Release_Date { get; set; }
    }
}
