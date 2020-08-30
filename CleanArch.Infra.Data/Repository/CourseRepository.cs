using CleanArch.Domain.Entities;
using CleanArch.Domain.Interfaces;
using CleanArch.Infra.Data.Context;
using System.Linq;

namespace CleanArch.Infra.Data.Repository
{
    public class CourseRepository : ICourseRepository
    {
        private UniversityDBContext _ctx;

        public CourseRepository(UniversityDBContext ctx)
        {
            _ctx = ctx;
        }

        public void Add(Course course)
        {
            _ctx.Courses.Add(course);
            _ctx.SaveChanges();
        }

        public IQueryable<Course> GetCorses()
        {
            return _ctx.Courses;
        }
    }
}
