using Microsoft.EntityFrameworkCore;
using RESTAPI_CORE.Common.Response;
using RESTAPI_CORE.DAL.Application.Interfaces;
using RESTAPI_CORE.DAL.DBContext;

namespace RESTAPI_CORE.DAL.Application.Implementation
{
    public class GenericRepositoryFactory<TEntity> : IGenericRepositoryFactory<TEntity> where TEntity : class
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public GenericRepositoryFactory(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public async Task<GenericResponse<TEntity>> AddDataAsync(TEntity entity)
        {
            try
            {
                _applicationDbContext.Set<TEntity>().Add(entity);
                await _applicationDbContext.SaveChangesAsync();
                return new GenericResponse<TEntity>
                {
                    IsSuccess = true,
                    DirectObject = entity,
                };
            }
            catch (Exception exc)
            {
                return new GenericResponse<TEntity>
                {
                    IsSuccess = false,
                    Message = exc.Message,
                };
            }
        }

        public async Task<GenericResponse<TEntity>> DeleteDataAsync(TEntity entity)
        {
            try
            {
                _applicationDbContext.Set<TEntity>().Remove(entity);
                await _applicationDbContext.SaveChangesAsync();
                return new GenericResponse<TEntity>
                {
                    IsSuccess = true,
                    DirectObject = entity,
                };
            }
            catch (Exception exc)
            {
                return new GenericResponse<TEntity>
                {
                    IsSuccess = false,
                    Message = exc.Message,
                };
            }
        }

        public async Task<IReadOnlyList<TEntity>> GetAllDataAsync()
        {
            IReadOnlyList<TEntity> queryEntity = await _applicationDbContext.Set<TEntity>().ToListAsync();
            return queryEntity;
        }


        public async Task<GenericResponse<TEntity>> UpdateDataAsync(TEntity entity)
        {
            try
            {
                _applicationDbContext.Set<TEntity>().Update(entity);
                await _applicationDbContext.SaveChangesAsync();
                return new GenericResponse<TEntity>
                {
                    IsSuccess = true,
                    DirectObject = entity,
                };
            }
            catch (Exception exc)
            {
                return new GenericResponse<TEntity>
                {
                    IsSuccess = false,
                    Message = exc.Message,
                };
            }
        }
    }
}
