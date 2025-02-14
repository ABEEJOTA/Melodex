using Melodex.Domain.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Melodex.Domain.Models
{
    public class Track
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Title { get; set; }

        public int TrackNumber { get; set; }

        public string Duration { get; set; } // Formato HH:MM:SS

        [ForeignKey("MediaItem")]
        public Guid MediaItemId { get; set; }
        public MediaItem MediaItem { get; set; }
    }
}
