using WebApp.Models;

namespace WebApp.Data.Repositories
{

    public class CourseRepository : BaseRepository<Course, ApplicationDbContext>
    {
        public CourseRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}