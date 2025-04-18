// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

namespace Giraffe
{
  class Program
  {
    static void Main(string[] args)
    {

        string name = "George";
        int age = 70; 
      Console.WriteLine("There once was a man named " + name);
      Console.WriteLine("He was " + age + " yrs old");
      name = "Mike";
      Console.WriteLine("He really liked the name " + name);
      Console.WriteLine("But didn't like being " + age);

      string word =  "a string";
      char character = 'e';
      int number = 50;
      float leastAccurate = 30.5F;
      double middleAccurate = 40.53;
      decimal mostAccurate = 40.65M;
      bool truth = true;
      bool falsy = false;
      Console.WriteLine("string " + word);
      Console.WriteLine("int " + number);
      Console.WriteLine("bool " + truth);
      Console.WriteLine("bool " + falsy);
      Console.WriteLine("decimal + ends with M " + mostAccurate);
      Console.WriteLine("double " + middleAccurate);
      Console.WriteLine("float ends with F " + leastAccurate);
      Console.WriteLine("character " + character);
      
      Console.ReadLine();
    }
  }
}