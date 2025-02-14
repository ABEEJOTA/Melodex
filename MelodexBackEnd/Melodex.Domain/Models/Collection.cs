using Melodex.Domain.Models;
using System.ComponentModel.DataAnnotations;

namespace Melodex.Domain.Models
{
    public class Collection
    {
        [Key]
        public Guid Id { get; set; }

        [Required]
        public string Name { get; set; } // "Mi Colección Favorita"

        public List<MediaItem> Items { get; set; } = new();
    }
}
