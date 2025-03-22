using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet02
    {
        public bool CharacterIsALetter(char c)//Had to go online to look up a point of reference for how to determine a function could determine if a character was a letter.
        {//when I looked at the definition for IsLetter, it turned out to be an extension of char.
            return char.IsLetter(c);//the method is expecting a return in the form of a Boolean.
            //throw new NotImplementedException();
            //if (c == 'c')//first attempt.
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
        }

        public bool CountOfElementsIsEven(string[] vals)//array? A collection of strings. Name of this collection is vals.
        {
            if (vals.Length % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            //could even just write the same script like this; with no else statement.
            //if (vals.Length % 2 == 0)
            //{
            //return true;
            //}
            //return false;
            //throw new NotImplementedException();
        }

        public bool IsNumberEven(int number)
        {//passed all tests.
            //throw new NotImplementedException();
            if (number % 2 == 0)//if variable number divided by 2  yields no remainder, then the variable number is even.
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IsNumberOdd(int num)//if variable num divided by 2 does not yield any remainder, then the variable num is odd.
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

        public double SumOfMinAndMax(IEnumerable<double> numbers)//IEnumerable specifies collections, which could either be arrays or lists.
        {//Enumberable is definined as mentioning a number (collection) of things one by one. IEnumerable can be thought of as function that defines how a collection should behave, but also what we can do with the item (I) in that collection.
            if (numbers == null || numbers.Count() <= 0)//defines what the method should do in the event that the collection being passed into the method either has zero indexes or whose numbers equal a value of 0.
            {
                return 0;
            }
            return numbers.Min() + numbers.Max();//this line of code by itself does not pass all tests provided for the method which it's defining -- this is because its being tested for results that yield a value of zero, which it doesn't do by itself, so we have to assign an if statement with conditions set on what the method needs to do if 0 is a yielded result.
            //throw new NotImplementedException();//this method is telling us that it is giving us a collection of doubles, and it doesn't seem to matter whether it's an array or a list.
        }

        public int GetLengthOfShortestString(string str1, string str2)
        {
            if (str1.Length < str2.Length)
            {
                return str1.Length;
            }
            return str2.Length;//notice how 'not all code paths return a value' presents itself as a thrown error when not every parameter defined in the named method is returning something -- it must pass a value not just for one or the other, but for both (which of course we'd want it to, in this instance, as per its intended functionality, but syntactically, the method is expectant of returns for str1 and str2).
            //throw new NotImplementedException();
        }

        public int Sum(int[] numbers)
        {
            if (numbers == null)
            {
                return 0;
            }
            //return numbers.Sum();
            //for (int i = 0; i < numbers.Length; i++)//for some reason, this didn't work, and it's not clear to me why.... probably a syntactic error.
            //{
            //return numbers.Sum();
            //return numbers[i];
            //}
            int sum = 0;//our placeholder for the variable 'sum'.

            for (int i = 0; i < numbers.Length; i++)//I had it right! In concept; in thought, but my syntax was off, as would be expected, but of course the error thrown at me by VS Community was vague and not well communicated as always.
            {
                sum += numbers[i];//accidentally, I'd previously written out return sum += numbers[i]; which inevitably meant that the script was terminating itself after its execution, despite the conditions expressed by its governing if statement. While the syntax of the script was on point, the return command prevented the rest of the code beneath it from being executed at runtime, but you have to remember that the code within the scope of this for loop is merely defining what's happening inside of the array being defined by the method for which it's written for, so sum acts as a variable that takes in data, in the form of integers, and i is the item in the array that's adding each index to the sum of the array each time the for loop is being executed. This explains why we need to still write out a return of the variable sum after all is said and done with the for loop's execution.
            }
            return sum;//what I needed to do, the only thing; was to create and define a variable of type int to store data numbers[i].... and I would have been fine. The good news is, I got the mental problem solving thought process for this one down, but it just needed some syntactic correction. C'mon VS Community.... help me out here.
            //throw new NotImplementedException();
        }

        public int SumEvens(int[] numbers)
        {
            if (numbers == null)//this is also referred to as a null check.
            {
                return 0;
            }

            int sumOfEvens = 0;
            //int i = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                if (numbers[i] % 2 == 0)//(numbers % 2 == 0)
                {
                    sumOfEvens += numbers[i];
                }
                //return sumOfEvens;//I originally made the mistake of writing this return inside of the for loop, inevitably blocking it from running more than once, and even if it could have run more than once like it might, depeinging on the length of the array in question, I made the foolish mistake of return a value of 0 outside of that for loop, at the end of the method, which inevitably meant that no matter what this script did, it going to return a value fo zero, which would have made it useless; pointless. Syntax strikes again.
            }
            return sumOfEvens;
            //return 0;//wasn't necessary; t'was merely a notion of ensuring all paths returned a value, but had I not made the mistake of returning the variable sumOfEvens inside of the for loop for which it was supposed to be written outside of, so that it could retain and express whatever its stored data input was from the for loop's execution, then this other mistake I made would never have occurred.
            //int sumEvens = 0;
            //int i= 0;
            //if (numbers[i] % 2 == 0)//(numbers % 2 == 0)
            //{
            //for (i = 0; i < numbers.Length; i++)
            //{
            // sumEvens += numbers[i];
            //}
            //return sumEvens;
            //}
            //return 0;//else, if sum
            //throw new NotImplementedException();
        }

        public bool IsSumOdd(List<int> numbers)
        {//don't think we need a varibale, inferred, explicit, or otherwise to act as a placeholder for a Boolean type of value.... we can just return a value of true or false without expressing through a variable (because it's only ever going to be true or false, whereas with integers, it could be any number, just about).
            if (numbers == null)//remember, null is encompassing of a zero value, but for syntactic reasons, we can't just write in a 0 here.
            {
                return false;//we must return a value that's within the parameters defined by a Boolean type here, even though the specific test regarding this aspect of the method is looking to see that a value of null would be invalid for what the test is asking for, but because we need to return a Boolean type, it must be expressed as true or false, in which zero is not an odd number, and therefore would be attributed to returning a value of false.
            }
            //throw new NotImplementedException();

            //int sumOfOdd = 0;
            int sumOfList = 0;
            int i = 0;
            //if (numbers[i] % 2 != 0)
            //{
            for (i = 0; i < numbers.Count; i++)//while the length of list numbers is greater than i, let i increment by 1. Each time i increments by 1, execute the following script.
            {
                sumOfList += numbers[i];//populates the sumOfList variable with i of numbers each time the for loop of i is executed.//sumOfOdd += numbers[i];
            }
            if (sumOfList % 2 != 0)//if the total sum of list numbers is odd, then please return a value of true.
            {
                return true;
            }
            return false;//no else if or else statements were needed here, as any number that isn't odd should be returned as false, per the intention of this method.
                         //if (sumOfList % 2 == 0)
                         //{
                         //return false;
                         //}

            //}
            //return sumOfOdd;//this would have worked as a script has the method been calling for a sum of a list containing only its odd numbers.... but it's looking to see only if the sum of its list is odd.
        }

        public long CountOfPositiveOddsBelowNumber(long number)//long just means the number value will be very big.
        {//I don't believe a null checker is needed here as none of the tests for this method are calling for such a check, so we can still add values of zero here (plus, the parameter for the method here suggests a long variable type, not aq collection, not an array, and not a list, so we don't even need worry about what if the number of indexes in either of those was by chance a value of zero).
            if (number <= 0)
            {
                return 0;
            }
            else
            {
                return number / 2;
            }//unbelievable.... this simple script not only passed all of its method's tests, but it did so in a fraction of the time that my previous attempt did!

            //var count = 0;//this method partially works, but it's not efficient -- when dealing with exceptionally large numbers, it's important not to overwork the hardware or computer anymore than is necessary.

            //if (number == 1 || number <- 0)
            //{
            //return 0;
            //}

            //for (long i = number; i > 0; i--)
            //{
            //if (i % 2 != 0)//if the value of i does not leave a remainder of zero when divided by 2, then the value of i is deemed to be an odd number and therefore can be added as single increment to the value of count.
            //{
            //count++;//we're incrementing the value of count by 1 each time this for loop executes.
            //}
            //}
            //return count;
            //long sumOfPositiveOddsBelowNumber = 0;//the number variable passed into this method as a parameter doesn't need any initialization and it has already been declared as a type, and in this case would therefore be best left without a palceholder because we want for this method to exhibit more flexibility; more usage.
            //List<long> longList = new List<long>();//needed to come up with some sort of collection type variable, as means of comparing its sum to whatever the variable number is going to be whenever we run this script, so here we are.

            //for (int i = 0; i < longList.Count; i++)//I was wrong about this method -- it's not asking for a sum of positive odd numbers below the value of another number; it's looking to see what the total count of said numbers are, which obviously isn't a sum. Therefore, no collection variable types are needed here, just stick to the long types.
            //{
            //if (i > 0)//negative number checker.
            //{
            //sumOfPositiveOddsBelowNumber += longList[i];//now, again, here we're not populating our custom made list variable, but we're instead populating our custom crafted long variable (sumOfPositiveOddsBelowNumber) with the values of each index which i parses through of the list variable, longList. 
            //}            
            //}
            //return sumOfPositiveOddsBelowNumber;//(long)sumOfPositiveOddsBelowNumber;

            //if (sumOfPositiveOddsBelowNumber < number)
            //{
            //return sumOfPositiveOddsBelowNumber;
            //}
            //throw new NotImplementedException();
        }
    }
}
