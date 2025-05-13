using System;
using System.Collections.Generic;
using System.Linq;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet06
    {
        public bool CollectionContainsWord(IEnumerable<string> words, string word, bool ignoreCase)//unit tests suggest this method will need to incorporate a null checker.
        {
            if (string.Equals(words, null) || words.Contains(null))//(string.Equals(words, null) -- this means that if the collection as a whole returns a value of null, then the script will return false. words.Contains (null)) -- this suggests that if any indexes of the collection contain a value of null, then the script will return false.
            {
                return false;
            }//Remember, this is how test driven development works; I can write out a shell of code for what's anticipated, or what's needed, but more can always be added or refactored later on.

            bool containsWord = false;//start with false as a default.

            if (ignoreCase == true)
            {
                word = word.ToLower();//so now we've established in this case that capital or lower case doesn't matter if ignoreCase equals true.

                List<string> lowerCase = words.Select(x => x.ToLower()).ToList();//words.Select(x => x.ToLower());//It look like this would only return a value type of IEnumerable, whereas we need it to return a value type of list, and thankfully, there's a method which enables us to do that real fast (otherwise, C# will suggest that a value type of IEnumerable cannot be implicitly converted to a list type). The more time I spend programming in C#, the more I being to associate the term implicit with the term inferred....

                containsWord = lowerCase.Contains(word);
            }

            if (ignoreCase == false)
            {
                containsWord = words.Contains(word);//if a word happens to have a capital letter, this will return false.
            }//Remember, when scripts do stuff, their results have to be stored somewhere; either in a variable or an object. Else, they don't get stored, just merely executed.
            return containsWord;
        }

        public bool IsPrimeNumber(int num)// prime numbers cannot be negative.
        {
            if (num >= 0)//negative number checker.
            {
                if (num % 2 != 0 && num % 3 != 0)//if any number is not divisible by 2, then it is not a prime number. 
                {
                    return true;
                }
            }//all of these returns could have been contained within a variable if we wanted to write them out that way, but I was curious to try out just standard returns without using a variable to store their Boolean values, just to see if it would work, and it did.

            if (num == 2 || num == 3)//else if (num == 2 || num == 3)//Numbers 2 and 3 are prime numbers. Weird.... when I changed this else if statement to an if statement, it worked as intended -- so why should I be using an else if statement, when an if statement after another if statement works just fine?
            {
                return true;
            }

            if (num == 1)//else if (num == 1)
            {
                return false;//this should have returned false given the stated conditional, but the unit test seems to be confused....
            }
            return false;//starting to get the hang of petternisitic related notions otherwise associated with how we want methods we design to return their differing code paths.... the default return almost always seems to be false, but of course that depends on how we structure the method.
        }

        public int IndexOfLastUniqueLetter(string str)//guessing that this method is asking for a return of a character in a string array that isn't repeated in any of its indexes -- hence why we'd have to write a script that compares one index parser's value against another's (i and j in this case).
        {
            int index = -1;//unit tests for this method are calling for the default value of the return if the array contains no characters.
            bool uniqueIndex;

            for (int i = 0; i < str.Length; i++)
            {
                uniqueIndex = true;

                for (int j = 0; j < str.Length; j++)//check each letter/character against the following letter.
                {
                    if (str[i] == str[j] && i != j)//I'm still confused here about why we'd want a conditional that suggests i doesn't equal j -- wouldn't we want that to be true? Obviously, writing it in this way enables the method to pass all of the tests, and I'm looking at what's happening when i == j, or not setting i != j (leaving it out), and the index variable always returns a value of negative 1.... so I know that it's acting as a filter for what the value of index i is, but I just don't get the logic of i != j in this instance, resulting in that.
                    {
                        uniqueIndex = false;//return false;
                    }
                }
                if (uniqueIndex == true)
                {
                    index = i;
                }
            }
            return index;//only returning a value that's passing the bool, which means whatever i has been parsed for can be returned as an integer re[resenting the index of the array being parsed, and it will be unique (no other copies of it).
        }

        public int MaxConsecutiveCount(int[] numbers)
        {
            int count = 0;

            for (var i = 0; i < numbers.Length; i++)
            {
                int currentCount = 1;
                for (var j = i + 1; j < numbers.Length; j++)//if j is equal to i + 1, this ensures that j is going to represent the index that's always behind i (consecutive).
                {
                    if (numbers[i] != numbers[j])//if numbers at index i is not equal to numbers at index j, then break the script.
                    {
                        break;
                    }
                    currentCount++;
                }
                if (currentCount > count)
                {
                    count = currentCount;
                }
            }
            return count;
        }

        public double[] GetEveryNthElement(List<double> elements, int n)//n has to be a number of one or greater.
        {
            var nthElement = new List<double>();//this represents the variable that's going to be used to store data for the method's expected return, it an be changed to an array type later, but the method is passing in a list type argument.

            if (elements == null || n <= 0 || n > elements.Count)//a null checker, but also a checker to ensure that n is greater than a value of 0.
            {
                return nthElement.ToArray();//if the parentheses after the extension method are forgotten to be typed in here, the error returned ask if you forgot to invoke the method.
            }//here, we're retuning an empty list that's being converted into an array, and we know that the list is empty because we declared and initialized it that way without populating it with any indexes yet.

            for (var i = n - 1; i < elements.Count; i += n)//oh, now I see how this works -- n seems to represent the 'element' of the elements array at its index i. So if i is equal to four, then n needs to represent its fourth element (the fourth element stemming from wherever i is parsing at any given index of the elements list). This was initially confusing because indexes and elements represent the same thing in a list or an array, but I suppose it's better to not remain redundant with either phrase in this context because doing such would only make the instructions for completing this method even more confounding. n has to be minus-ed by 1 because of how arrays and lists start at an index of 0, but now for every parsed index i of the elements list, we increment by n; meaning that no matter what index i is at, its value will be translated into n's value simultaneously, matching i's value and therefore enabling the script to increment by n. Honestly, the instructions for this method were already pretty vague to me -- I wouldn't have known what every nth element was even getting at.... might want to find a way to ensure that solving for methods such as these are made more explicitly clear to newcomers such as myself.
            {
                nthElement.Add(elements[i]);//for every index i of elements, while n is equal to i - 1 (just means that n is equal to i without being compromised by the initial index of 0 offsetting the true value pertaining to where i is parsing at any given executuon of the script) add i to elements.... and this works well by itself because i is being incremented by n each time the script executers, thereby including whatever nth element i needs to satisfy the unit tests.
            }

            return nthElement.ToArray();
        }
    }
}
