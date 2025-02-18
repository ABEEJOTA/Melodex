using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melodex.Domain.Models
{
    public class CollectionVinyl
    {
        public Guid CollectionId { get; set; }
        public Collection Collection { get; set; }

        public Guid VinylId { get; set; }
        public Vinyl Vinyl { get; set; }
    }
}
