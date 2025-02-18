using Melodex.Domain.Models;

namespace Melodex.Domain.Models
{
    public enum VinylSize { SevenInch, TenInch, TwelveInch }
    public enum VinylSpeed { RPM33, RPM45, RPM78 }

    public class Vinyl
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public int ReleaseYear { get; set; }
        public string Genre { get; set; }
        public string Label { get; set; }
        public string Notes { get; set; }
        public string ImageUrl { get; set; }
        public string Edition { get; set; }
        public bool IsSigned { get; set; }
    }
}
