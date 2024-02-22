using AutoMapper;
using MISA.WebFresher052023.Demo.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.WebFresher052023.Demo.Application
{
    public abstract class BaseReadOnlyService<TEntity, TModel, TEntityDto> : IReadOnlyService<TEntityDto>
    {
        protected readonly IReadOnlyRepository<TEntity, TModel> _readOnlyRepository;
        protected readonly IMapper _mapper;

        protected BaseReadOnlyService(IReadOnlyRepository<TEntity, TModel> readOnlyRepository, IMapper mapper)
        {
            _readOnlyRepository = readOnlyRepository;
            _mapper = mapper;
        }

        public async Task<IEnumerable<TEntityDto>> GetAllAsync() 
        { 
            var entities = await _readOnlyRepository.GetAllAsync();
            var entitiesDtos = _mapper.Map<IEnumerable<TEntityDto>>(entities);
            return entitiesDtos;
        }

        public async Task<TEntityDto> GetAsync(Guid id)
        {
            var entity = await _readOnlyRepository.GetAsync(id);
            var entityDto = _mapper.Map<TEntityDto>(entity);
            return entityDto;
        }
    }
}
