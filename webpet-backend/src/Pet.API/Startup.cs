using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Pet.Application.Interfaces;
using Pet.Application.Services;
using Pet.Domain.Core.Interfaces.Repositories;
using Pet.Infrastructure.Data;
using Pet.Infrastructure.Data.Repositories;

namespace Pet.API
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var connection = Configuration["ConnectionStrings:DefaultConnection"];

            services.AddDbContext<AppDbContext>(options => options.UseNpgsql(connection));
            services.AddControllers();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_3_0);
            IoC(services);
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo{ Title = "API Pet", Version = "v1"});
            });
        }

        public void IoC(IServiceCollection services)
        {
            //Pega todas as repository
            Assembly repository_assembly = typeof(BaseRepository<>).GetTypeInfo().Assembly;
            var repository_types = repository_assembly.ExportedTypes
                .Where(t => t.Name.EndsWith("Repository") && !t.Name.StartsWith("Base") && !t.IsInterface)
                .Select(t => new
                {
                    Implementacao = t,
                    Interfaces = t.GetInterfaces()
                }).ToList();
            foreach (var relation in repository_types)
            {
                foreach (var Interface in relation.Interfaces)
                {
                    services.AddScoped(Interface, relation.Implementacao);
                }
            }
            
            //Pega todas as services 
            Assembly services_assembly = typeof(BaseApplicationService<>).GetTypeInfo().Assembly;
            var service_types = services_assembly.ExportedTypes
                .Where(t => t.Name.EndsWith("Service") && !t.Name.StartsWith("Base") && !t.IsInterface)
                .Select(t => new
                {
                    Implementacao = t,
                    Interfaces = t.GetInterfaces()
                }).ToList();
            foreach (var relation in service_types)
            {
                foreach (var Interface in relation.Interfaces)
                {
                    services.AddScoped(Interface, relation.Implementacao);
                }
            }
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "API Pet");
            });
            
            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
