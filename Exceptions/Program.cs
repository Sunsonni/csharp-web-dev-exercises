// --------- Divide By Zero! ----------


static double Divide(double x, double y)
{
    if (y == 0.0)
    {
        throw new ArgumentException("Not possible to divide by zero");
    }
    else
    {
        return x / y;
    }
}


// Test out your Divide() function here!
Console.WriteLine(Divide(10, 2));

// --------- Test Student Labs ----------


static int CheckFileExtension(string fileName)
{
   int score = 0;
   if(fileName == null || fileName == "")
   {
        throw new ArgumentException("You have to actually turn in a file!");
   }
   else if(fileName.Contains(".cs"))
   {
        score++;
   } 
   return score;
}


// Test out your CheckFileExtension() function here!

Dictionary<string, string> students = new Dictionary<string, string>();
students.Add("Carl", "Program.cs");
students.Add("Brad", "");
students.Add("Elizabeth", "MyCode.cs");

foreach (KeyValuePair<string, string> student in students)
{
    CheckFileExtension(student.Value);
}



