using Dapper;
using MISA.WebFresher052023.Demo.Domain;
using MISA.WebFresher052023.Demo.Domain.Entity.Base;
using MISA.WebFresher052023.Demo.Domain.Interface;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MISA.WebFresher052023.Demo.Infrastructure.Repository.Base
{
    public class BaseRepository<TEntity, TModel> : BaseReadonlyRepository<TEntity, TModel>, IBaseRepository<TEntity, TModel> where TEntity : IHasKey
    {
        public BaseRepository(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public async Task DeleteAsync(TEntity entity)
        {
            var parameters = new DynamicParameters();

            parameters.Add("@id", entity.GetKey());

            await _uow.Connection.ExecuteAsync($"Proc_{TableName}_DeleteById", parameters, commandType: CommandType.StoredProcedure, transaction: _uow.Transaction);
        }

        public async Task DeleteManyAsync(List<TEntity> entities)
        {
            var sql = $"DELETE FROM {TableName} WHERE {TableId} IN @listIds;";

            var parameters = new DynamicParameters();
            parameters.Add("@listIds", entities.Select(x => x.GetKey()));
            await _uow.Connection.ExecuteAsync(sql, parameters, transaction: _uow.Transaction);
            //await _uow.Connection.ExecuteAsync($"Proc_{TableName}_DeleteMany", parameters, commandType: CommandType.StoredProcedure, transaction: _uow.Transaction);
        }

        public async Task InsertAsync(TEntity entity)
        {
            await _uow.Connection.ExecuteAsync($"Proc_{TableName}_Create", entity, commandType: CommandType.StoredProcedure, transaction: _uow.Transaction);
        }

        public async Task UpdateAsync(TEntity entity)
        {
            await _uow.Connection.ExecuteAsync($"Proc_{TableName}_UpdateById", entity, commandType: CommandType.StoredProcedure, transaction: _uow.Transaction);
        }
    }
}
