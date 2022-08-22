using System.Collections.Generic;
using System.Linq;

namespace BlackLight.Recruitment.UnitTests
{
    class Algorithms
    {
        public static string ReverseWordsInString(string input)
        {

            return string.Join(" ", input.Split(' ').Reverse());
        }

        public static string ReverseWordsInStringWithoutUsingAnyLinqMethods(string input)
        {
            var words = input.Split(' ');
            var reversedWords = new List<string>();
            for (var i = words.Length - 1; i >= 0; i--)
            {
                reversedWords.Add(words[i]);
            }

            return string.Join(" ", reversedWords);
        }

        internal static int[] SortWithoutUsingBuiltInSortMethods(int[] input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                for (int j = i + 1; j < input.Length; j++)
                {
                    if (input[i] > input[j])
                    {
                        int temp = input[i];
                        input[i] = input[j];
                        input[j] = temp;
                    }
                }
            }
            return input;
        }
    }
}
