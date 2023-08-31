using System.Text.Json.Serialization;

namespace BookReview.Model
{
    public class Review
    {
        public int Id { get; set; }
        public User User { get; set; }
        public string Content { get; set; }
        public int Rating { get; set; }
        public DateTime CreatedDate { get; set; }
        [JsonIgnore]
        public Book Book { get; set; }
    }
}
