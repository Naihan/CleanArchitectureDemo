using CleanArch.Domain.Entities;
using System.Linq;

namespace CleanArch.Domain.Interfaces
{
    public interface ICourseRepository
    {
        IQueryable<Course> GetCorses();
        void Add(Course course);
    }
}
