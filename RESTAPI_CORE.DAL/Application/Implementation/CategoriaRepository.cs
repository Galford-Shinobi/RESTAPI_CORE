using RESTAPI_CORE.Common.Response;
using RESTAPI_CORE.DAL.Application.Interfaces;
using RESTAPI_CORE.DAL.DBContext;
using RESTAPI_CORE.Entity.Entities;

namespace RESTAPI_CORE.DAL.Application.Implementation
{
    public class CategoriaRepository : GenericRepositoryFactory<Categorium>, ICategoriaRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public CategoriaRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }

        public Task<GenericResponse<Categorium>> DeactivateConceptoAsync(Categorium avatar)
        {
            throw new NotImplementedException();
        }

        public Task<GenericResponse<Categorium>> DeleteConceptoAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<List<Categorium>> GetAllConceptoAsync()
        {
            throw new NotImplementedException();
        }

        public Task<GenericResponse<Categorium>> GetOnlyConceptoAsync(int id)
        {
            throw new NotImplementedException();
        }

        public Task<GenericResponse<Categorium>> OnlyConceptoGetAsync(int id)
        {
            throw new NotImplementedException();
        }
    }
}
