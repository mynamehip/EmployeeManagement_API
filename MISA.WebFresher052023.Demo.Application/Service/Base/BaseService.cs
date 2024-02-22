using AutoMapper;
using MISA.WebFresher052023.Demo.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.WebFresher052023.Demo.Application
{
    public abstract class BaseService<TEntity, TModel, TEntityDto, TEntityCreateDto, TEntityUpdateDto> : BaseReadOnlyService<TEntity, TModel, TEntityDto>, IBaseService<TEntityDto, TEntityCreateDto, TEntityUpdateDto> where TEntity : class
    {
        protected readonly IBaseRepository<TEntity, TModel> _baseRepository;

        public BaseService(IBaseRepository<TEntity, TModel> baseRepository, IMapper mapper) : base(baseRepository, mapper)
        {
            _baseRepository = baseRepository;
        }

        public virtual async Task CreateAsync(TEntityCreateDto entityCreateDto)
        {
            //Validate nghiệp vụ

            //Lấy được entity
            Guid id = Guid.NewGuid();
            var entity = await MapCreateDtoToEntity(id, entityCreateDto);
            //Insert vào db
            await _baseRepository.InsertAsync(entity);

        }

        public async Task UpdateAsync(Guid id, TEntityUpdateDto entityUpdateDto)
        {
            //Validate nghiệp vụ
            var employee = await _baseRepository.GetAsync(id);
            if (employee == null)
            {
                throw new Exception("Không tìm thấy nhân viên");
            }

            var entity = await MapUpdateDtoToEntity(id, entityUpdateDto);
            
            //Insert vào db
            await _baseRepository.UpdateAsync(entity);
        }

        public async Task DeleteAsync(Guid id)
        {
            var entity = await _baseRepository.GetAsync(id);
            await _baseRepository.DeleteAsync(entity);
        }

        public virtual async Task DeleteManyAsync(List<Guid> ids)
        {
            List<TEntity> entities = new List<TEntity>();
            foreach (var id in ids)
            {
                TEntity entity = await _baseRepository.GetAsync(id);
                entities.Add(entity);
            }
            await _baseRepository.DeleteManyAsync(entities);
        }

        public abstract Task<TEntity> MapCreateDtoToEntity(Guid id, TEntityCreateDto entityCreateDto);
        public abstract Task<TEntity> MapUpdateDtoToEntity(Guid id, TEntityUpdateDto entityCreateDto);
    }
}
