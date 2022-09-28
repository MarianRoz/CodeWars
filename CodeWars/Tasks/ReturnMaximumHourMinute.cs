using System;
using System.Collections.Generic;
namespace CodeWars.Tasks
{
    /// <summary>
    /// https://www.codewars.com/kata/62a4abf03236976b7acf7781
    /// </summary>
    /// Add string
    public partial class Tasks
    {
        public static Dictionary<int, int> getFrequencyMap(int[] inputArray)
        {
            Dictionary<int, int> NumberOfElements = new Dictionary<int, int>();
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (NumberOfElements.ContainsKey(inputArray[i]))
                {
                    NumberOfElements[inputArray[i]] = NumberOfElements[inputArray[i]] + 1;
                }
                else
                {
                    NumberOfElements.Add(inputArray[i], 1);
                }
            }
            return NumberOfElements;
        }

        public static bool hasDigit(Dictionary<int, int> NumberOfElements, int digit)
        {
            if (NumberOfElements.ContainsKey(digit) && NumberOfElements[digit] > 0)
            {
                NumberOfElements[digit] = NumberOfElements[digit] - 1;
                return true;
            }
            return false;
        }


        public static string MaxResolve(int[] inputArray)
        {
            Dictionary<int, int> NumberOfElements = getFrequencyMap(inputArray);
            int i;
            bool flag;
            string time = "";
            flag = false;

            for (i = 2; i >= 0; i--)
            {
                if (hasDigit(NumberOfElements, i))
                {
                    flag = true;
                    time += i;
                    break;
                }
            }

            if (!flag)
            {
                return "-1";
            }

            flag = false;

            if (time[0] == '2')
            {
                for (i = 3; i >= 0; i--)
                {
                    if (hasDigit(NumberOfElements, i))
                    {
                        flag = true;
                        time += i;
                        break;
                    }
                }
            }

            else
            {
                for (i = 9; i >= 0; i--)
                {
                    if (hasDigit(NumberOfElements, i))
                    {
                        flag = true;
                        time += i;
                        break;
                    }
                }
            }
            if (!flag)
            {
                return "-1";
            }
            time += ":";
            flag = false;

            NumberOfElements = getFrequencyMap(inputArray);

            for (i = 5; i >= 0; i--)
            {
                if (hasDigit(NumberOfElements, i))
                {
                    flag = true;
                    time += i;
                    break;
                }
            }
            if (!flag)
            {
                return "-1";
            }
            flag = false;
            for (i = 9; i >= 0; i--)
            {
                if (hasDigit(NumberOfElements, i))
                {
                    flag = true;
                    time += i;
                    break;
                }
            }
            if (!flag)
            {
                return "-1";
            }
            return time;
        }
    }
}