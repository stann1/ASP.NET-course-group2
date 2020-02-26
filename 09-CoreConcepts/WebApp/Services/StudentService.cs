using WebApp.Data.Repositories;
using WebApp.Models;

namespace WebApp.Services
{
    class StudentService : IDomainService
    {
        private readonly StudentRepository studentRepository;
        private readonly CourseRepository courseRepository;

        public StudentService(StudentRepository repository, CourseRepository courseRepository)
        {
            this.studentRepository = repository;
            this.courseRepository = courseRepository;
        }
        
        public void SaveAndLog(Student student)
        {
            // find student 

            // find related courses

            // modify ...

            // save student and course

            // save to log
        }
    }
}