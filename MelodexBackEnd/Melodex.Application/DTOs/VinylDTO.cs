using Melodex.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melodex.Application.DTOs
{
    public class VinylDTO
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public int ReleaseYear { get; set; }
        public string Genre { get; set; }
        public string Label { get; set; }
        public string Notes { get; set; }
        public string ImageUrl { get; set; }
        public string Edition { get; set; }
        public bool IsSigned { get; set; }

    }
}
