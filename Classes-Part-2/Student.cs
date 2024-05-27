using System;
namespace Classes_Part_2
{
	public class Student
	{
        private static int nextStudentId = 1;
        public string Name { get; set; }
        public int StudentId { get; set; }
        public int NumberOfCredits { get; set; }
        public double Gpa { get; set; }

        public Student(string name, int studentId,
            int numberOfCredits, double gpa)
        {
            Name = name;
            StudentId = studentId;
            NumberOfCredits = numberOfCredits;
            Gpa = gpa;
        }

        public Student(string name, int studentId)
        : this(name, studentId, 0, 0) { }

        public Student(string name)
        : this(name, nextStudentId)
        {
            nextStudentId++;
        }

        // TODO: Complete the AddGrade method.
        public void AddGrade(int courseCredits, double grade)
        {
            double newGrade = Gpa * NumberOfCredits;
            newGrade += courseCredits * grade;
            NumberOfCredits += courseCredits;
            Gpa = newGrade / NumberOfCredits;
            // Update the appropriate properties: NumberOfCredits, Gpa
        }

        public string GetGradeLevel(int credits)
        {
            if (credits >= 0 && credits <= 29)
            {
                return "Freshman";
            } 
            else if (credits >= 30 && credits <= 59){
                return"Sophomore";
            }
            else if (credits >= 60 && credits <= 89) 
            {
                return "Junior";
            }
            else
            {
                return "Senior";
            }
        }

        // TODO: Add your custom 'ToString' method here. Make sure it returns a well-formatted string rather
        //  than just the class fields.
        public override string ToString()
        {
            return Name + " (Credits: " + NumberOfCredits + ", GPA:" + Gpa + ")"; 
        }

        // TODO: Add your custom 'Equals' method here. Consider which fields should match in order to call two
        //  Student objects equal.
        public override bool Equals(object obj)
        {
            if (obj == this)
            {
                return true;
            }

            if (obj == null)
            {
                return false;
            }

            if (obj.GetType() != GetType())
            {
                return false;
            }
            Student studentObj = obj as Student;
            return StudentId == studentObj.StudentId;
        }
    }
}

