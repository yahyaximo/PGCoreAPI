using System.ComponentModel.DataAnnotations;

namespace XsisPG.Models
{
    public class Movie
    {
        [Required]
        public int Id { get; set; }
        [Required]
        public string Title { get; set; }
        public string Description { get; set; }
        public decimal Rating { get; set; }
        public string Image { get; set; }
        public DateTime Create_at { get; set; }
        public DateTime Update_at { get; set; }
    }
}
