using Melodex.Domain.Models;
using System.ComponentModel.DataAnnotations;

namespace Melodex.Domain.Models
{
    public class Collection
    {
        [Key]
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public User User { get; set; }
        public List<CollectionVinyl> CollectionVinyls { get; set; } = new();
        public List<CollectionCD> CollectionCDs { get; set; } = new();
        public List<CollectionCassette> CollectionCassettes { get; set; } = new();
    }
}
