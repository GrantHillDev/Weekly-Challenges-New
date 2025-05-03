using System;
using System.Collections.Generic;

namespace ChallengesWithTestsMark8
{
    public class ChallengesSet05
    {
        public int GetNextNumberDivisibleByN(int startNumber, int n)
        {
            return ((startNumber / n) + 1) * n;
        }

        public void ChangeNamesOfBusinessesWithNoRevenueTo_CLOSED(Business[] businesses)
        {
            for (var i = 0; i < businesses.Length; i++)
            {
                if (businesses[i].TotalRevenue == 0)
                {
                    businesses[i].Name = "CLOSED";//this method was particular about having all of its string being typed out in all capital letters.
                }
            }
        }

        public bool IsAscendingOrder(int[] numbers)
        {
            if (numbers.Length == 0 || numbers == null)//I don't get it.... I instructed C# to return a value fo false provided the value of numbers happens to be null.... yet, it keeps throwing a System.NullReferenceException error anyway.
            {
                return false;
            }

            for (var i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] < numbers[i - 1])//could rewrite this to reflect an array checker to see if it's in ascending order -- if (numbers[i] > numbers[i +1]), return true.
                {
                    return false;
                }
            }
            return true;
        }

        public int SumElementsThatFollowAnEven(int[] numbers)
        {
            if (numbers == null || numbers.Length == 0)
            {
                return 0;
            }

            int sum = 0;

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i - 1] % 2 == 0)
                {
                    sum += numbers[i];
                }
            }
            return sum;
        }

        //public string TurnWordsIntoSentence(string[] words)
        //{
        //    if (words == null || words.Length == 0)
        //    {
        //        return "";
        //    }

        //    string sentence = "";

        //    foreach (string word in words)
        //    {
        //        string trimmed = word.Trim();

        //        if (trimmed.Length > 0)
        //        {
        //            if (sentence.Length > 0)
        //            {
        //                sentence += " ";
        //            }

        //            sentence += trimmed;
        //        }
        //    }

        //    if (sentence.Length == 0)
        //    {
        //        return "";
        //    }

        //    return sentence + ".";
        //}

        public string TurnWordsIntoSentence(string[] words)
        {
            if (words == null || words.Length == 0)
            {
                return "";//method is expecting a string to be returned.
            }

            string sentence = "";

            foreach (string word in words)
            {
                if (word.Trim().Length > 0)//Trim method helps to eliminate blank spaces present before and after characters within a string.
                {
                    sentence += word.Trim() + " ";//sentence += word.Trim() + " ";//This doesn't make any difference whatsoever in the functionality of the code block in this foreach loop -- I rewrote it on the left. Updated; it does work, and it's appropriate for this block of code, but it turns out that VS Community isn't terribly reliable at updating itself when lines of ode are being changed ro rewritten....making unit testing pointless, but I shouldn't havhe to stop what I'm doing and restart VS Community just for it to be able to read my code properly, especially as it pertains to unit testing. Very frustrating.//apparently, operators can be used for string types....
                }//just found out that .Trim only removes blank spaces that are before and after the whole string, so if it contains multiple words, like in this instance, it will not work on individual words that may contain excessive blank spaces.
            }//The extra space in the code above ensures that all characters coming together to form words in the string's entirety only have one space between them, and will be trimmed first in case they any other excessive spaces (this could be useful in the event someone typed in 2 or 3 or more extra blanks spaces than they needed to.... and this enhances the functionality of the .Trim method to properly space out each word, rather than limiting it only working on the string as a whole).

            if (sentence.Length == 0)//TrimStart only removes blank spaces before starting characters of a string....
            {
                return "";//TrimEnd only removes blank spaces after the ending characters of a string....
            }

            sentence = sentence.Trim();//sentence.Trim();//This won't work, because it only takes care of the outer blank spaces -- not the ones internal to a string. Updated; it doesn't work unless you set itself equal to itself, but trimmed one more time....and then the period would be ready to be added. Gosh it all comes back to one very fundamental principle in object oriented programming; we need variables and objects to store our data for us.... what was happening before was sentence.Trim(); by itself wasn't storing the result of what it was doing.... and therefore, the program never got a chance to register that for itself, and thus the same tests kept getting failed over and over again....I have my moments. The scary thing is.... break points would not have helped me diagnose this problem any quicker, likely, because I would have kept getting faced with the same execution result each time, but without knowing why, only knowing that it was being caused by the same problem, from the same line of code, but again, the fundamental reason for why it wasn't working really just comes back to making sure you've got a means to return the right data -- that's why we made the sentence variable.//sentence.TrimEnd();
            sentence += ".";//The above line of code would actually work as it pertains to the unit tests for this method.... because the period isn't being added in until after the .Trim has been executed on the rest of the string.... but for some unknown reason, it's not.
            return sentence;//return "";
        }

        public double[] GetEveryFourthElement(List<double> elements)//method expects a double type array to be returned, but it passes in a list.
        {
            if (elements == null || elements.Count == 0)
            {
                return new double[0];//return an empty double type array (can't be left vacant; must contain a value, in which case, 0 makes it a list that's got no indexes).
            }

            List<double> everyFourth = new List<double>();

            for (var i = 3; i < elements.Count; i += 4)//start at the fourth element/index, then increment by every fourth element/index.
            {
                everyFourth.Add(elements[i]);//we get the flexibility of utilizing a list, before converting into an array.
            }

            return everyFourth.ToArray();
        }

        public bool TwoDifferentElementsInArrayCanSumToTargetNumber(int[] nums, int targetNumber)
        {
            if (nums == null || nums.Length == 0)//I guess this wasn't necessary
            {
                return false;
            }
            for (int i = 0; i < nums.Length; i++)//utilizing nested for loops is a great and efficient way to compare one element to another within the same collection.... think back to the taco parser project.
            {
                for (int j = i + 1; j < nums.Length; j++)//this ensures that j and i are never going to be valued at the same number within the same array, even though they are each parsing through it within their own for loops.
                {
                    if (targetNumber == nums[j] + nums[i])//remember the syntax for operators in conditional statements ==, not =.
                    {
                        return true;
                    }
                }
            }

            return false;//this is to ensure that all code paths return a value, but it also means that no other return is going to be true, which means that the script has to run two comparative for loops with different indexes of the array as instructed to ensure that each number being summed together will satisfy the value of the target number.
        }
    }
}
