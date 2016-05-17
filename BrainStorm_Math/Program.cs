using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using Utilities;

namespace BrainStorm
{
    enum Operations
    {
        Add,
        Minus,
        Multiply, 
        Divide
    } 
    class Program
    {
        public static bool somebool;
        public static void Main(string[] args)
        {

            /*Array from..to*/
            int[] numbers = Enumerable.Range(3,15).ToArray();
            /*Printing Original Array*/
            Console.WriteLine("Original Array of numbers");
            numbers.ArrayToString().Write();

            /*Chose one ramdom number from existing array*/
           // Console.WriteLine($"second number from Array, {numbers[2]}");
            Console.WriteLine();

            /*Random number from Array*/
            int FirstElem = numbers[new Random().Next(0, numbers.Length)];
            Thread.Sleep(100); //pause between randomize
            int SecondElem = numbers[new Random().Next(0, numbers.Length)];
            // some
            int Summ = FirstElem + SecondElem;



            
            Console.WriteLine(FirstElem.ToString() + "+" + SecondElem.ToString() + "=" + Summ);
            string res = Console.ReadLine();
            int resC;
            bool resL = Int32.TryParse(res, out resC);

            if (resL)
            {
                if (resC == Summ)
                {
                    Console.WriteLine("Correct");
                }
                else
                {
                    Console.WriteLine("Incorrect answer");
                }
                
            }
            else
            {
                Console.WriteLine("Your input " + res + " is incorrect. Try again");
            }


            Console.WriteLine("Correct solution is " + FirstElem.ToString() + "+" + SecondElem.ToString() + "=" + Summ);
            Console.WriteLine();
  
            Console.WriteLine("I done");
            Console.ReadKey();
            }
    }
}
