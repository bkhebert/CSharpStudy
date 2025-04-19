// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

namespace Giraffe
{
  class Program
  {
    static void Main(string[] args)
    {

      // CONSOLE.WRITELINE

      //   string name = "George";
      //   int age = 70; 
      // Console.WriteLine("There once was a man named " + name);
      // Console.WriteLine("He was " + age + " yrs old");
      // name = "Mike";
      // Console.WriteLine("He really liked the name " + name);
      // Console.WriteLine("But didn't like being " + age);

      // SIMPLE DATATYPES

      // string word =  "a string";
      // char character = 'e';
      // int number = 50;
      // float leastAccurate = 30.5F;
      // double middleAccurate = 40.53;
      // decimal mostAccurate = 40.65M;
      // bool truth = true;
      // bool falsy = false;
      // Console.WriteLine("string " + word);
      // Console.WriteLine("int " + number);
      // Console.WriteLine("bool " + truth);
      // Console.WriteLine("bool " + falsy);
      // Console.WriteLine("decimal + ends with M " + mostAccurate);
      // Console.WriteLine("double " + middleAccurate);
      // Console.WriteLine("float ends with F " + leastAccurate);

      // SOME METHODS

      // Console.WriteLine("character " + character);
      // Console.WriteLine("ToUpper: " + word.ToUpper() + "\n" + "ToLower: " + word.ToLower() + "\n" + "Contains: " + word.Contains('x')  );
      // Console.WriteLine("word[0]: " + word[0]);
      // Console.WriteLine("word.IndexOf(\"t\") " + word.IndexOf("t"));
      
      // INPUT & OUTPUT
      
      // Console.Write("Enter your name: ");
      // string newName = Console.ReadLine();
      // Console.WriteLine("Hello " + newName);
      // Console.Write("Enter your age: ");
      // string newAge = Console.ReadLine();
      //  Console.Write("ur age is " + newAge);
      // Console.ReadLine();

      // ToInt32 converts a string into an integer.
      // int num = Convert.ToInt32("45");

      // Console.WriteLine(num + 6);
      // Console.ReadLine();

      // WHOLE NUMBER CALCULATOR
      // Console.Write("Enter a number: ");
      // int num1 = Convert.ToInt32(Console.ReadLine());
      // Console.Write("Enter another number: ");
      // int num2 = Convert.ToInt32(Console.ReadLine());
      // Console.WriteLine( num1 + num2);

      // Console.ReadLine();

      // DECIMAL NUMBER CALCULATOR
      Console.Write("Enter a number: ");
      double decinum1 = Convert.ToDouble(Console.ReadLine());
      Console.Write("Enter another decinumber: ");
      double decinum2 = Convert.ToDouble(Console.ReadLine());
      Console.WriteLine( decinum1 + decinum2);

      Console.ReadLine();

    }
  }
}