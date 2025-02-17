using Melodex.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melodex.Application.DTOs
{
    public class VinylDTO : MediaItemDTO
    {
        public Guid Id { get; set; }
        public Guid MediaItemId { get; set; }
        public string Edition { get; set; }
        public bool IsSigned { get; set; }

        public MediaItem MediaItem { get; set; }
    }
}
