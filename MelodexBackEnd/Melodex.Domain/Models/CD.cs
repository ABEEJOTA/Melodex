using Melodex.Domain.Models;

namespace Melodex.Domain.Models
{
    public enum CDPackaging { JewelCase, Digipak, Slipcase, Boxset }

    public class CD
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public int ReleaseYear { get; set; }
        public string Genre { get; set; }
        public string Label { get; set; }
        public string Notes { get; set; }
        public string ImageUrl { get; set; }
        public bool BonusTracks { get; set; }
        public string Packaging { get; set; }
    }
}
