using System.Text.RegularExpressions;

namespace AdventOfCode
{
    class Program
    {
        static void Main(string[] args)
        {
            int dayNum;
            do
            {
                Console.Clear();
                Console.WriteLine("Enter the Advent of Code day");

            } while (!int.TryParse(Console.ReadLine(), out dayNum));
            Console.Clear();
            {
                switch (dayNum)
                {
                    case 1:
                        Console.WriteLine($"Day One Answer: {Day1(Tools.TextToString(@"C:\Users\ethschafsta\Documents\GitHub\AdventOfCode2023\code\textFiles\day1puzzleInput.txt"))}");
                        break;
                    case 2:
                        Console.WriteLine($"Day One Answer: {Day2(Tools.TextToString(@"C:\Users\ethschafsta\Documents\GitHub\AdventOfCode2023\code\textFiles\day2puzzleInput.txt"))}");
                        break;
                }
            }
            Console.ReadLine();

        }

        enum numbers 
        { 
            one = 1,
            two = 2,
            three = 3,
            four = 4,
            five = 5,
            six = 6,
            seven = 7,
            eight = 8,
            nine = 9,
        }

        /// <summary>
        /// Takes a string array, extracts the first 2 digits in each, additions all double digits found, returns an int.
        /// </summary>
        static int Day1(string[] inputs)
        {
            // Regex pattern to find all digits
            string pattern = "one|two|three|four|five|six|seven|eight|nine";

            // string list for holding the double digit numbers in string form
            List<string> doubleDigitNum = new List<string>();

            // string list for holding all single digit values found in the string.
            List<string> allSingleDigits = new List<string> { };

            Regex regex = new Regex(pattern);

            // loops through each line of input
            for (int i = 0; i < inputs.Length; i++)
            {
                if (regex.IsMatch(inputs[i]))
                {

                }
                // loops through each char from the input string
                foreach (var item in inputs[i])
                {
                    // if the char can be converted to an int them add it to the single digit list
                    if (int.TryParse(item.ToString(), out int temp))
                    {
                        allSingleDigits.Add(item.ToString());
                    }
                }
                // concat the first and last single digit into a double digit and add to the double digit list
                doubleDigitNum.Add(allSingleDigits.First() + allSingleDigits.Last());
                // reset the single digit list
                allSingleDigits.Clear();
            }

            // return the converted string to int sum of all double digits
            return doubleDigitNum.Sum(x => Convert.ToInt32(x));
        }
        static int Day2(string[] inputs)
        {
            return 1;
        }
    }
}