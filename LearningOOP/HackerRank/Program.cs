using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace HackerRank
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Algorithm

            #region Triplets
            //List<int> a = new List<int> { 1, 2, 4 }; //Console.ReadLine().TrimEnd().Split(' ').ToList().Select(aTemp => Convert.ToInt32(aTemp)).ToList(); 

            //List<int> b = new List<int> { 3, 2, 1 };  //Console.ReadLine().TrimEnd().Split(' ').ToList().Select(bTemp => Convert.ToInt32(bTemp)).ToList();

            //List<int> result = Ex1.compareTriplets(a, b);

            //Console.WriteLine(String.Join(" ", result)); 
            #endregion

            #region Diagonal

            //Console.WriteLine("the number of line: ");
            //int n = Convert.ToInt32(Console.ReadLine().Trim());

            //List<List<int>> arr = new List<List<int>>();

            //for (int i = 0; i < n; i++)
            //{
            //    arr.Add(Console.ReadLine().TrimEnd().Split(' ').ToList().Select(arrTemp => Convert.ToInt32(arrTemp)).ToList());
            //}

            //Console.WriteLine("the matrix is: ");
            //for (int i = 0; i < arr.Count; i++)
            //{
            //    var line = string.Empty;
            //    for (int j = 0; j < arr[i].Count; j++)
            //    {
            //        line = j == 0 ? arr[i][j].ToString() : line + " " + arr[i][j];
            //    }
            //    Console.WriteLine(line);
            //}

            //Console.WriteLine(string.Format("The value is: {0}", Ex1.diagonalDifference(arr)));

            #endregion

            #region Plus Minus
            //    Console.WriteLine("Enter the Array sepereated by the space: ");
            //    int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp))
            //;
            //    Ex1.plusMinus(arr);
            #endregion

            #region Staircase

            //Console.WriteLine("Enter the number of step (min/max: 0/20)");
            //Ex1.validate(Console.ReadLine());

            #endregion

            #region Mini-Max Sum

            //int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            //Ex1.miniMaxSum(arr);

            #endregion

            #region Birthday Cake Candles

            //int arCount = Convert.ToInt32(Console.ReadLine());

            //int[] ar = Array.ConvertAll(Console.ReadLine().Split(' '), arTemp => Convert.ToInt32(arTemp));
            //int result = Ex1.birthdayCakeCandles(ar);

            //Console.WriteLine(string.Format("The number of the highest candle is: {0}", result));

            #endregion

            #region Time Conversion

            //string s = Console.ReadLine();

            //string result = Ex1.timeConversion(s);

            //Console.WriteLine(result);

            #endregion

            #region Cats and a Mouse

            //int q = Convert.ToInt32(Console.ReadLine());

            //for (int qItr = 0; qItr < q; qItr++)
            //{
            //    string[] xyz = Console.ReadLine().Split(' ');

            //    int x = Convert.ToInt32(xyz[0]);

            //    int y = Convert.ToInt32(xyz[1]);

            //    int z = Convert.ToInt32(xyz[2]);

            //    string result = Algorithm.catAndMouse(x, y, z);

            //    Console.WriteLine(result);
            //}

            #endregion

            #region getMAX

            //int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            //Console.WriteLine(Algorithm.getMax(arr));

            #endregion

            #region Binary

            //long[] arr = { 1, 4, 100, 5 };
            //Console.WriteLine(Test.Solution(arr));

            #endregion

            #endregion

            #region Data Structures

            //int arrCount = Convert.ToInt32(Console.ReadLine());

            //int[] arr = Array.ConvertAll(Console.ReadLine().Split(' '), arrTemp => Convert.ToInt32(arrTemp));
            //int[] res = DataStructures.reverseArray(arr);

            //Console.WriteLine(string.Join(" ", res));

            #endregion

            #region Challenge

            //Console.WriteLine("a".Contains("A"));

            Console.WriteLine(Axon.Solution1a("tadbnhAsTt"));

            //Console.WriteLine(Axon.Solution3(new long[] { 7, -1, 1, 5 }, 7));

            //Console.WriteLine(Axon.Solution2(new double[] { 5.4, 3.3, 5.0 }));

            #endregion

        }
    }
}
