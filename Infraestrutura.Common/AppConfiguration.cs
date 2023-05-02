using AutoMapper;
using Data.Repository;
using Domain.Entities;
using Domain.IRepository;
using Microsoft.Extensions.DependencyInjection;
using Services.Interfaces;
using Services.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infraestrutura
{
    public static class AppConfiguration
    {

        public static void ConfigureApp(IServiceCollection services, Microsoft.Extensions.Configuration.IConfigurationRoot configuration)
        {
            ConfigureRepository(services);
            ConfigureService(services);

        }

        private static void ConfigureRepository(IServiceCollection services)
        {
            
           services.AddScoped<ICommonRepository<Categoria>, CategoriaRepository>();
           services.AddScoped<ICategoriaRepository, CategoriaRepository>();
    
        }
        private static void ConfigureService(IServiceCollection services)
        {
            services.AddScoped<ICategoriaService, CategoriaService>();

        }
    }
}
