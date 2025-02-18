using Melodex.Domain.Models;
using Melodex.Infrastructure.Data;
using Melodex.Infrastructure.Interfaces;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melodex.Infrastructure.Repositories
{
    public class VinylRepository : IVinylRepository
    {
        private readonly MelodexDbContext _context;

        public VinylRepository(MelodexDbContext context)
        {
            _context = context;
        }

        public Vinyl Create(Vinyl mediaItem)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<Vinyl> GetAll()
        {
            return _context.Vinyls.ToList();
        }

        public Vinyl GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Vinyl Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
