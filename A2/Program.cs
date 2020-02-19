using System;
using System.Collections.Generic;

namespace A2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Question 1");
            int[] l1 = new int[] { 5, 6, 6, 9, 9, 12 };
            int target = 9;
            int[] r = TargetRange(l1, target);
            // Write your code to print range r here

            Console.WriteLine("Question 2");
            string s = "University of South Florida";
            string rs = StringReverse(s);
            Console.WriteLine(rs);

            Console.WriteLine("Question 3");
            int[] l2 = new int[] { 2, 2, 3, 5, 6 };
            int sum = MinimumSum(l2);
            Console.WriteLine(sum);

            Console.WriteLine("Question 4");
            string s2 = "Dell";
            string sortedString = FreqSort(s2);
            Console.WriteLine(sortedString);

            Console.WriteLine("Question 5-Part 1");
            int[] nums1 = { 1, 2, 2, 1 };
            int[] nums2 = { 2, 2 };
            int[] intersect1 = Intersect1(nums1, nums2);
            for(int i = 0; i < intersect1.Length; i++)
            {
                Console.WriteLine(intersect1);
            }
            //Console.WriteLine("Part 1- Intersection of two arrays is: ");
            //DisplayArray(intersect1);
            Console.WriteLine("\n");

            Console.WriteLine("Question 5-Part 2");
            int[] intersect2 = Intersect2(nums1, nums2);
            //Console.WriteLine("Part 2- Intersection of two arrays is: ");
            //DisplayArray(intersect2);
            for(int i = 0; i < intersect2.Length; i++)
            {
                Console.WriteLine(intersect2);
            }
            Console.WriteLine("\n");

            Console.WriteLine("Question 6");
            char[] arr = new char[] { 'a', 'g', 'h', 'a' };
            int k = 3;
            Console.WriteLine(ContainsDuplicate(arr, k));

            Console.WriteLine("Question 7");
            int rodLength = 10;
            int priceProduct = GoldRod(rodLength);
            Console.WriteLine(priceProduct);

            Console.WriteLine("Question 8");
            string[] userDict = new string[] { "rocky", "usf", "hello", "apple" };
            string keyword = "hhllo";
            Console.WriteLine(DictSearch(userDict, keyword));

            Console.WriteLine("Question 8");
            SolvePuzzle();
        }

        public static void DisplayArray(int[] a)
        {
            foreach (int n in a)
            {
                Console.Write(n + " ");
            }
        }
        public static int[] TargetRange(int[] l1, int t)
        {
            try
            {
                //Write your code here;
            }
            catch (Exception)
            {
                throw;
            }
            return new int[] { };
        }
        public static string StringReverse(string s)
        {
            try
            {
                //write your code here
            }
            catch (Exception)
            {
                throw;
            }
            return null;
        }
        public static int MinimumSum(int[] l2)
        {
            try
            {
                //Write your code here;
            }
            catch (Exception)
            {
                throw;
            }
            return 0;
        }
        public static string FreqSort(string s2)

        {
            try
            {
                //Write Your Code Here
            }
            catch (Exception)
            {
                throw;
            }
            return null;
        }
        public static int[] Intersect1(int[] nums1, int[] nums2)
        {
            try
            {
                List<int> ls =

                      new List<int>();



                for (int i = 0; i < nums1.Length; i++)

                    ls.Add(nums1[i]);



                for (int i = 0; i < nums2.Length; i++)

                    if (ls.Contains(nums2[i]))

                        Console.Write(nums2[i] + " ");
            }
            catch
            {
                throw;
            }
            return new int[] { };
        }
        public static int[] Intersect2(int[] nums1, int[] nums2)
        {
            try
            {
                Array.Sort(nums1);

                Array.Sort(nums2);

                int i = 0, j = 0;



                while (i < nums1.Length && j < nums2.Length)

                {

                    if (nums1[i] < nums2[j])

                        i++;

                    else if (nums2[j] < nums1[i])

                        j++;

                    else

                    {

                        Console.Write(nums2[j++] + " ");

                        i++;

                    }

                }
            }
            catch
            {
                throw;
            }
            return new int[] { };
        }
        public static bool ContainsDuplicate(char[] arr, int k)
        {
            try
            {

                Dictionary<char, int> dict = new Dictionary<char, int>();

                for (int i = 0; i < arr.Length; i++)

                {

                    if (dict.ContainsKey(arr[i]))

                    {

                        if (i - dict[arr[i]] <= k)

                        {

                            return true;

                        }

                    }

                    else

                        dict[arr[i]] = i;

                }//for i

                return false;

            }
            catch (Exception)
            {
                throw;
            }
        }

        public static int GoldRod(int rodLength)
        {
            if (rodLength == 2) return 1;
            if (rodLength == 3) return 2;
            if (rodLength == 4) return 4;

            return Program.GetRodMax(rodLength);
        }

        public static int GetRodMax(int rodLength)
        {
            if (rodLength == 2) return 2;
            if (rodLength == 3) return 3;
            if (rodLength == 4) return 4;
            return 3 * Program.GetRodMax(rodLength - 3);
        }

        public static bool DictSearch(string[] userDict, string keyword)
        {
            try
            {
                //Write Your Code Here
            }
            catch (Exception)
            {
                throw;
            }
            return default;
        }
        public static void SolvePuzzle()
        {
            try
            {
                //Write Your Code Here
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
