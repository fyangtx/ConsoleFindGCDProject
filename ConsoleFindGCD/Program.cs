using System;

namespace ConsoleFindGCD
{
    // C# program to find GCD of 
    // two or more numbers 

    static public class GCD
    {

        // Function to return gcd of a and b 
        public static int gcd(int a, int b)
        {
            if (a == 0)
                return b;
    
            return gcd(b % a, a);
        }

        public static int GcdNonRecursive(int a, int b)
        {
            int r = 0;
            while (true)
            {
                if (a > b)
                {
                    Swap(ref a, ref b);
                }

                if (a == 0)
                { 
                    return b;
                }

                r = b % a;
                b = r;
            }

        }

        private static void Swap(ref int a, ref int b)
        {
            int t = b;
            b = a;
            a = t;
        }

        // Function to find gcd of 
        // array of numbers 
        public static int FindGcd(int[] arr)
        {
            int result = arr[0];
            for (int i = 1; i < arr.Length; i++)
                result = gcd(arr[i], result);

            return result;
        }
        public static int FindGcdNonRecursive(int[] arr)
        {
            int result = arr[0];
            for (int i = 1; i < arr.Length; i++)
                result = GcdNonRecursive(arr[i], result);

            return result;
        }

        // Driver Code 
        public static void Main()
        {
            int[] arr = { 48, 96, 16};
            Console.WriteLine(FindGcd(arr));
            Console.WriteLine(FindGcdNonRecursive(arr));
        }
    }
}