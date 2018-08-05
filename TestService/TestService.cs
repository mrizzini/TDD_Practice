using System;

namespace Test.Services
{
    public class TestService
    {
        public int GetFibonacci(int input)
        {
            if (input == 0)
                return 0;
            if (input == 1)
                return 1;

            return GetFibonacci(input - 1) + GetFibonacci(input - 2);
        }


        public string FizzBuzz(int input)
        {
            string fizzer = "";
            // if (input % 3 == 0 && input % 5 == 0)
            //     return "FizzBuzz";
            if (input % 3 == 0)
                fizzer += "Fizz";
            if (input % 5 == 0)
                fizzer += "Buzz";

            return fizzer;
        }


    }
}
