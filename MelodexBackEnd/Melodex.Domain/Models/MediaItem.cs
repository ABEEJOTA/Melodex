using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Melodex.Domain.Models
{
    public enum MediaFormat { Vinyl, CD, Cassette }

    public class MediaItem
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Title { get; set; }

        [Required]
        public string Artist { get; set; }

        public int ReleaseYear { get; set; }

        public string Genre { get; set; }

        [Required]
        public MediaFormat Format { get; set; }

        public string Label { get; set; }

        public string Barcode { get; set; }

        public string Notes { get; set; }

        public string ImageUrl { get; set; }

        public List<Track> Tracks { get; set; } = new();
    }
}
