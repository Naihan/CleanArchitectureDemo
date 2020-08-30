using AutoMapper;
using AutoMapper.QueryableExtensions;
using CleanArch.Application.Interfaces;
using CleanArch.Application.ViewModels;
using CleanArch.Domain.Commands;
using CleanArch.Domain.Core.Bus;
using CleanArch.Domain.Interfaces;
using System.Collections.Generic;

namespace CleanArch.Application.Services
{
    public class CourseService : ICourseService
    {

        private readonly ICourseRepository _courseRepository;
        private readonly IMediatorHandler _bus;
        private readonly IMapper _autoMapper;

        public CourseService(ICourseRepository courseRepository, IMediatorHandler bus, IMapper mapper)
        {
            _courseRepository = courseRepository;
            _bus = bus;
            _autoMapper = mapper;
        }

        public void Create(CourseViewModel courseViewModel)
        {
            //var createCourseCommand = new CreateCourseCommand(courseViewModel.Name,
            //    courseViewModel.Descriptions,
            //    courseViewModel.ImageUrl);

            _bus.SendCommand<CreateCourseCommand>(_autoMapper.Map<CreateCourseCommand>(courseViewModel));

        }

        public IEnumerable<CourseViewModel> GetCourses()
        {
            return _courseRepository.GetCorses().
                ProjectTo<CourseViewModel>(_autoMapper.ConfigurationProvider);
        }
    }
}
