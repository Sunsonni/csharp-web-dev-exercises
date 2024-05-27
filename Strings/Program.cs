//Exercises: Control Flow & Collections

//TODO: Write your code for String Practice below:

string excerpt = @"I would not, could not, in a box. I would not, could not with a fox.
I will not eat them in a house. I will not eat them with a mouse.";

string[] splitExcerpt = excerpt.Split(" ");

Console.WriteLine(string.Join(", ", splitExcerpt));
Console.WriteLine(string.Join("\n", splitExcerpt));