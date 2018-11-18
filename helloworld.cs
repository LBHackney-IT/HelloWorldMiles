using System;

namespace HelloWorldApplication { // namespaces control the scope of the project and are used to organize and separate many lines of code. they are like containers which hold other namespaces and classes
   class HelloWorld { // A Class is a blueprint for an object, it defines the kinds of data and functionality an object will have.
      static void Main(string[] args) { //The Main method is the entry point of a c# program and is the first method that is invoked
            string message = "Hello World";  
            Console.WriteLine(message); // This is a class method, these contain a series of statements which are to be executed by the program calling the method
            Console.ReadLine();
     
      }
   }
}