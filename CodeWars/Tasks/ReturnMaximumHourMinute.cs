using System;
using System.Collections.Generic;
namespace CodeWars.Tasks
{
    /// <summary>
    /// https://www.codewars.com/kata/62a4abf03236976b7acf7781
    /// </summary>
    /// Add string
    public class ReturnMaximumHourMinute
    {
        static Dictionary<int, int> getFrequencyMap(int[] inputArray)
        {
            Dictionary<int, int> hashMap = new Dictionary<int, int>();
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (hashMap.ContainsKey(inputArray[i]))
                {
                    hashMap[inputArray[i]] = hashMap[inputArray[i]] + 1;
                }
                else
                {
                    hashMap.Add(inputArray[i], 1);
                }
            }
            return hashMap;
        }

        static bool hasDigit(Dictionary<int, int> hashMap, int digit)
        {
            if (hashMap.ContainsKey(digit) && hashMap[digit] > 0)
            {
                hashMap[digit] = hashMap[digit] - 1;
                return true;
            }
            return false;
        }


        public static string MaxResolve(int[] inputArray)
        {
            Dictionary<int, int> hashMap = getFrequencyMap(inputArray);
            int i;
            bool flag;
            string time = "";
            flag = false;

            for (i = 2; i >= 0; i--)
            {
                if (hasDigit(hashMap, i))
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
                    if (hasDigit(hashMap, i))
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
                    if (hasDigit(hashMap, i))
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

            hashMap = getFrequencyMap(inputArray);

            for (i = 5; i >= 0; i--)
            {
                if (hasDigit(hashMap, i))
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
                if (hasDigit(hashMap, i))
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