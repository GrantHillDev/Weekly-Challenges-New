using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)
        {
            //throw new NotImplementedException();
            if (c == 'c')
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CountOfElementsIsEven(string[] vals)
        {
            throw new NotImplementedException();
        }

        public bool IsNumberEven(int number)
        {//passed all tests.
            //throw new NotImplementedException();
            if (number % 2 == 0)//if variable number divided by 2 yields no remainder, then the variable number is even.
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberOdd(int num)//if variable num divided by 2 does not yield no remainder, then the variable num is odd.
        {//passed all tests.
            //throw new NotImplementedException();
            if (num % 2 != 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double SumOfMinAndMax(IEnumerable<double> numbers)
        {
            throw new NotImplementedException();
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            throw new NotImplementedException();
        }

        public int Sum(int[] numbers)
        {
            throw new NotImplementedException();
            //return numbers[];
        }

        public int SumEvens(int[] numbers)
        {
            throw new NotImplementedException();
        }

        public bool IsSumOdd(List<int> numbers)
        {
            throw new NotImplementedException();
            //if (numbers % 2 != 0)//got an error here suggesting that operands in an if statement cannot be in the form of lists.
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }

        public long CountOfPositiveOddsBelowNumber(long number)
        {
            throw new NotImplementedException();
        }
    }
}
