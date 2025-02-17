using Melodex.Application.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Melodex.Application.Interfaces
{
    public interface IMediaItemService
    {
        public List<MediaItemDTO> GetAll();
    }
}
