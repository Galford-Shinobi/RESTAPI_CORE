using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using RESTAPI_CORE.DAL.Application.Implementation;
using RESTAPI_CORE.DAL.Application.Interfaces;
using RESTAPI_CORE.DAL.DBContext;
using RESTAPI_CORE.Entity.Entities;

namespace RESTAPI_CORE.IOC.Dependencies
{
    public static class Dependence
    {
        public static void InyectarDependencia(this IServiceCollection services, IConfiguration Configuration)
        {
            services.AddDbContext<ApplicationDbContext>(options => {
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
            });
            //services.AddTransient(typeof(IGenericRepository<>), typeof(GenericRepository<>));
            services.AddScoped<ICategoriaRepository, CategoriaRepository>();
            //services.AddScoped<ICorreoService, CorreoService>();
            //services.AddScoped<IFireBaseService, FireBaseService>();
            //services.AddScoped<IUtilitiesService, UtilitiesService>();
            //services.AddScoped<IRolService, RolService>();
            //services.AddScoped<IUserService, UserService>();
            //services.AddScoped<INegocioService, NegocioService>();
        }
    }
}
