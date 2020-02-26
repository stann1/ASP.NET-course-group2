using WebApp.Models;

namespace WebApp.Data.Repositories
{

    public class StudentRepository : BaseRepository<Student, ApplicationDbContext>
    {
        public StudentRepository(ApplicationDbContext context) : base(context)
        {
        }
    }
}