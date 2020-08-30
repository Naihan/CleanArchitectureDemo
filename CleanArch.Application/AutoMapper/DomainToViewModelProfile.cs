using AutoMapper;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Entities;

namespace CleanArch.Application.AutoMapper
{
    public class DomainToViewModelProfile : Profile
    {
        public DomainToViewModelProfile()
        {
            CreateMap<Course, CourseViewModel>();

        }
    }
}
