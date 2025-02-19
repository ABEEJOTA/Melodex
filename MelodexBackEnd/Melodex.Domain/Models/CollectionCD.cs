using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melodex.Domain.Models
{
    public class CollectionCD
    {
        public Guid CollectionId { get; set; }
        public Collection Collection { get; set; }

        public Guid CDId { get; set; }
        public CD CD { get; set; }
    }
}
