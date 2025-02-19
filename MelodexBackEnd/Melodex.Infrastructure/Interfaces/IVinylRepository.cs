using Melodex.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melodex.Infrastructure.Interfaces
{
    public interface IVinylRepository
    {
        public Vinyl Create(Vinyl mediaItem);
        public void Delete(int id);
        public List<Vinyl> GetAll();
        public Vinyl GetById(int id);
        public Vinyl Update(int id);
    }
}
