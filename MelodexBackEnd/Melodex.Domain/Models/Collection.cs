using Melodex.Domain.Models;
using System.ComponentModel.DataAnnotations;

namespace Melodex.Domain.Models
{
    public class Collection
    {
        [Key]
        public Guid Id { get; set; }

        public List<MediaItem> MediaItems { get; set; } = new();
    }
}
