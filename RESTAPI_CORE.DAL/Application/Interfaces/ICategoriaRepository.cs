using RESTAPI_CORE.Common.Response;
using RESTAPI_CORE.Entity.Entities;

namespace RESTAPI_CORE.DAL.Application.Interfaces
{
    public interface ICategoriaRepository : IGenericRepositoryFactory<Categorium>
    {
        Task<List<Categorium>> GetAllConceptoAsync();
        Task<GenericResponse<Categorium>> GetOnlyConceptoAsync(int id);
        Task<GenericResponse<Categorium>> OnlyConceptoGetAsync(int id);
        Task<GenericResponse<Categorium>> DeleteConceptoAsync(int id);
        Task<GenericResponse<Categorium>> DeactivateConceptoAsync(Categorium avatar);
    }
}
