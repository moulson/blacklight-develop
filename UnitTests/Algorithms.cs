using System.Linq;
using System.Text;

namespace BlackLight.Recruitment.UnitTests
{
    class Algorithms
    {
        public static string ReverseWordsInString(string input)
        {
            //Using Linq
            var reverse = input
                .Split(' ')
                .Reverse();

            return string.Join(" ", reverse);
        }

        public static string ReverseWordsInStringWithoutUsingAnyLinqMethods(string input)
        {
            //Should still work if remove `using System.Linq;`
            var reverse = input.Split(' ');

            //Use a stringbuilder as strings are immutable.
            StringBuilder builder = new StringBuilder();

            for (int i = reverse.Length - 1; i >= 0; i--)
            {
                builder.Append(reverse[i]);

                //Only add a space if it's not the last word to be added
                if (i > 0)
                {
                    builder.Append(" ");
                }
            }
            return builder.ToString();
        }

        internal static int[] SortWithoutUsingBuiltInSortMethods(int[] input)
        {
            //bubble sort
            int temp;
            for (int i = 0; i <= input.Length - 2; i++)
            {
                for (int j = 0; j <= input.Length - 2; j++)
                {
                    if (input[j] > input[j + 1])
                    {
                        temp = input[j + 1];
                        input[j + 1] = input[j];
                        input[j] = temp;
                    }
                }
            }
            return input;

        }
    }
}
