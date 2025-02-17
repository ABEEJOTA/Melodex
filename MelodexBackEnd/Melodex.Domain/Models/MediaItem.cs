using Melodex.Domain.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Melodex.Domain.Models
{
    public enum MediaFormat { Vinyl, CD, Cassette }

    public class MediaItem
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public int ReleaseYear { get; set; }
        public string Genre { get; set; }
        public int Format { get; set; }
        public string Label { get; set; }
        public string Barcode { get; set; }
        public string Notes { get; set; }
        public string ImageUrl { get; set; }
    }
}
