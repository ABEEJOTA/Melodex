using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melodex.Domain.Models
{
    public class CollectionCassette
    {
        public Guid CollectionId { get; set; }
        public Collection Collection { get; set; }

        public Guid CassetteId { get; set; }
        public Cassette Cassette { get; set; }
    }
}
