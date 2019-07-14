using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Counter.ClassLibrary
{
    public class EnglishToInt
    {
        public double WordtoNumb(string wordnum)
        {
            if (string.IsNullOrEmpty(wordnum)) return 0;

            wordnum = wordnum.Trim();
            wordnum += ' ';

            double number = 0;
            List<string> singles = new List<string>() { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            List<string> teens = new List<string>() { "ten", "eleven", "twelve", "thirteen", "fourteen", "fifteen", "sixteen", "seventeen", "eighteen", "nineteen" };
            List<string> tens = new List<string>() { "", "", "twenty", "thirty", "forty", "fifty", "sixty", "seventy", "eighty", "ninty" };
            List<string> powers = new List<string>() { "", "thousand", "million", "billion", "trillion", "quadrillion", "quintillion" };

            for (int i = powers.Count - 1; i >= 0; i--)
            {
                if (!string.IsNullOrEmpty(powers[i]))
                {
                    int index = wordnum.IndexOf(powers[i]);

                    if (index >= 0 && wordnum[index + powers[i].Length] == ' ')
                    {
                        double count = WordtoNumb(wordnum.Substring(0, index));
                        number += count * (double)Math.Pow(1000, i);
                        wordnum = wordnum.Remove(0, index);
                    }
                }
            }

            {
                int index = wordnum.IndexOf("hundred");

                if (index >= 0 && wordnum[index + "hundred".Length] == ' ')
                {
                    double count = WordtoNumb(wordnum.Substring(0, index));
                    number += count * 100;
                    wordnum = wordnum.Remove(0, index);
                }
            }

            //for (int i = tens.Length - 1; i >= 0; i--)
            foreach (string ten in tens)
            {
                if (!string.IsNullOrEmpty(ten))
                {
                    int index = wordnum.IndexOf(ten);

                    if (index >= 0 && wordnum[index + ten.Length] == ' ')
                    {
                        number += (uint)(tens.IndexOf(ten) * 10);
                        wordnum = wordnum.Remove(0, index);
                    }
                }
            }

            for (int i = teens.Count - 1; i >= 0; i--)
            {
                if (!string.IsNullOrEmpty(teens[i]))
                {
                    int index = wordnum.IndexOf(teens[i]);

                    if (index >= 0 && wordnum[index + teens[i].Length] == ' ')
                    {
                        number += (uint)(i + 10);
                        wordnum = wordnum.Remove(0, index);
                    }
                }
            }

            for (int i = singles.Count - 1; i >= 0; i--)
            {
                if (!string.IsNullOrEmpty(singles[i]))
                {
                    int index = wordnum.IndexOf(singles[i] + " ");

                    if (index >= 0 && wordnum[index + singles[i].Length] == ' ')
                    {
                        number += (uint)(i);
                        wordnum = wordnum.Remove(0, index);
                    }
                }
            }
            return number;
        }
    }
}