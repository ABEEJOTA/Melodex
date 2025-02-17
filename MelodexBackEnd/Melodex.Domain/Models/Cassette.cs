using Melodex.Domain.Models;

namespace Melodex.Domain.Models
{
    public enum TapeType { Normal, Chrome, Metal }

    public class Cassette
    {
        public Guid Id { get; set; }
        public Guid MediaItemId { get; set; }
        public int TapeType { get; set; }
        public string PlayTime { get; set; }

        public MediaItem MediaItem { get; set; }
    }
}
