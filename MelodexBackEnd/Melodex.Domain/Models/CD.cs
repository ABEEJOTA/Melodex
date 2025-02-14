using Melodex.Domain.Models;

namespace Melodex.Domain.Models
{
    public enum CDPackaging { JewelCase, Digipak, Slipcase, Boxset }

    public class CD : MediaItem
    {
        public string Edition { get; set; } // Deluxe, Remastered, etc.
        public bool IsSigned { get; set; }
        public bool BonusTracks { get; set; }
        public CDPackaging Packaging { get; set; }
    }
}
