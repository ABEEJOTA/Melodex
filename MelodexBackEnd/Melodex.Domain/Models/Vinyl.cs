using Melodex.Domain.Models;

namespace Melodex.Domain.Models
{
    public enum VinylSize { SevenInch, TenInch, TwelveInch }
    public enum VinylSpeed { RPM33, RPM45, RPM78 }

    public class Vinyl : MediaItem
    {
        public VinylSize Size { get; set; }
        public VinylSpeed Speed { get; set; }
        public string Color { get; set; } // Edición especial (rojo, transparente)
        public bool LimitedEdition { get; set; }
        public string PressingInfo { get; set; }
    }
}
