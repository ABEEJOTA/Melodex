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
    public class MediaItemRepository : IMediaItemRepository
    {
        private readonly MelodexDbContext _context;

        public MediaItemRepository(MelodexDbContext context)
        {
            _context = context;
        }

        public MediaItem Create(MediaItem mediaItem)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }

        public List<MediaItem> GetAll()
        {
            return _context.MediaItems.ToList();
        }

        public MediaItem GetById(int id)
        {
            throw new NotImplementedException();
        }

        public MediaItem Update(int id)
        {
            throw new NotImplementedException();
        }
    }
}
