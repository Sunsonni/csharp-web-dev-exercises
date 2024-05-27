//Exercises: Control Flow & Collections

//TODO: Write your code for Dictionary Practice below:
Dictionary<string, double> students = new Dictionary<string, double>();
string newStudent;

Console.WriteLine("Enter your students (or ENTER to finish)");

do
{
    Console.WriteLine("Student: ");
    string input = Console.ReadLine()!;
    newStudent = input;
    if (!Equals(newStudent, "")) {
        Console.WriteLine("ID: ");
        input = Console.ReadLine()!;
        double ID = double.Parse(input);
        students.Add(newStudent, ID);

        Console.ReadLine();
    }    
} while (!Equals(newStudent, ""));

Console.WriteLine("\nClass Roster:");
foreach (KeyValuePair<string, double> student in students) 
{
    Console.WriteLine(student.Key + "\t" + "ID: " + student.Value + "\n");
}


