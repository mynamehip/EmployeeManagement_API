using Dapper;
using MISA.WebFresher052023.Demo.Domain;
using MISA.WebFresher052023.Demo.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.WebFresher052023.Demo.Infrastructure.Repository.Base
{
    public abstract class BaseReadonlyRepository<TEntity, TModel> : IReadOnlyRepository<TEntity, TModel>
    {
        protected readonly IUnitOfWork _uow;

        public virtual string TableName { get; protected set; } = typeof(TEntity).Name;
        public virtual string TableId { get; protected set; } = typeof(TEntity).Name + "Id";

        protected BaseReadonlyRepository(IUnitOfWork unitOfWork)
        {
            _uow = unitOfWork;
        }

        public async Task<TEntity?> FindAsync(Guid id)
        {
            var parameters = new DynamicParameters();
            parameters.Add("@id", id);

            var result = await _uow.Connection.QueryFirstOrDefaultAsync<TEntity>($"Proc_{TableName}_GetById", parameters, commandType: CommandType.StoredProcedure, transaction: _uow.Transaction);

            return result;
        }

        public async Task<IEnumerable<TModel>> GetAllAsync()
        {
            var result = await _uow.Connection.QueryAsync<TModel>($"Proc_{TableName}_GetAll", commandType: CommandType.StoredProcedure, transaction: _uow.Transaction);
            return result;
        }

        public async Task<TEntity> GetAsync(Guid id)
        {
            var entity = await FindAsync(id);
            if (entity == null)
            {
                throw new NotFoundException("Không tìm thấy theo id");
            }
            return entity;
        }

        public async Task<IEnumerable<TEntity>> GetListByIdsAsync(List<Guid> ids)
        {
            var sql = $"SELECT * FROM {TableName} WHERE {TableId} IN @listIds;";

            var parameters = new DynamicParameters();
            parameters.Add("@listIds", ids);
            var entities = await _uow.Connection.QueryAsync<TEntity>(sql, parameters, transaction: _uow.Transaction);

            return entities; 
        }
    }
}
