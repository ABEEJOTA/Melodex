using Melodex.Domain.Models;

namespace Melodex.Domain.Models
{
    public enum TapeType { Normal, Chrome, Metal }

    public class Cassette
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public int ReleaseYear { get; set; }
        public string Genre { get; set; }
        public string Label { get; set; }
        public string Notes { get; set; }
        public string ImageUrl { get; set; }
        public int TapeType { get; set; }
        public string PlayTime { get; set; }
    }
}
