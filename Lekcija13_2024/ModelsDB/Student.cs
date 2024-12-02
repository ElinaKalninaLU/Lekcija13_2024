using System;
using System.Collections.Generic;

namespace Lekcija13_2024.ModelsDB;

public partial class Student
{
    public int StudentId { get; set; }

    public string? Name { get; set; }

    public string? Surname { get; set; }

    public virtual ICollection<StudentCourse> StudentCourses { get; set; } = new List<StudentCourse>();
}
