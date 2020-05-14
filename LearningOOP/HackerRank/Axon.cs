using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace HackerRank
{
    public class Axon
    {
        internal static long Solution(string s)
        {
            // Type your solution here
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }
            char[] chars = s.ToCharArray();
            if (chars.Length > 0)
            {
                List<long> listResult = new List<long>();

                string result = chars[0].ToString();
                for (int i = 1; i < chars.Length; i++)
                {
                    if (!result.Contains(chars[i]))
                    {
                        result += chars[i];
                    }
                    else
                    {
                        listResult.Add(result.Length);
                        result = chars[i].ToString();
                    }
                }

                return listResult.Max(x => x);
            }
            return 0;
        }

        internal static long Solution1a(string s)
        {
            // Type your solution here 
            if (string.IsNullOrEmpty(s))
            {
                return 0;
            }
            char[] chars = s.ToCharArray();

            var temp = new List<char>();

            if (chars.Length > 0)
            {
                List<long> listResult = new List<long>();

                string result = chars[0].ToString();
                for (int i = 0; i < chars.Length; i++)
                {
                    if (isDuplicate(chars[i], temp)) // (!result.Contains(chars[i]))
                    {
                        //result += chars[i];
                        temp.Add(chars[i]);
                    }
                    else
                    {
                        listResult.Add(temp.Count);
                        temp.Add(chars[i]);
                    }
                }//

                return listResult.Max(x => x);
            }
            return 0;
        }

        private static bool isDuplicate(char c, List<char> chars)
        {
            for (int i = 0; i < chars.Count; i++)
            {
                if (char.Equals(chars[i], c))
                {
                    return true;
                }
            }
            return false;
        }

        private static bool isDup(char c, string s)
        {
            char[] chars = s.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                if (string.Equals(chars[i], c))
                {
                    return true;
                }
            }
            return false;
         }

        public static long[] Solution2(double[] prices)
        {
            long[] roundedPrices = new long[prices.Length];
            long[] result = new long[prices.Length];

            for (int i = 0; i < prices.Length; i++)
            {
                roundedPrices[i] = (long)Math.Round(prices[i]);
            }

            var totalPrices = prices.Select(x => x).Sum();
            var totalRoundedPrices = roundedPrices.Select(x => x).Sum();

            var dif = Math.Abs(totalRoundedPrices - totalPrices);

            for (int i = 0; i < prices.Length; i++)
            {
                var currentPrice = prices[i];
                var currentDecimal = currentPrice - Math.Truncate(currentPrice);
                if (currentDecimal <= dif)
                {
                    result[i] = (long)Math.Ceiling(currentPrice);
                    dif -= currentDecimal;
                }
                else
                {
                    result[i] = (long)Math.Floor(prices[i]);
                }
            }

            return result;
        }

        public static long[] Solution2a(double[] prices)
        {
            long[] result = new long[prices.Length];

            int maxIndex = 0;
            double max = 0.0;

            for (int i = 0; i < prices.Length; i++)
            {
                var currentPrice = prices[i];
                var currentDecimal = currentPrice - Math.Truncate(currentPrice);
                if (currentDecimal > max)
                {
                    maxIndex = i;
                    max = currentDecimal;
                }
            }

            for (int i = 0; i < prices.Length; i++)
            {
                if (i == maxIndex)
                {
                    result[i] = (long)Math.Ceiling(prices[i]);
                }
                else
                {
                    result[i] = (long)Math.Floor(prices[i]);
                }
            }

            return result ;
        }

        public static bool Solution3(long[] numbers, long target)
        {
            if (numbers.Length <= 1)
            {
                return false;
            }

            for (int i = 0; i < numbers.Length; i++)
            {
                long temp = numbers[i];
                var remainingLength = numbers.Length - 1 - i;
                long[] remainNumbers = new long[remainingLength];
                Array.Copy(numbers, i + 1, remainNumbers, 0, remainingLength);
                for (int j = 0; j < remainNumbers.Length; j++)
                {
                    if (temp + remainNumbers[j] == target && temp != target)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}
