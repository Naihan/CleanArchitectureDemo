using CleanArch.Domain.Commands;
using CleanArch.Domain.Entities;
using CleanArch.Domain.Interfaces;
using MediatR;
using System.Threading;
using System.Threading.Tasks;

namespace CleanArch.Domain.CommandHandlers
{
    public class CourseCommandHandler : IRequestHandler<CreateCourseCommand, bool>
    {
        private readonly ICourseRepository _courseRepository;

        public CourseCommandHandler(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }


        public Task<bool> Handle(CreateCourseCommand request, CancellationToken cancellationToken)
        {
            var course = new Course()
            {
                Name = request.Name,
                Descriptions = request.Description,
                ImageUrl = request.ImageUrl
            };

            _courseRepository.Add(course);


            return Task.FromResult(true);
        }
    }
}
