using Melodex.Domain.Models;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Melodex.Domain.Models
{

    public class MediaItem
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public int ReleaseYear { get; set; }
        public string Genre { get; set; }
        public string Label { get; set; }
        public string Notes { get; set; }
        public string ImageUrl { get; set; }
    }
}
