using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models
{
    public class Review
    {
        public int Id { get; set; }

        public string Name { get; set; }

        [Range(1, 5, ErrorMessage = "Range of rating is 1-5")]
        public int Rating { get; set; }

        public string Content { get; set; }

        public DateTime dateTime { get; set; }
    }
}
