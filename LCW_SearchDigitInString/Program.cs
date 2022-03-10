using System;
using System.Collections.Generic;
using System.Linq;

namespace LCW_SearchDigitInString
{
    class Program
    {
        static void Main(string[] args)
        {
            //string x = "H3ello-9 -9";
            //string xy = SearchingChallenge(x);

            string str = "Hello world devvvvvrim Kkkkk";
            SearchingChallengeMostRepeatedChars(str);
        }

        public static string SearchingChallengeMostRepeatedChars(string str)
        {
            string[] words = str.Split(' ');

            List<string> indexOfWord = new List<string>();

            var dublicateRecord = new Dictionary<int, char>();
            
            List<Dictionary<int, char>> dictionaryList = new List<Dictionary<int, char>>();

            int countWord = 0;

            foreach (var item in words)
            {
                var repeatedChars = item.ToCharArray().GroupBy(x => x).Where(y => y.Count() > 1).Select(z => z.Key);
                
                foreach (char dublicateChar in repeatedChars)
                {
                    int count = 0;
                    foreach (char character in item)
                    {
                        if (character == dublicateChar) count++;
                    }
                    dublicateRecord.Add(count, dublicateChar);
                    indexOfWord.Add(item);
                    countWord++;
                }
                dictionaryList.Add(dublicateRecord);
            }

            var countsOfDublicatesKey = dictionaryList[0].Keys;

            var countsOfDublicatesValue = dictionaryList[0].Values;

            int indexOf = 0;

            foreach (var item in countsOfDublicatesKey)
            {
                if (countsOfDublicatesKey.Max() == item) indexOf++;
            }

            str = indexOfWord[indexOf];

            return str;
        }

        public static string SearchingChallenge(string str)
        {
            str = str.Replace(" ", "");

            char[] strCharArray = str.ToCharArray();

            int sumDigits = 0;
            int countOfDigitsOnString = 0;
            int countOfLettersOnString = 0;

            foreach (char letter in strCharArray)
            {
                if (char.IsDigit(letter))
                {
                    sumDigits += int.Parse(letter.ToString());
                    countOfDigitsOnString++;
                }
                if (char.IsLetter(letter))
                {
                    countOfLettersOnString++;
                }
            }

            double result = sumDigits / countOfLettersOnString;

            return result.ToString();
        }
    }
}
