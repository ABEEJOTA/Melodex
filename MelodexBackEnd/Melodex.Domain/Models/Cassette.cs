using Melodex.Domain.Models;

namespace Melodex.Domain.Models
{
    public enum TapeType { Normal, Chrome, Metal }

    public class Cassette : MediaItem
    {
        public TapeType TapeType { get; set; }
        public string PlayTime { get; set; } // C60, C90, etc.
        public bool Rewound { get; set; }
    }
}
