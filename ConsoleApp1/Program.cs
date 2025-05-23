﻿// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");

using System.Diagnostics.CodeAnalysis;

namespace Giraffe
{
  class Program
  {
    static void Main(string[] args)
    {

      // CLASSES ---------------------------------------
      Book book1 = new Book(); // This is an instance of the book.
      // The class is the definition of what a book is
      // the line above us is creating a book object using the
      // book class definition.
      book1.title = "Harry Potter"; // as you can see we access the objects
      //properties in the same manner as we did in javascript;
      book1.author = "JK Rowling";
      book1.pages = 400;
      Console.WriteLine(book1.title);
      Console.ReadLine();
      Book book2 = new Book(); // This is an instance of the book.
      // The class is the definition of what a book is
      // the line above us is creating a book object using the
      // book class definition.
      book1.title = "Lord Of The Rings"; // as you can see we access the objects
      //properties in the same manner as we did in javascript;
      book1.author = "Tolkein";
      book1.pages = 500;
      Console.WriteLine(book1.title);
      Console.ReadLine();
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
    // METHODS
    // Methods are called inside of the Main
    // SayHi("Barry", 33); // We call the method from inside of the Main Method
    // SayHi("Mike", 28);
    // SayHi("Ben", 27);

    // Console.WriteLine(CubeMethod(3));
    // Console.WriteLine(CubeMethod(2));
    // Console.ReadLine();
    // IfStatements(true);
    // IfStatements(false);
    // Console.WriteLine(GetMaxOf3(3, 4, 5));
    // Console.WriteLine(GetMax(34, 66));
    // ComplexCalculator();
    // Console.WriteLine(GetDay(4));
    // WhileLoops();
    //  ForLoops();
    //   Console.WriteLine(Exponents(5, 1));
    // Exceptions();
//      Console.WriteLine(XorSwap());
    }
    // Notice we are outside of "Main"
    //   void means the method returns nothing
    // static *return types* *method name*(*parameters*) { your code}
    static void SayHi(string name, int age)
    {
      Console.WriteLine("Hello User");
      Console.WriteLine("Your name is " + name);
      Console.WriteLine(name + "'s age is " + age );
    }
    
    // METHOD WITH RETURN VALUE (INT);
    static int CubeMethod(int number){
      int cubed = number * number * number;
     return cubed;
    }

    static void IfStatements(bool isMale) {
      bool isTall = true;

      if (!isTall){
        Console.WriteLine("they are not tall");
      } else if (isTall){
        Console.WriteLine("they are tall");
      } else if (isMale){
        Console.WriteLine("they Male");
      } else if (!isMale){
        Console.WriteLine("they rnt male");
      } else if(isMale || isTall) {
        Console.WriteLine("they are male or they are tall");
      } else {
        Console.WriteLine("they are not male AND not tall");
      }

    }


    static int GetMax(int num1, int num2 ){
      int result;
      if(num1 > num2){
        result = num1;
      } else {
        result = num2;
      }
      return result;
    }
  static int GetMaxOf3(int num1, int num2, int num3){
    int result;
    if(num1 >= num2 && num1 >= num3){
      result = num1;
    } else if(num2 >= num1 && num2 >= num3){
    result = num2;
    } else {
      result = num3;
    }
    return result;
  }
  
  static void ComplexCalculator(){
    Console.Write("Enter A number: ");
    double num1 = Convert.ToDouble(Console.ReadLine());
    Console.Write("Enter an Operator: ");
    string op = Console.ReadLine();

    Console.Write("Enter A number again: ");
    double num2 = Convert.ToDouble(Console.ReadLine());

    if(op == "+"){
      Console.Write(num1 + num2);
    } else if(op == "-"){
      Console.Write(num1 - num2);
    }else if(op == "/"){
      Console.Write(num1 / num2);
    }else if(op == "*"){
      Console.Write(num1 * num2);
    }
  }

    static string GetDay(int dayNum){
      // this method will take a number and convert it to a day of the week
     string dayName;

     switch(dayNum)
     {
      case 0:
        dayName = "Sunday";
        break;
      case 1:
        dayName = "Monday";
        break;
      case 2:
        dayName = "Tuesday";
        break;
      case 3:
        dayName = "Wednesday";
        break;
      case 4:
        dayName = "Thursday";
        break;
      case 5:
        dayName = "Friday";
        break;
      case 6:
        dayName = "Saturday";
        break;
     default:
        dayName = "Invalid day number entered";
        break;
     }
     return dayName;
    }

    static void WhileLoops(){
      int index = 1;

      while(index <= 5)
      {
        Console.WriteLine(index);
        index++;
      }
      Console.ReadLine();
    }

    static void ForLoops(){
      int[] luckyNumbers = {2, 5, 6, 34, 420, 69 };
      for(int i = 1; i < luckyNumbers.Length; i++){
        Console.WriteLine(luckyNumbers[i]);
      }
    }

    static int Exponents(int firstNumber, int powNum){
    Console.WriteLine("exponent called");
      // int result = firstNumber ^powNum; // carrots do NOT do exponents. they do bitwise XOR
      // return result;
      int result = 1;
      for(int i = 1; i <= powNum; i++){ result = result * firstNumber;
      }
      return result;
    }

    static void TwoDimensionalArray(){

      // this [,] means an array of arrays
      // [,] is 2 dimensional
      // [,,] is 3 dimensional, and so on
      // you can also name the amount in each dimension like this:
      int [,] multiArray = new int[2, 3];

      int [,] numberGrid = {
        {1, 2},
        {3, 4},
        {5, 6},
      };
      Console.WriteLine(numberGrid[0, 0]);
      // Notice it isnt [0][0] for the first element in the first array;
      // it is actually {0, 0}
      Console.ReadLine();
    }

    static void Exceptions(){
      try{

      Console.Write("enter a num: ");
      int num1 = Convert.ToInt32(Console.ReadLine());
      Console.Write("enter a num: ");
      int num2 = Convert.ToInt32(Console.ReadLine());
      double result = num1 / num2;
      Console.WriteLine(num1 / num2);
      }
      catch(DivideByZeroException e){
      Console.WriteLine("Cannot divide by Zero");
      Console.WriteLine(e.Message);
      }
      catch(FormatException e){
      Console.WriteLine("Format Error, Numbers only");
      Console.WriteLine(e.Message);
      }
      finally
      {
        Console.WriteLine("If everything goes right, or if everything goes wrong");
        Console.WriteLine("Finally will always be there");
      }

    }

      static string XorSwap(){
        Console.WriteLine("enter your first number: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("enter your second number: ");
        int b = Convert.ToInt32(Console.ReadLine());
        a = a ^ b; // a now holds a ^ b
        b = a ^ b; // b is now a because (a ^ b) ^ b = a
        a = a ^ b; // a is now b because (a ^ b) ^ a = b
        return $"a = {a}, b = {b}";
      }

      static string XorSwapArray(int[] arr){

        for (int i = 0; i < arr.Length / 2; i++)
        {
            int j = arr.Length - 1 - i;

            // XOR swap without temp variable
            arr[i] = arr[i] ^ arr[j];
            arr[j] = arr[i] ^ arr[j];
            arr[i] = arr[i] ^ arr[j];
        }
        return string.Join(", ", arr);
      }
  }

}





















