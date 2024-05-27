//Exercises: Control Flow & Collections
using System;
using System.ComponentModel;

//TODO: Write your code for List Practice below:

List<int> allNumbers = new List<int>
{
    30,
    1,
    22,
    30,
    25,
    5,
    9,
    1,
    33,
    5
};
List<string> strings= new List<string>
{
    "apples",
    "add",
    "jungle",
    "conversation",
    "have",
    "nice",
    "dictonary",
    "summary",
};
// Console.WriteLine(Sum(allNumbers));
int wordLength;
string firstInput; 
do
{
    Console.WriteLine("Enter a number for word length.");
    firstInput = Console.ReadLine()!; 
    if (Int32.TryParse(firstInput, out wordLength)){
        wordLength = Int32.Parse(firstInput);
    }
    
} while (!Int32.TryParse(firstInput, out wordLength));

printLongWords(strings, wordLength);

static int Sum(List<int> nums) {
    int sum = 0;
    foreach(int i in nums) {
        if (i % 2 == 0){
            sum += i;
        }
    }
    return sum;
}

static void printLongWords(List<string> words, int wordLength) {
    foreach(string word in words) {
        if(word.Length >= wordLength){
            Console.WriteLine(word);
        }
    }  
}

