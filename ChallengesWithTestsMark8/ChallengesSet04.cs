using System;
using System.Linq;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet04
    {
        public int AddEvenSubtractOdd(int[] numbers)//looks like this method is asking to have the sum of its even numbers deducted from its sum of its odd numbers.... SumEvenSubtractedFromSumOdd would have been much better.
        {
            return numbers.Where(x => x % 2 == 0).Sum() - numbers.Where(x => x % 2 != 0).Sum();
        }

        public int GetLengthOfShortestString(string str1, string str2, string str3, string str4)
        {
            //if(str1 < str2)
            //{
            //    return str1;//str1.Length;
            //}
            var list = new List<int> { str1.Length, str2.Length, str3.Length, str4.Length };
            return list.Min();
        }

        public int GetSmallestNumber(int number1, int number2, int number3, int number4)
        {
            //if(number1 < number2 && number1 < number3 && number1 < number4)
            //{
            //    return number1;
            //}
            //else if(number2 < number1 && number2 < number3 && number2 < number4)
            //{
            //    return number2;
            //}
            //else if(number3 < number1 && number3 < number2 && number3 < number4)
            //{
            //    return number2;
            //}
            //else if(number4 < number2 && number4 < number3 && number4 < number1)
            //{
            //    return number4;
            //}
            //return 0;//Not sure why this code block failed....
            var list = new List<int> { number1, number2, number3, number4 };
            //return list.Min();//the LINQ way.

            var smallestNumber = number1;
            for (int i = 0; i < list.Count; i++)//i will parse through the list for however many times the list is long (its number of indexes).
            {
                if (list[i] < smallestNumber)//if i of list is less than smallestNumber (number1), then smallestNumber (number1) is equal to i of list.
                {//smallest number is the variable that will equal itself out to i of list, but only if that index happens to be less than smallestNumber.
                    smallestNumber = list[i];//return i;//it's weird because I thought that this return would have made logical sense to the computer, but obviously it didn't'.
                }//oh wow, I now see in my head what this simple block of code is doing, and why it was so confusing to me the first few times I was writing it out.... the value stored within the smallestNumber variable is going to be equal to number2, or number3, or number4, but only if they are less than number1, else, the scope will return number1 as this list's smallest number.
            }//if list[i] (number2 or number3 or number4) isn't less than number1, then return number1. 
            return smallestNumber;//this returns whatever the smallest number of the list's indexes is, but we had to use number1 as a placeholder for the smallestNumber variable, but doing so also declared this variable's type, which consequnetly satisifes the expected return in the method.
        }

        public void ChangeBusinessNameTo_TrueCoders(Business biz)//this method doesn't even return anything, so it's already a little trickier to figure out what specifically it wants, and you're only left with the 'biz' argument.
        {
            biz.Name = "TrueCoders";//I just remembered that I can hover over the different methods, variables, and classes, then click on them whilst holding down the ctrl button, to see if there's any more information on them, and that's what I did for the Business class.... wherein I found out that it retained several different members in the form of properties, as opposed to fields, one of which being 'Name', and because it was defined as a property, it could have its value altered inside of the method calling it.
        }

        public bool CouldFormTriangle(int sideLength1, int sideLength2, int sideLength3)//see, this is an ambiguously confusing method to solve for, because it doesn't specific what to look for.... unless you happen to be familiar enough with the context of a triangle, not in the sense of what type of triangle it might be (equilateral, isosceles, obtuse), but in the sense that no one side of it can ever be greater in length than its 2 other sides.... which would make logical sense, if that were made more obvious in what the method was asking for. Oh, and looking this up on google didn't help either. Provide proper context; write a method that's not as ambiguous as this one -- something along the lines of: DoesTriangleHaveTwoSidesGreaterThanItsThirdSide.... and then at least someone who's learning this might have reasonable shot at figuring out what the method is asking for.
        {
            return
            (
                sideLength1 + sideLength2 > sideLength3 &&
                sideLength1 + sideLength3 > sideLength2 &&
                sideLength3 + sideLength2 > sideLength1
            );//not terribly familiar with how a method expecting a Boolean return type can get such out of a return function that only implements integer type variables?
        }

        public bool IsStringANumber(string input)
        {
            //return input.IsNumber;
            var isNumber = double.TryParse(input, out double number);//isNumber is telling us whether or not the input being parsed is a number, and I'm guessing it doesn't matter if set number's type to decimal, double, or integer.
            return isNumber;
        }

        public bool MajorityOfElementsInArrayAreNull(object[] objs)
        {
            var indexes = objs.Length;//we have to equate the length of the array to something, so store it in the gorm a variable.
            var majorityOfIndexes = (indexes / 2) + 1;

            var count = 0;

            foreach (var obj in objs)
            {
                if (obj == null)
                {
                    count++;//this is how we instruct the count variable to retain only the counts of indexes in the array that end up being null.
                }
            }
            if (count >= majorityOfIndexes)//shouldn't this be greater than, and not equal to?
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public double AverageEvens(int[] numbers)
        {
            //double evenSumAverage = 0;
            //double count = 0;
            //var indexes = numbers.Length;

            ////if(numbers < 0)
            ////{
            ////    return 0;
            ////}
            ////foreach (var num in numbers)
            ////{

            ////}

            //foreach(var num in numbers)
            //{
            //    //if (num < 0)
            //    //{
            //    //    return 0;
            //    //}
            //    if (num % 2 == 0) //&& num > 0)
            //    {
            //        evenSumAverage += num;//evenSumAverage = evenSumAverage + num.
            //        count++;//increment count by 1 each time a num in numbers is even.
            //    }
            //}

            //if (evenSumAverage > 0)
            //{
            //    return evenSumAverage / count;//divide the total sum of even numbers added to evenSumAverage by the number of even numbers added to evenSumAverage.
            //}
            //else
            //{
            //    return 0;
            //}//all of this still didn't pass all of the tests.... I don't understand why the variable num doesn't seem to accommodate negative numbers....
            if (numbers == null || numbers.Length == 0)
            {
                return 0;//return 0-1;
            }//if I remove this block of code, then it fails the null test. If I leave it in, it causes the rest of the script to fail the negative tests. Updated; VS Community doesn't seem to work very well some of the time -- this is very frustrating. I've have to close it out and reboot it up several times, and it turned out in the end that my original programming worked just fine to pass all of the tests.... so, if VS Community is unreliable here, then what am I to do?
            //if (numbers == 0)
            //{
            //    return numbers - 1;
            //}
            var n = numbers.Where(num => num % 2 == 0);//.Count();

            if (n.Count() == 0)

                return 0;
            return n.Average();

        }

        public int Factorial(int number)//Factorial is a mathematical operation that is denoted by an exclamation point. It is the product of all positive integers less than or equal to a given positive integer. For example, 7! is equal to 1 x 2 x 3 x 4 x 5 x 6 x 7. The factorial of a number is the multiplication of all the numbers between 1 and the number itself. It is written like this: n!.
        {
            var factorial = 1;//a factorial must at least be a value of 1 or greater, as we cannot multiply anything by zero without it equaling zero.

            if (number < 0)//factorials have to be positive integers.
            {
                throw new ArgumentOutOfRangeException();
            }
            for (int i = number; i > 0; i--)//we write a for loop to define a would be collection, since we don't have one defined here.
            {
                factorial *= i;
            }
            return factorial;
        }


        public static int PositiveSum1(int[] arr)//public class Kata//this was a code wars problem that asked for only the positive values of a given array to be returned; thought it'd be a good reference.
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > 0)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }

        public static int PositiveSum2(int[] arr)//the LINQ version of the method written in above.
        {
            return arr.Where(x => x > 0).Sum();
        }
    }
}
