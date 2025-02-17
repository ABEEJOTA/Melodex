using Melodex.Domain.Models;

namespace Melodex.Domain.Models
{
    public enum VinylSize { SevenInch, TenInch, TwelveInch }
    public enum VinylSpeed { RPM33, RPM45, RPM78 }

    public class Vinyl
    {
        public Guid Id { get; set; }
        public Guid MediaItemId { get; set; }
        public string Edition { get; set; }
        public bool IsSigned { get; set; }

        public MediaItem MediaItem { get; set; }
    }
}
