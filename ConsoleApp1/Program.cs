// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

namespace Giraffe
{
  class Program
  {
    static void Main(string[] args)
    {
//--------------------------------------
      // CONSOLE.WRITELINE

      //   string name = "George";
      //   int age = 70; 
      // Console.WriteLine("There once was a man named " + name);
      // Console.WriteLine("He was " + age + " yrs old");
      // name = "Mike";
      // Console.WriteLine("He really liked the name " + name);
      // Console.WriteLine("But didn't like being " + age);


//--------------------------------------
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


//--------------------------------------
      // SOME METHODS

      // Console.WriteLine("character " + character);
      // Console.WriteLine("ToUpper: " + word.ToUpper() + "\n" + "ToLower: " + word.ToLower() + "\n" + "Contains: " + word.Contains('x')  );
      // Console.WriteLine("word[0]: " + word[0]);
      // Console.WriteLine("word.IndexOf(\"t\") " + word.IndexOf("t"));
      

//--------------------------------------
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
      // Console.Write("Enter a number: ");
      // double decinum1 = Convert.ToDouble(Console.ReadLine());
      // Console.Write("Enter another decinumber: ");
      // double decinum2 = Convert.ToDouble(Console.ReadLine());
      // Console.WriteLine( decinum1 + decinum2);

      // Console.ReadLine();


//--------------------------------------
      // MAD LIBS GAME
      // string color, pluralNoun, celebrity; // a way to declare multiple variables

      // Console.Write("Enter a color: ");
      // color = Console.ReadLine();

      // Console.Write("Enter a plural noun");
      // pluralNoun = Console.ReadLine();

      // Console.Write("Enter a celebrity");
      // celebrity = Console.ReadLine();


      // Console.WriteLine("Roses r " + color);
      // Console.WriteLine(pluralNoun + " are blue");
      // Console.WriteLine("i love " + celebrity);
    
    
      // Console.ReadLine();


//--------------------------------------
      // COMPLEX DATA TYPES

      // ARRAYS

    // int[] luckyNumbers = { 2, 4, 6, 8, 10, 12}; // array

    // Console.WriteLine( luckyNumbers[4]);
    // Console.ReadLine();
    // luckyNumbers[1] = 3999;
    // Console.WriteLine(luckyNumbers[1]);
    // Console.ReadLine();
    // string[] friends = new string[5]; // determines length of the array
    // friends[0] = "Ben"; // assigning strings to different indexes
    // friends[1] = "Mike";
    // friends[2] = "Brandon";



    //_-----------------------------
    // Creating new methods 
    SayHi("Barry"); // We call the method from inside of the Main Method
    }
    // Notice we are outside of "Main"
    //   void means the method returns nothing
    // static *return types* *method name*(*parameters*) { your code}
    static void SayHi(string name)
    {
      Console.WriteLine("Hello User");
      Console.WriteLine("Your name is " + name);
    }

  }
}