using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using Melodex.Application.DTOs;
using Melodex.Application.Interfaces;
using Melodex.Domain.Models;
using Melodex.Infrastructure.Interfaces;
using Melodex.Infrastructure.Repositories;

namespace Melodex.Application.Services
{
    public class MediaItemService : IMediaItemService
    {
        private readonly IMapper _mapper;
        private readonly IMediaItemRepository _mediaItemRepository;

        public MediaItemService(IMapper mapper, IMediaItemRepository mediaItemRepository)
        {
            _mapper = mapper;
            _mediaItemRepository = mediaItemRepository;
        }

        public List<MediaItemDTO> GetAll()
        {
            var mediaItems = _mediaItemRepository.GetAll();
            return _mapper.Map<List<MediaItemDTO>>(mediaItems);
        }
    }
}
