using System;
using System.Collections.Generic;
using System.Linq;//this seems to be required for method extensions associated with variables of type IEnumerable.... as in, System.collections.Generic isn't satisfactory enough with System.Linq when it comes working with variables associated with type IEnumerable.

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet03
    {
        public bool ArrayContainsAFalse(bool[] vals)//interesting; an array that only takes in and utilizes values of true or false for each of its indexes.
        {
            for (int i = 0; i < vals.Length; i++)//we aren't necessarily looking to populate an array with values in its indexes -- we just need a script that can parse through however many indexes it's going to have.
            {
                if (vals[i] == false)//if i happens upon an index value of false whilst it is parsing through the vals array, return true.
                {
                    return true;
                }
            }
            return false;//if i doesn't encounter an index value of false while it is parsing through the vals array, return false.
            //throw new NotImplementedException();
        }

        public bool IsSumOfOddsOdd(IEnumerable<int> numbers)//is the sum of a collection of odd based values (int numbers) odd.
        {
            if (numbers == null || numbers.Count() == 0)//make sure the system.Linq is enabled.
            {
                return false;//Reemeber, this method is expecting a bool based value to be returned, so make sure that any returns are in the form of true or false.
            }
            var sum = numbers.Sum();
            return (sum % 2 != 0);//this didn't throw an error when the parentheses weren't present....
            //throw new NotImplementedException();
        }

        public bool PasswordContainsUpperLowerAndNumber(string password)//if a string can be treated as an array of characters, then can't there be a numerical equivalent that could be treated as a list?
        {
            //bool containsUpper;//this works actually, to my point written in down below, but it has to be explicitly declared, not inferred.
            var containsUpper = false;//I guess we just need to set each Boolean based variable here to false more so to act as a placeholder for the variable itself until it gets called into action, but I'd otherwise think that such a variable would default to a value false anyway.
            var containsLower = false;
            var containsNumber = false;

            for (int i = 0; i < password.Length; i++)
            {
                if (char.IsLower(password[i]))
                {
                    containsLower = true;
                    //return true;//I'm thinking that we don't want to utilize the return functionality here within this context because this script, for this method requires itself to be looped into each of its components (you could almost think of the subsequent if statements as conditionals in addition to this one by which the method as a whole is running through).
                }//Remember that if statements don't require else components, and are actually just fine without them, even for readability.... this IDE seems to like the idea also.
                if (char.IsUpper(password[i]))
                {
                    containsUpper = true;//we can set a variable equal to the exact same value type we would as if we were to return a value of the same type without the use of a variable (thinking this could also work for other value types, not just ones as simple as booleans).
                }
                if (char.IsNumber(password[i]))
                {
                    containsNumber = true;
                }
            }
            if (containsLower == true && containsUpper == true && containsNumber == true)
            {
                return true;
            }
            return false;
            //throw new NotImplementedException();
        }

        //public bool ListContainsPositiveNumbers(int '12345678')//my feeble attempt at creating a numerical oriented array type method similar to the one above that passes in integers as characters for an undeclared list or array of numbers.
        //{
        //var containsNumber = false;
        //var containsPositive = false;
        //var contains

        //for (int = 0; int < 12345678.Count; int++)
        //{
        //if (char.IsNumber(12345678[i]))//there is no predefined method in the system libraries, even through the inclusion of LINQ, that has any method extension like .IsNumberPositive or IsNumberNegative.
        //{
        //containsNumber = true;
        //}
        //}
        //}

        public char GetFirstLetterOfString(string val)//char can be used to parse through strings as if they were an array. Logical thought suggests that if there were no direct way of passing value types into a similar method that was using a sequence of numbers as a series of digits just like a string type would, then such numbers could actually be converted into strings anyway, but doing this would most likely obsolete, because the purpose of parsing through numbers is often different than parsing through reference types, even if they're individual characters/indexes (arrays versus strings).
        {
            return val.First();//this is yet another instance where if the system.LINQ namespace isn't written in for use of the program file as a whole, then such method extension are deemed non-existent by VS Community.
            //throw new NotImplementedException();
        }

        public char GetLastLetterOfString(string val)
        {
            return val.Last();//lucky guess on my part.... just based on the method written above and how it was scripted. Hey, at least now I know there's an extension method predefined within the LINQ system library that offers a .Last functionality.
            throw new NotImplementedException();
        }

        public decimal Divide(decimal dividend, decimal divisor)
        {
            if (dividend == 0 || divisor == 0)//without this if statement, the whole script only passes 7 or 8 of the tests for it. This is because we must remind this method that it isn't possible to be able to divide by zero, nor divide into zero, and so we can instruct it to return a value of zero if either of those 2 cases arise as a possibility when the script is run.
            {
                return 0;
            }
            return dividend / divisor;
            //throw new NotImplementedException();
        }

        public int LastMinusFirst(int[] nums)
        {
            return nums[nums.Length - 1] - nums[0];//this returns a value type of int based upon whatever the ending index of the nums array is deducted from its first index. 
            //throw new NotImplementedException();
        }//Remember to - 1 from the  total count of whatever the array's length ends up being because technically, the array's length doesn't account for a value of zero as part of its total index count -- I'll write out an example below.
         //var nums = new int [10];
         //nums now looks like this for its size;   | 1,  2,  3,  4,  5,  6,  7,  8,  9,  10| -- these represent the chronological values of numbers stored within the indexes, but at the same time, they collectively represent the array's size.
         //if we were to try and print nums' final  |     1,  2,  3,  4,  5,  6,  7,  8,  9,|  10   index to the console without deducting a value of one, here's what physically happens -- what's thought to be nums' tenth index is actually what would be its eleventh index, because it gets pushed up by a value of 1 due to the first index of the array being assigned to zero. But an 11th index doesn't exist here because we only made it 10 indexes large in size, and this is why an error gets thrown when such an approach to printing say a final index of an array is done without subtracting a value of one from it.
         //nums now looks like this for its indexes;|[0],[1],[2],[3],[4],[5],[6],[7],[8],[9]| -- these represent the indexes which those values are stored in.
         //so, if we deduct a value of 1 from nums total size (length), its final index should actually match up with the value representing the total size of the array minus one, because this is the only way we can communicate to the computer through C# that we want to access the array's final index (unless each index was specified and typed out, then we could code for it in the scope, but when we don't have a defined array size [say in this case where it's being passed as an argument into a method] then this sort of syntactic scripting method works well..
         //                                               1,  2,  3,  4,  5,  6,  7,  8,  9.  -- nums' highest index is 9 even though its size is 10.
         //the zero index will always remain as nums' first index. There's no need to add or deduct from it.
         //The last element is at index (Length - 1) because Length gives the total number of elements, not the highest index. The highest index will always be one less than what the total number of elements is because the first index starts at 0, not at 1 like the total number of elements would. I've encountered this before in previous exercises.... if the total number of elements or length of the array aren't deducted by at least one, then the index the script would be attempting to print to the console doesn't technically exist, because it goes beyond what highest index is for the array's size.
         //int[] numbers = { 10, 20, 30, 40, 50 };
         //Console.WriteLine(numbers.Length);      // Output: 5
         //Console.WriteLine(numbers[0]);         // First element: 10
         //Console.WriteLine(numbers[4]);         // Last element: 50
         //Console.WriteLine(numbers[numbers.Length - 1]); // Also last element: 50
         //adding onto the example I wrote out above, if we wanted to access nums' sixth index, it'd be the same principle that we used to access its last index -- we'd be writing something along the lines of nums.Length - 5, because nums' sixth index can only be accessed in this instance by way of telling the computer to subtract a value of 5 from its total size, which is consequently going to yield the number 5, that's also the sixth index, because all indexes start at zero (apologies for redundancy, but it took me writing all of this out to concretely understand the relationship between indexes and collection sizes and how they constitute a uniform means of index accessibility within a collection type variable.
        public int[] GetOddsBelow100()
        {
            var collection = new List<int>();//interesting that an inferred typed list doesn't require any form initialization, despite that being mandatory for other value types. Strange.
            //collection = 100;

            for (int i = 0; i < 100; i++)//(int i = 0; i < collection.Count; i++)
            {
                if (i % 2 != 0)
                {
                    collection.Add(i);//Console.WriteLine(i);//I feel like this script would work if the method didn't require a return type of an array.
                }
            }
            return collection.ToArray();
            //a method extension that converts elements of a list into an array.
            //var variable = 100;//inferred requires initialization, explicitly typed doesn't -- see below.
            //int variable;
            //int variable = 0;
            //var dubiousArray = new int[100];
            //for (int i = 0; i< dubiousArray.Length; i++)
            //{
            //variable = dubiousArray[i];//dubiousArray+1;//dubiousArray += dubiousArray + 1
            //if (variable % 2 != 0)
            //{
            //return variable;//this would work, but the method wants an array type for its returned value.
            //}
            //}
            //if (variable < 100)//not necessary, as the array's size was already set to 100 indexes, which when properly populated with numbers starting from zero will yield all numbers less than one hundred, that aren't negative.
            //{
            //if (variable % 2 != 0)
            //{
            //Console.WriteLine($"{variable}");//this method wants a return of an array type, so it won't accept this.
            //return dubiousArray;//this is an int based array! Why isn't VS Community happy with that? That's what it's looking for in the return for this method.
            //return variable; this would work if the return type for this method was of type int.
            //}
            //}
            //throw new NotImplementedException();                           
        }

        public void ChangeAllElementsToUppercase(string[] words)
        {
            for (int i = 0; i < words.Length; i++)
            {
                words[i] = words[i].ToUpper();//for the array of strings titled words, while i is less than the length of array words, i will increment by 1. for each i of words = i of words converted to Upper Case.
                //words[i].ToUpper();//I'm guessing that here, VS Community knows to register .ToUpper if the variable calling it is registering as an array type.
                //words.ToUpper();//This didn't work at all -- so, how does VS Community know not to register the .ToUpper extension method if a variable isn't necessarily expressed as an array?
                Console.WriteLine(words[i]);
            }

            //throw new NotImplementedException();
        }
    }
}
