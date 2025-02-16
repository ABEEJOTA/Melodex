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
        public VinylSize Size { get; set; }
        public VinylSpeed Speed { get; set; }
        public string Color { get; set; } // Edición especial (rojo, transparente)
        public bool LimitedEdition { get; set; }
        public string PressingInfo { get; set; }
    }
}
