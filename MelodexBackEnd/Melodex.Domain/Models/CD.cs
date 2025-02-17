using Melodex.Domain.Models;

namespace Melodex.Domain.Models
{
    public enum CDPackaging { JewelCase, Digipak, Slipcase, Boxset }

    public class CD
    {
        public Guid Id { get; set; }
        public Guid MediaItemId { get; set; }
        public bool BonusTracks { get; set; }
        public string Packaging { get; set; }

        public MediaItem MediaItem { get; set; }
    }
}
