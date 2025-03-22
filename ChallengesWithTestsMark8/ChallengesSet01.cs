using System;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet01//passed all tests.
    {
        public bool AreTwoNumbersTheSame(int num1, int num2)
        {
            if (num1 == num2)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double Subtract(double minuend, double subtrahend)
        {
            return minuend - subtrahend;//passed all tests.
        }//need to ensure that the subtrahend is being subtracted from the minuend.... else, negative values could be produced, and won't pass all of the tests.

        public int Add(int number1, int number2)
        {//passed all tests. For some reason, this exact scope failed the first time I ran the tests on it.
            return number2 + number1;
        }

        public int GetSmallestNumber(int number1, int number2)
        {//passed all tests. For some reason, this exact scope failed the first time I ran the tests on it.
            //throw new NotImplementedException();
            if (number1 < number2)
            {
                return number1;
            }
            else
            {
                return number2;
            }
        }

        public long Multiply(long factor1, long factor2)
        {//passed all tests.
            return factor1 * factor2;
        }

        public string GetGreeting(string nameOfPerson)
        {//passed all tests. Really had to analyze each test to figure out what this method was looking for as far as passing all of its respective tests.
            //throw new NotImplementedException();
            if (nameOfPerson == "")
            {
                return "Hello!";
            }
            else
            {
                return $"Hello, {nameOfPerson}!";
            }
            //Console.WriteLine($"Hello!" {nameOfPerson});
            //return Console.WriteLine($"Hello, {nameOfPerson}");
        }

        public string GetHey()
        {//passed all tests. Just remember to look at what the test is asking for if you're not passing it.
            //throw new NotImplementedException();
            //throw new NotImplementedException();
            return "HEY!";
        }
    }
}
