using Edabit_Challenge.Challenges.Interfaces;

namespace Edabit_Challenge.Challenges
{
    public class Service : IService
    {
        //Return the Index of All Capital Letters
        //Create a function that takes a single string as argument and returns an ordered array containing the indices of all capital letters in the string.
        public int[] IndexOfCapitals(string letters)
        {
            List<int> positions = new List<int>();

            for (int i = 0; i < letters.Length; i++)
            {
                if (char.IsUpper(letters[i]))
                    positions.Add(i);
            }
            return positions.ToArray();
        }

        //Create a function which returns the number of true values there are in an array.
        public int CountTrue(bool[] bools)
        {
            var count = 0;
            for (var i = 0; i < bools.Length; i++)
            {
                if (bools[i])
                    count++;
            }
            return count;
        }

        //Write a function that takes an integer i and returns a string with the integer backwards followed by the original integer.
        public string ReverseAndNot(int numbers)
        {
            var original = numbers.ToString();
            char[] reversedArray = original.Reverse().ToArray();
            var reversed = new string(reversedArray);
            return reversed + original;
        }

        //Create a function that takes a string as an argument and returns a coded(h4ck3r 5p34k) version of the string.
        public string HackerSpeak(string str)
        {
            var keyValuePairs = new Dictionary<char, string>
            {
                {'a', "4"},
                {'e', "3"},
                {'i', "1"},
                {'o', "0"},
                {'s', "5"}
            };

            var result = new char[str.Length];
            for (int i = 0; i < str.Length; i++)
            {
                char currentChar = str[i];
                if (keyValuePairs.ContainsKey(currentChar))
                    result[i] = keyValuePairs[currentChar][0];
                else
                    result[i] = currentChar;
            }
            return new string(result);
        }

        //Create a function that takes an array of numbers and return "Boom!" if the digit 7 appears in the array.Otherwise, return "there is no 7 in the array".
        public string SevenBoom(int[] arr)
        {
            foreach (var number in arr)
            {
                if (number % 7 == 0 || number.ToString().Contains('7'))
                    return "Boom!";
            }

            return "There is no 7 in the array";
        }
    }
}
