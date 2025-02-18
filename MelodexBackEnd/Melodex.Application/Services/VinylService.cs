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
    public class VinylService : IVinylService
    {
        private readonly IMapper _mapper;
        private readonly IVinylRepository _vinylRepository;

        public VinylService(IMapper mapper, IVinylRepository vinylRepository)
        {
            _mapper = mapper;
            _vinylRepository = vinylRepository;
        }

        public List<VinylDTO> GetAll()
        {
            var vinyls = _vinylRepository.GetAll();
            return _mapper.Map<List<VinylDTO>>(vinyls);
        }
    }
}
