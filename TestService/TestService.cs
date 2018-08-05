using System;
using System.Collections.Generic;

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

        public int RomanNumeral(string roman)
        {
            // var numbers = new List<int>{ 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            // var romanNumeral = new List<string>{ "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };
            // var final = "";

            // for (var i = 0; i < numbers.Count; i++)
            // {
            //     while 
            // }
            Dictionary<char, int> map = new Dictionary<char, int>()
            {
                {'I', 1 },
                {'V', 5 },
                {'X', 10 },
                {'L', 50 },
                {'C', 100 },
                {'D', 500 },
                {',', 1000 }
            };

            int result = 0;

            for (var i = 0; i < roman.Length; i++)
            {
                if (i + 1 < roman.Length && map[roman[i]] < map[roman[i + 1]])
                {
                    result -= map[roman[i]];
                }
                else
                {
                    result += map[roman[i]];
                }
            }


            return result;
        }
    }
}


  
//   for (var i = 0; i < numbers.length; i++) {
//     while (numbers[i] <= num) {
//       final += romanNumeral[i];
//       num = num - numbers[i];
//     }
//   }
  
//  return final;
