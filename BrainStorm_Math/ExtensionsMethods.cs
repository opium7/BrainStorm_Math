using System;
using System.Runtime.InteropServices;

namespace Utilities
{
    public static class ExtensionsMethods
    {
        public static string ArrayToString<T>(this T[] A)
        {
            string result = "{ ";
            for (int i = 0; i < A.Length; i++)
            {
                result += $"{A[i].ToString()}, ";

            }
            result += "}";
            return result;
        }

        //Write method
        public static void Write(this string write)
        {
            Console.WriteLine(write);
        }

        //Shuffled Array with the same values
        public static T[] ShffleArraySv<T>(this T[] A)
        {
            int randfromArray = 0;
            Random random = new Random();
            T[] result = new T[A.Length];
            //bool[] ordered = new bool[A.Length];

            for (int i = 0; i < result.Length; i++)
            {
                //do
                //{
                    randfromArray = random.Next(A.Length);
                //} while (ordered[randfromArray]);
                //ordered[randfromArray] = true;
                result[i] = A[randfromArray];
            }
            return result;
        }

        //Shuffled Array with constant numbers
        public static T[] ShffleArrayCn<T>(this T[] A)
        {
            int randfromArray = 0;
            Random random = new Random();
            int constnum = 50;
            T[] result = new T[constnum];
            
            //bool[] ordered = new bool[A.Length];

            for (int i = 0; i < constnum; i++)
            {
                //do
                //{
                randfromArray = random.Next(A.Length);
                //} while (ordered[randfromArray]);
                //ordered[randfromArray] = true;
                result[i] = A[randfromArray];
            }
            return result;
        }

        //Shuffled Array with constant numbers
        // {0,1,2,3,4,5}
        //ordered  new bool [6]
        // 6
        public static T[] ShffleArrayCnr<T>(this T[] A )
        {
            return ShffleArrayCnr(A,false);
        }

        public static T[] ShffleArrayCnr<T>(this T[] A, bool isRandom)
        {
            return ShffleArrayCnr(A, isRandom, A.Length);
        }
        public static T[] ShffleArrayCnr<T>(this T[] A, int length)
        {
            return ShffleArrayCnr(A, false, length);
        }


        public static T[] ShffleArrayCnr<T>(this T[] A,bool isRandom,int constnum)
        {
            int randfromArray = 0;
            Random random = new Random();
            T[] result = new T[constnum];

            bool[] ordered = new bool[A.Length];


            //for (int i = 0; i < result.Length; i++)
            for (int i = 0; i < constnum; i++)
            {
                    do
                    {
                        randfromArray = random.Next(A.Length);
                    } while (ordered[randfromArray]);
                    ordered[randfromArray] = true;
                result[i] = A[randfromArray];
                
            }
            return result;
        }

        //Shuffled Array with all different values
        public static T[] ShffleArray<T>(this T[] A)
        {
            int randfromArray = 0;
            Random random = new Random();
            T[] result = new T[A.Length];
            bool[] ordered = new bool[A.Length];

            for (int i = 0; i < result.Length; i++)
            {
                do
                {
                    randfromArray = random.Next(A.Length);
                } while (ordered[randfromArray]);
                ordered[randfromArray] = true;
                result[i] = A[randfromArray];
            }
            return result;
        }

        public static void YurasString(this string s)
        {
            Console.WriteLine(s + " Yuras String");
        }
    }
}