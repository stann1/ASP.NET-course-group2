

class Student {

    public string FirstName { get; private set; }
    public string LastName { get; private set; }
    public int Age { get; private set; }

    public string FullName
    {
        get
        {
            return this.FirstName + " " + this.LastName;
        }
    }

    public Student(string firstName, string lastName, int age)
    {
        this.FirstName = firstName;
        this.LastName = lastName;
        this.Age = age;
    }

    public string GetFullName()
    {
        return $"{this.FirstName} {this.LastName}";
    }
}