// think of this as your main.js 

// using System;

// namespace Intro
// {
//     class Program
//     {
//         static void Main(string[] args)
//         {
//             Console.WriteLine("Hello World!");
//         }
//     }
// }

// this is the much shorter version of the above code 
// System.Console.WriteLine("Hello World!");

// the below code  allows you to write a name & says hello to whomever you entered! fun!! 
// System.Console.Write("Who would you like to say hello to? ");

// string name = System.Console.ReadLine();

// if (string.IsNullOrWhiteSpace(name))
// {
//     System.Console.WriteLine("Fine, don't say 'hello'!");
// }
// else
// {
//     System.Console.WriteLine($"Hello, {name}!");
// }

using System;

Console.Write("Who would you like to say hello to? ");

string name = Console.ReadLine();

if (string.IsNullOrWhiteSpace(name))
{
    Console.WriteLine("Fine, don't say 'hello'!");
}
else
{
    Console.WriteLine($"Hello, {name}!");
}