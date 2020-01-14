using MvcBasics.Models;
using System;
using System.Collections.Generic;

public class SchoolClass
{
    public string className { get; set; }
    public int numberLessons { get; set; }

    public List<Student> listOfStudents { get; set; }

}