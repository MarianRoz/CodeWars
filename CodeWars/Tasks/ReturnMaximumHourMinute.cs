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
            Dictionary<int, int> numberOfElements = new Dictionary<int, int>();
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (numberOfElements.ContainsKey(inputArray[i]))
                {
                    numberOfElements[inputArray[i]] = numberOfElements[inputArray[i]] + 1;
                }
                else
                {
                    numberOfElements.Add(inputArray[i], 1);
                }
            }
            return numberOfElements;
        }

        public static bool hasDigit(Dictionary<int, int> numberOfElements, int digit)
        {
            if (numberOfElements.ContainsKey(digit) && numberOfElements[digit] > 0)
            {
                numberOfElements[digit] = numberOfElements[digit] - 1;
                return true;
            }
            return false;
        }


        public static string MaxResolve(int[] inputArray)
        {
            Dictionary<int, int> numberOfElements = getFrequencyMap(inputArray);
            int i;
            bool flag;
            string time = "";
            flag = false;

            for (i = 2; i >= 0; i--)
            {
                if (hasDigit(numberOfElements, i))
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
                    if (hasDigit(numberOfElements, i))
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
                    if (hasDigit(numberOfElements, i))
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

            numberOfElements = getFrequencyMap(inputArray);

            for (i = 5; i >= 0; i--)
            {
                if (hasDigit(numberOfElements, i))
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
                if (hasDigit(numberOfElements, i))
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