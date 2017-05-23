using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExercises
{
    public static class Exercises
    {
        // Example Exercise:
        // Create a method called HelloWorld that returns the following string - "Hello World!"
        /*public static string HelloWorld()
        {
            return "Hello World!";
        }

        public static string ReverseStringHard(string quote)
        {
            throw new NotImplementedException();
        }*/

        /* Alright - your turn now! */

        // 1. Create a method called SayHello that accepts a string representing a name and returns a welcome message (E.g. "Hello John!")

        public static string SayHello (string name)
        {
            return ($"Hello {name}!");
        }

        // 2. Create a method called Sum that accepts two integers and returns their sum.

        public static int Sum(int a, int b)
        {
            int addition = a + b;
            return addition;
        } 
        // 3. Create a method called Divide that accepts two decimals and returns the result of dividing the two numbers as a decimal.

        public static int Divide(int c, int d)
        {
            double divide = c / d;
            int x = (int)divide;
            return x;
        }
        // 4. Create a method called CanOpenCheckingAccount that accepts an integer representing a customers age, returning true if the age is greater than or equal to 18, or false if the argument is less than 18.
        
        public static bool CanOpenCheckingAccount (int e)
        {
            bool b = true;

            b = e >= 18;

            if (b)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        // 5. Create a method called GetFirstName that accepts a string representing a full name (e.g. "John Smith"), and returns only the first name.

        public static string GetFirstName (string f)
        {
            var wordsArray = f.Split();
            string firstName = wordsArray[0];
            return firstName;
        }

        // 6. Create a method called ReverseStringHard that accepts a string and returns the string in reverse. (No built in functions allowed)

        public static string ReverseStringHard (string g)
        {
            char[] chars = new char[g.Length];
            for (int i = 0, j = g.Length - 1; i <= j; i++, j--)
            {
                chars[i] = g[j];
                chars[j] = g[i];
            }
            return new string(chars);
        }

        // 7. Create a method called ReverseStringEasy that accepts a string and returns the string in reverse. (Using only built in functions)

        public static string ReverseStringEasy (string h)
        {
            char[] charArr = h.ToCharArray();
            Array.Reverse(charArr);
            return new string(charArr);
        }

        // 8. Create a method called PrintTimesTable that accepts an integer and returns the times table as a string for that number up to the 10th multiplication.
        /* e.g. 10 should return
         * 10 * 1 = 10
         * 10 * 2 = 20
         * 10 * 3 = 30
         * 10 * 4 = 40
         * 10 * 5 = 50
         * 10 * 6 = 60
         * 10 * 7 = 70
         * 10 * 8 = 80
         * 10 * 9 = 90
         * 10 * 10 = 10 */

        public static string PrintTimesTable (int j)
        {
            StringBuilder nums = new StringBuilder ();
            for (int i = 1; i <= 10; i++)
            {
                int table = i * j;
                nums.Append(j.ToString() + " * " + i.ToString() + " = " + table.ToString());
                if (i < 10)
                    nums.Append(Environment.NewLine);
            }
            return nums.ToString();
        }

        // 9. Create a method called ConvertKelvinToFahrenheit that accepts a double representing a temperature in kelvin and returns a double containing the temperature in Fahrenheit.

        public static double ConvertKelvinToFahrenheit(double k)
        {
            return Math.Round(k * 9.0 / 5.0 - 459.67, 2);
        }

        // 10. Create a method called GetAverageHard that accepts an array of integers and returns the average value as a double. (No built in functions allowed)

        public static double GetAverageHard (int[] args)
        {
            int result = 0;

            for (int i = 0; i < args.Length; i++)
            {
                result += args[i];
            }
            double ave = (double)result / args.Length;
            return ave;
        }

        // 11. Create a method called GetAverageEasy that accepts an array of integers and returns the average value as a double. (Using only built in functions)

        public static double GetAverageEasy (int []args)
        {
            return args.Average();
        }

        // 12. Create a method called DrawTriangle that accepts two integers - number and width and returns a string containing a drawn triangle using the number parameter.
        /* e.g. Number: 8, Width: 8 should return
         * 88888888
         * 8888888
         * 888888
         * 88888
         * 8888
         * 888
         * 88
         * 8 */

        public static string DrawTriangle (int num, int wid)
        {
            StringBuilder sb = new StringBuilder();
            char numberChar = num.ToString()[0];
            for (int index = wid; index > 0; index--)
            {
                for (int count = 0; count < index; count++)
                {
                    sb.Append(numberChar);
                }
                if (index > 1)
                    sb.Append(Environment.NewLine);
            }
            return sb.ToString();
        }

        // 13. Create a method called GetMilesPerHour that accepts a double representing distance and three integers representing hours, minutes and seconds. The method should return the speed in MPH rounded to the nearest whole number as a string. (e.g. "55MPH")

        public static string GetMilesPerHour (double dist, int hours, int mins, int secs)
        {
            double rate = (dist / ((hours * 3600) + (mins * 60) + secs)) * 3600.0;
            return Math.Round(rate).ToString() + "MPH";
        }

        // 14. Create a method called IsVowel that accepts a char parameter and returns true if the parameter is a vowel or false if the parameter is a consonant.

        public static bool IsVowel (char vowel)
        {
            bool isVowel = "aeiouAEIOU".IndexOf(vowel) >= 0;
            return isVowel;
        }

        // 15. Create a method called IsConsonant that accepts a char parameter and returns true if the parameter is a consonant or false if the parameter is a vowel.

        public static bool IsConsonant (char vowel)
        {
            bool isCons = "aeiouAEIOU".IndexOf(vowel) < 0;
            return isCons;
        }

        // 16. The Collatz conjecture, named after Lothar Collatz of Germany, proposed the following conjecture in 1937. 
        // Beginning with an integer n > 1, repeat the following until n == 1. If n is even, halve it. If n is odd, triple it and add 1. Following these steps, the function will always arrive at the number 1.
        // Create a method called CollatzConjecture that accepts an integer and returns the number of steps required to get to n == 1 as an integer.

        public static int CollatzConjecture(int n)
        {
            int iteration = 0;
            while (n > 1)
            {
                if (n % 2 == 0)
                    n /= 2;
                else
                    n = 3 * n + 1;
                iteration++;
            }
            return iteration;
        }

        // 16b. how many times world shows up in "Hello World"

        public static int GetOccurences (string put, string search)
        {
            int count = 0;
            int i = 0;

            while ((i = put.IndexOf(search, i)) != -1)
            {
                i += search.Length;
                count++;
            }

            return count;
        }
        // 17. Create a method called GetNext7Days that accepts a DateTime object and returns an array of DateTime objects containing the next 7 days (including the given day).

        public static DateTime[] GetNext7Days (DateTime dt)
        {
            DateTime[] dateArr = new DateTime[7];
            dateArr[0] = dt;
            for (int index = 1; index <= 6; index++)
            {
                dateArr[index] = dateArr[index - 1].AddDays(1);
            }
            return dateArr;
        }

        // 18. Create a method called IsInLeapYear that accepts a DateTime object and returns true if the date falls within a leap year and false if not. (No built in functions allowed)

        public static bool IsInLeapYear (int date)
        {
            if ((date % 4 == 0 && date % 100 != 0) || (date % 400 == 0))
            {
                return true;
            } else
            {
                return false;
            }
        }

        // 19. Create a method called MortgageCalculator that accepts 2 decimals representing loan balance and interest rate, an integer representing loan term in years, and an integer representing the payment period.
        /* Payment periods: 1 - Monthly, 2 - Bi-Monthly (Every 2 months) */

        public static double MortgageCalculator (double bal, double intrate, int term, int payper)
        {
            double monthlyInterestRate = ( intrate / 100) / payper;
            // number of payments
            int numberOfPayments = term * payper;
            // compounded interest rate
            double compoundedInterestRate = Math.Pow((1 + (double) monthlyInterestRate), numberOfPayments);
            // interest quotient
            double interestQuotient = (monthlyInterestRate * compoundedInterestRate) / (compoundedInterestRate - 1);
            // final calculation
            double monthlyPayment = bal * interestQuotient;
            //pull monthly payment variable and assign to text output variable, then bind to output p in html
            return Math.Round(monthlyPayment, 2);
        }

        // 20. Create a method called DuckGoose that accepts an integer. Iterate from 1 to this integer, building a string along the way.
        // If the current number in the iteration:
        //   Is divisible by 3, append "Duck" + Environment.NewLine; to the string.
        //   Is divisible by 5, append "Goose" + Environment.NewLine; to the string.
        //   Is divisible by both 3 and 5, append "DuckGoose" + Environment.NewLine; to the string.
        //   Is none of the above, append the number as a string + Environment.NewLine; to the string.

        public static string DuckGoose(int fuzz)
        {
            StringBuilder list = new StringBuilder();
            StringBuilder fun = new StringBuilder();
            for (int i = 1; i <= fuzz; i++)
            {
                if (i % 3 == 0)
                    fun.Append("Duck");
                if (i % 5 == 0)
                    fun.Append("Goose");
                if (fun.Length == 0)
                    fun.Append(i.ToString());
                if (i < fuzz)
                    fun.Append(Environment.NewLine);
                list.Append(fun);
                fun.Clear();
            }
            return list.ToString();
        }

        /* Example - if the input to this method is 20, the following string should be returned
         * 1
         * 2
         * Duck
         * 4
         * Goose
         * Duck
         * 7
         * 8
         * Duck
         * Goose
         * 11
         * Duck
         * 13
         * 14
         * DuckGoose
         * 16
         * 17
         * Duck
         * 19
         * Goose
         */

        // If you've finished all these challenges, sign up for CodeWars.com and try to complete a few C# challenges there!
    }
}