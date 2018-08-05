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

       public int StringCalculator(string str)
        {
            if (String.IsNullOrEmpty(str))
                return 0;
            
            if (str.Contains("-"))
                throw new System.ArgumentException("Negative number");

            if(str.Contains(",") || str.Contains("\r\n"))
            {
                var sum =0;
                char[] delimiters = new char[] { '\r', '\n', ',' };
                String [] intString = str.Split(delimiters,StringSplitOptions.RemoveEmptyEntries);
                foreach(var n in intString)
                {
                    var inputNum = Int32.Parse(n);
                    if(inputNum<1000)
                        sum+=inputNum;
                }
                return sum;
            }

            // if(str.Contains(","))
            // {
            //     String[] substrings = str.Split(',');
            //     return Int32.Parse(substrings[0]) + Int32.Parse(substrings[1]);
            // }

            // if (str.Contains("\r\n"))
            // {
            //     String[] newLineSubStrings = str.Split('\n');
            //     return Int32.Parse(newLineSubStrings[0]) + Int32.Parse(newLineSubStrings[1]);
            // }

            return Int32.Parse(str);

        }


    }
}
