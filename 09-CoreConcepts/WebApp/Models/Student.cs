namespace WebApp.Models
{

    public partial class Student : IEntity
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public string Email { get; set; }

        // navigational prop
        public int CourseId { get; set; }
    }
}