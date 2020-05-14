using System;
using System.Collections.Generic;
using System.Text;

namespace HackerRank
{
    class Algorithm
    {
        internal static List<int> compareTriplets(List<int> a, List<int> b)
        {
            int aScore = 0;
            int bScore = 0;

            for (int i = 0; i < a.Count; i++)
            {
                if (a[i] > b[i])
                {
                    aScore += 1;
                }
                else if (a[i] < b[i])
                {
                    bScore += 1;
                }
            }

            return new List<int> { aScore, bScore };

        }

        internal static long aVeryBigSum(long[] ar)
        {
            long result = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                result += ar[i];
            }
            return result;
        }

        internal static int diagonalDifference(List<List<int>> arr)
        {
            var d1 = 0;
            var d2 = 0;

            for (int i = 0; i < arr.Count; i++)
            {
                d1 += arr[i][i];
                d2 += arr[i][arr.Count - 1 - i];
            }

            return Math.Abs(d1 - d2);
        }

        internal static void plusMinus(int[] arr)
        {
            var numberOfPositive = 0;
            var numberOfNegative = 0;
            var numberOfZero = 0;
            foreach (var item in arr)
            {
                if (item > 0)
                {
                    numberOfPositive += 1;
                }
                else if (item < 0)
                {
                    numberOfNegative += 1;
                }
                else {
                    numberOfZero += 1;
                }
            }
            var length = arr.Length;
            Console.WriteLine(numberOfPositive == length ? 1 : Math.Round((double)(numberOfPositive) / length - Math.Truncate((double)(numberOfPositive / length)), 6));
            Console.WriteLine(numberOfNegative == length ? 1 : Math.Round((double)(numberOfNegative) / length - Math.Truncate((double)(numberOfNegative / length)), 6));
            Console.WriteLine(numberOfZero == length ? 1 : Math.Round((double)(numberOfZero) / length - Math.Truncate((double)(numberOfZero / length)), 6));
        }

        static int numberOfAttemps = 0;

        internal static void validate(string step)
        {
            bool success = int.TryParse(step, out int n);
            if (success && n > 0 && n <= 20)
            {
                staircase(n);
            }
            else
            {
                numberOfAttemps += 1;
                Console.WriteLine(numberOfAttemps > 3 ? "May hoi li roi do nha 1 -> 20 thôi" : "Please enter the valid step! (min/max: 0/20)");
                validate(Console.ReadLine());
            }
        }

        static void staircase(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                var space = n - i;
                var preSpace = string.Empty;
                for (int j = 0; j < space; j++)
                {
                    preSpace += " ";
                }
                var stair = string.Empty;
                for (int s = 1; s <= i; s++)
                {
                    stair += s == i ? "#" : "#" + " ";
                }
                Console.WriteLine(string.Format("{0}{1}", preSpace, stair));
            }
            Console.WriteLine("Thanks for your testing q(^ x ^)p");
        }

        internal static void miniMaxSum(int[] arr)
        {
            Array.Sort(arr);
            long sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
            }
            Console.WriteLine(string.Format("{0} {1}", sum - arr[arr.Length - 1], sum - arr[0]));
        }

        internal static int birthdayCakeCandles(int[] ar)
        {
            int count = 1;
            int max = ar.Length > 0 ? ar[0] : 0;
            for (int i = 1; i < ar.Length; i++)
            {
                if (ar[i] > max)
                {
                    count = 1;
                    max = ar[i];
                }
                else if (ar[i] == max)
                {
                    count += 1;
                }
            }

            return count;

        }

        internal static string timeConversion(string s)
        {
            var splitTime = s.Split(char.Parse(":"));
            var isDayTime = splitTime[2].ToLower().EndsWith("am") == true;
            var hour = splitTime[0];

            var hour24 = hour == "12" ? (isDayTime ? "00" : "12") : isDayTime ? splitTime[0] : (int.Parse(splitTime[0]) + 12).ToString();

            return string.Format("{0}:{1}:{2}", hour24, splitTime[1], splitTime[2].Substring(0,2));
        }

        internal static string catAndMouse(int x, int y, int z)
        {
            var distanceAToC = Math.Abs(x - z);
            var distanceBToC = Math.Abs(y - z);
            if (distanceAToC < distanceBToC)
            {
                return "Cat A";
            }
            else if (distanceBToC < distanceAToC)
            {
                return "Cat B";
            }
            else
            {
                return "Mouse C";
            }
        }

        internal static long getMax(long[] arr)
        {
            long max = 0;
            if (arr.Length > 0)
            {
                max = arr[0];
                for (int i = 1; i < arr.Length; i++)
                {
                    if (arr[i] > max)
                    {
                        max = arr[i];
                    }
                }
            }
            return max;
        }

        internal static string getMaxSide(long[] arr)
        {
            string result = string.Empty;
            if (arr.Length > 0)
            {
                List<long> left = new List<long>();
                List<long> right = new List<long>();
                bool isRootAdded = false;
                int line = 0;
                int index = 1;

                int jump = 3;

                for (int i = 0; i < arr.Length; i++)
                {
                    // check condition to add the first element to root
                    if (!isRootAdded)
                    {
                        if (arr[i] == -1)
                        {
                            continue;
                        }
                        else
                        {
                            isRootAdded = true;
                            line = 1;
                            continue;
                        }
                    }
                    if (arr[i] == -1)
                    {
                        continue;
                    }
                    var numberInLine = Math.Pow(2, line) / 2;
                    if (index <= numberInLine)
                    {
                        left.Add(arr[i]);
                        if (index == numberInLine) {
                            numberInLine = (jump + numberInLine) * 2;
                        }
                    }
                    else
                    {
                        right.Add(arr[i]);
                    }
                    index += 1;
                }

                if (left.Count > 0 && right.Count > 0)
                {
                    left.Sort();
                    right.Sort();
                    long maxLeft = left[left.Count - 1];
                    long maxRight = right[right.Count - 1];
                    if (maxLeft > maxRight)
                    {
                        return "Left";
                    }
                    else if (maxLeft < maxRight)
                    {
                        return "Right";
                    }
                    else
                    {
                        return result;
                    }
                }
                return result;
            }
            return result;
        }

    }
}
