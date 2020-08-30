using AutoMapper;
using CleanArch.Application.AutoMapper;
using Microsoft.Extensions.DependencyInjection;

namespace CleanArch.Api.Configuration
{
    public static class AutoMapperConfig
    {
        public static void RegisterAutoMapper(this IServiceCollection services)
        {
            services.AddAutoMapper(typeof(CleanArch.Application.AutoMapper.AutoMapperConfiguration));
            AutoMapperConfiguration.RegisterMapping();
        }
    }
}
