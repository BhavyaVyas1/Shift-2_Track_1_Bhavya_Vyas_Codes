using System;
namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Class1 obj=new Class1();   
            System.Console.WriteLine("Hello user");
            Console.Write("Enter Your Name:");
            obj.Name = Console.ReadLine();

            //string name = Console.ReadLine();

            Console.WriteLine();

            Console.Write("Enter Your Age:");
            obj.Age = int.Parse( Console.ReadLine() );

           // int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Hi {0}, You are {1} Years old", obj.Name, obj.Age);
        }
    }
}