using Melodex.Domain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melodex.Infrastructure.Interfaces
{
    public interface IMediaItemRepository
    {
        public MediaItem Create(MediaItem mediaItem);
        public void Delete(int id);
        public List<MediaItem> GetAll();
        public MediaItem GetById(int id);
        public MediaItem Update(int id);
    }
}
