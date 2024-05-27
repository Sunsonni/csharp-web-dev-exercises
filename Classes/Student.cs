using System;

namespace Classes{

public class Student
{
    private static int nextStudentId = 1;
    private string Name { get; set; }
    private int StudentId { get; set;}
    private int NumberOfCredits { get; set; } = 0;
    private double Gpa { get; set; } = 0.0;

    public Student(string name, int studentId, int numberOfCredits,
    double gpa)
    {
        Name = name;
        StudentId = studentId;
        NumberOfCredits = numberOfCredits;
        Gpa = gpa;
    }

    public Student(string name, int StudentId): this(name, StudentId, 0, 0) { }

    public Student(string name): this(name, nextStudentId)
    {
        nextStudentId++;
    }
}

public class Course 
{
    private string topic;
    private Teacher instructor;
    private List<Student> enrolledStudents;
}

public class Teacher
{
    private string FirstName;
    private string LastName;
    private string Subject;
    private string YearsTeaching;
}

}