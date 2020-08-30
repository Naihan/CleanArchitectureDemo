using CleanArch.Application.Interfaces;
using CleanArch.Application.Services;
using CleanArch.Domain.CommandHandlers;
using CleanArch.Domain.Commands;
using CleanArch.Domain.Core.Bus;
using CleanArch.Domain.Interfaces;
using CleanArch.Infra.Bus;
using CleanArch.Infra.Data.Context;
using CleanArch.Infra.Data.Repository;
using MediatR;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArch.Infra.IoC
{
    public class DependencyContainer
    {

        public static void RegisterServices(IServiceCollection services)
        {


            //Domain InMemory Bus MediateR
            services.AddScoped<IMediatorHandler, InMemoryBus>();

            //add Handler
            services.AddScoped<IRequestHandler<CreateCourseCommand, bool>, CourseCommandHandler>();

            //application layer
            services.AddScoped<ICourseService, CourseService>();

            //infra.data layer
            services.AddScoped<ICourseRepository, CourseRepository>();


            //infra data layerד
            services.AddScoped<UniversityDBContext>();
        }
    }
}
