using System;
using System.Collections.Generic;
using System.Linq;

namespace A2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*************Amena: question # 1 - INPUTS GO HERE - INITIAL AND FINAL INDEX OF GIVEN TARGET O(N) *************/
            Console.WriteLine("Question 1");
            int[] l1 = new int[] { 5, 6, 6, 9, 9, 12 };
            int target = 6;
            int[] r = TargetRange(l1, target);
            DisplayArray(r);
            Console.WriteLine("\n");
            Console.WriteLine("\n");


            /***************** Amena : question # 4 SORT STRING IN DECREASING ORDER OF FREQUENCY ****************/
            Console.WriteLine("Question 4");
            string s2 = "-1-14";
            string sortedString = FreqSort(s2);
            Console.WriteLine(sortedString);
            Console.WriteLine("\n");
            Console.WriteLine("\n");




            Console.WriteLine("Question 5-Part 1");
            int[] nums1 = { 1, 2, 2, 1 };
            int[] nums2 = { 2, 2 };
            int[] intersect1 = Intersect1(nums1, nums2);
            for (int i = 0; i < intersect1.Length; i++)
            {
                Console.WriteLine(intersect1);
            }
            Console.WriteLine("\n");

            Console.WriteLine("Question 5-Part 2");
            int[] intersect2 = Intersect2(nums1, nums2);
            //Console.WriteLine("Part 2- Intersection of two arrays is: ");
            //DisplayArray(intersect2);
            for (int i = 0; i < intersect2.Length; i++)
            {
                Console.WriteLine(intersect2);
            }
            Console.WriteLine("\n");

            Console.WriteLine("Question 6");
            char[] arr = new char[] { 'a', 'g', 'h', 'a' };
            int k = 3;
            Console.WriteLine(ContainsDuplicate(arr, k));

            Console.WriteLine("Question 7");
            int rodLength = 4;
            int priceProduct = GoldRod(rodLength);
            Console.WriteLine(priceProduct);

            /******************** Amena: question #8 Inputs go here ********************/
            Console.WriteLine("Question 8");
            string[] userDict = new string[] { "rocky", "usf", "hello", "apple" };
            string keyword = "vpple";
            Console.WriteLine(DictSearch(userDict, keyword));
            Console.WriteLine("\n");
            Console.WriteLine("\n");

            /****************** Amena: question # 9 Inputs go here ******************/
            Console.WriteLine("Question 9");
            string i1 = "uber";
            string i2 = "cool";
            string op = "uncle";
            SolvePuzzle(i1, i2, op);


        }

        public static void DisplayArray(int[] a)
        {
            foreach (int n in a)
            {
                Console.Write(n + " ");
            }
        }

        /************************** question no. 1 code **************************/
        /* LOGIC - - initialize start and end index and a flag to declare when the start is found
         * run a loop to traverse through the array lookng for the target
         * update the start index and flag the first time target is found
         * if start found flag is already 1 and target is matching with the array element,
         * keep updating and looking for target till the end of loop
         */
        public static int[] TargetRange(int[] l1, int target)
        {
            /*initializing st and end index and a flag to indicate when the start index is found
             */
            int st_index = -1;
            int end_index = -1;
            int st_found = 0;

            try
            {             /*the for loop traverses through each element looking for the target*/
                for (int i = 0; i < l1.Length; i++)
                {
                    /*the first time the target is found, st found==0 and is incremented to 1 which indicates st found 
                     st index takes the corresponding index value - st found==0 condition ensures our st index isn't changed once found*/
                    if (l1[i] == target && st_found == 0)
                    {
                        st_index = i;
                        st_found = 1;
                    }
                    /*once st is found, all we have to do is keep updating the end index with traversal index
                     until the time it matches the target*/
                    if (l1[i] == target && st_found == 1)
                    {
                        end_index = i;
                    }
                }
                /*initialize an array for output and return - if st and end index aren't found, the default values of -1,-1 will
                 * be passsed automatically */
                int[] output = { st_index, end_index };
                return output;
            }//end of try
            catch
            {
                Console.WriteLine("error occured computing targetrange");
                return null;
            }
        }//end of targetrange program
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
        /************************** question no. 4 code **************************/
        /**sorting the given string in decreasing order of frequency of occurrence of each character.
         * start with initializing a dict and sorted string
         * for the input string s, loop through each character and insert it as a key and value=1
         * if the character already exists in the dictionary, just increment its value by 1 (frequecy of the character)
         * sort the dictionary based on its values
         *While loop -  based on each value of sorted dictionary, repeat the character and concatenate to string
            **/
        public static string FreqSort(string s)
        {
            Dictionary<string, int> dict = new Dictionary<string, int>();
            string sortedstring = "";
            try
            {
                for (int i = 0; i < s.Length; i++)
                { /* if key not found add that key value else increment the value to show alphabet count*/
                    if (dict.ContainsKey(s[i].ToString()) == false)
                    {
                        dict.Add(s[i].ToString(), 1);
                    }
                    else
                    {
                        dict[s[i].ToString()] += 1;
                    }
                }
                //ordering the dictionary by values - loop runs through each order pair
                foreach (KeyValuePair<string, int> d in dict.OrderByDescending(key => key.Value))
                {
                    int a = 0;
                    //depending on each value (going on from biggest) the while loop runs to repeat the key "value times"
                    //and put it in the sorted string
                    while (a < d.Value)
                    {
                        sortedstring += d.Key;
                        a += 1;
                    }
                }
                return sortedstring;
            }
            catch
            {
                Console.WriteLine("error occured during computing question 4");
                return null;
            }
        }//end of FreqSort function

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


        /************************** question no. 8 code *******************/
        /** find whether just changing one character in the keyword will make it a word from the dictionary
         * initialize variable to keep count of differences - different
         * initialize keyword length variable
         * for each word in the user dictionary given, start with different=0
         * quick check - if the current word in user dict length is equal to the length of keyword and its not equal to keyword, proceed
         * 
         * **/
        public static bool DictSearch(string[] userDict, string keyword)
        {
            try
            {
                int different = 0;//counter to set how many alphabets are different between dictionary word and keyword if its exactly one return true else false
                int keyword_length = keyword.Length;
                /*for loop traverses through each element in a dictionary to compare it to keyword and check*/
                for (int i = 0; i < userDict.Length; i++)
                {/*if the length of keyword matches the length of a word in the dictionary-consider it*/
                    different = 0;
                    /*if keyword length matches dictionary word length and the word isnt exactly the same, theres a probability
                     that if we change an alphabet the word can be fixed else return false*/
                    if (userDict[i].Length == keyword_length && userDict[i] != keyword)
                    {
                        for (int x = 0; x < userDict[i].Length; x++)// /*for loop to compare each alphabet*/
                        {
                            if (userDict[i][x] != keyword[x]) /*increment the different variable if locked word alphabet is different from keyword alphabet*/
                            {
                                different += 1;
                            }
                            if (different > 1)//break through the loop cause there's no point in traversing
                            {
                                break;
                            }
                        }
                    }
                    if (different == 1)
                    {
                        return true;
                    }
                }//end of first for loop
            }//end of try
            catch (Exception)
            {
                throw;
            }
            return default;
        }//end of DictSearch method


        /*******    question # 9 functions and methods ******/

        /*function to load the inputs and output to a dictionary callled assignments 
         its called assignments cause we will be making final assignments to this
         this will also be used to cater for a corner case*/
        public static Dictionary<char, int> Populate_unique_alpabets(string i1, string i2, string op)
        {
            //to contain all the unique alphabets and their assignments
            Dictionary<char, int> assignments = new Dictionary<char, int>();
            /*populating dictionary with unique alphabets - op first so that first char has to be 1
             * no matter what - this way we save one whole nested loop recursion and hence time - that will
             * be shown in main solve puzzle function
             * */
            string x = op + i1 + i2;
            /*run a loop to iterate through the combo of 3 strings x
             if the alphabet doesnt exist in dictionary assignments, add it 
             else move on to next iteration*/
            for (int a = 0; a < (i2.Length + i1.Length + op.Length); a++)
            {
                if (assignments.ContainsKey(x[a]) == false)
                {
                    assignments[x[a]] = x[a];
                }
            }
            /*return the populated dictionary*/
            return assignments;
        }


        /**********       recursive function - heart of the program ***********/
        /**takes start (which is initially passed 1 since no number can start with 0 and hence we dont want our first loop to waste time on 0s
         * depth keeps a check on each level down we go (max dept can be 10 since available digits to play with)
         * s is empty string - which will be storing probable solution assignments for our final solution - sequential assignment for each unique alphabet in assignments
         * assignments dictionary is only passed so we can use it to assign values to the keys in the assign_numbers function
         * string i1,i2,op are input and output strings- main puzzle- they're only used in the problem_solved function to decode what number the two inputs and output represent
         */
        static void Recursionfunction(int start, int depth, int maxdepth, int iterationend, String s, Dictionary<char, int> assignments, string i1, string i2, string op)
        {
            try
            {
                /**start with solved bool==false (defaultstate) so that we can change it to true and get out of the recursion */
                bool solved = false;
                /**this loop will become a nested version of itself via recursion and shall traverse through each digit from 0-10 (except in 1st run its 1)*/
                for (int a = start; a < iterationend; a++)
                {
                    /*if string length>assignments dictionary with unique letter inside (we have found probable assignments for alphabets)
                     * - that string is ready to be tested as a  solution
                     *put the assigned values in this variable assignments (assign_numbers)
                     * call the function to check whether this is indeed our required solution (problem solve)
                     *if solved is returned true - output the solution and exit the program*/
                    if (s.Length >= assignments.Count)
                    {
                        assignments = assign_numbers(s, assignments);
                        solved = problemsolve(assignments, i1, i2, op);
                        if (solved == true)
                        {
                            return;
                        }

                    }

                    /*if you're at max depth, no need to call recursion again  
                     * check whether a is already part of the string or not - only add if its not (dont want duplicate assignments)
                     * if this is not first iteration of the current loop, delete the character previously added and then add the new one
                     */
                    if (depth == maxdepth - 1 && a > 0 && s.Contains(a.ToString()) == false)
                    {
                        s = s.Substring(0, depth);
                        s += a.ToString();
                    }
                    /*if its the first iteration of the current loop - depicted by a=0, directly add the digit a to string s as a character*/
                    if (depth == maxdepth - 1 && a == 0 && s.Contains(a.ToString()) == false)
                    {
                        s += a.ToString();
                    }
                    /*if you're not at max depth, call recursion again, to solve for the next blank
                     * depth +1 to track that we are going to the next level
                     * if not the first iteration - delete the last addded character and then add the current digit as character*/
                    if (depth < maxdepth - 1 && a > 0 && s.Contains(a.ToString()) == false)
                    {
                        s = s.Substring(0, depth);
                        s += a.ToString();
                        Recursionfunction(0, depth + 1, maxdepth, iterationend, s, assignments, i1, i2, op);
                    }
                    /*if its the first iteration of the current loop - depicted by a=0, directly add the digit a to string s as a character*/
                    if (depth < maxdepth - 1 && a == 0 && s.Contains(a.ToString()) == false)
                    {
                        s += a.ToString();
                        Recursionfunction(0, depth + 1, maxdepth, iterationend, s, assignments, i1, i2, op);
                    }
                }//end of for loop
            }//end of try
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

        /*         *********        assign numbers function          ***************
         *         send the probable answer (as store answer) and the assignment dictionary to assign values to
         *         returns the nicely populated with assigned values dictionary
         */
        public static Dictionary<char, int> assign_numbers(string store_answer, Dictionary<char, int> assignments)
        {
            //convert string to character array
            char[] ans_char_array = store_answer.ToCharArray();
            char x;
            /*run a loop through the assignments dictionary
             *store the key at each index in x
             * remove that key (since you wont be able to override its value
             * add that key with the corresponding int(its a character in the character array but we convert it to int by parsing)
             * back into the dictionary - viola you haev all your keys and corresponding values
             */
            for (int a = 0; a < assignments.Count; a++)
            {
                x = assignments.ElementAt(a).Key;
                assignments.Remove(x);
                assignments.Add(x, Int32.Parse(ans_char_array[a].ToString()));
            }
            return assignments;
        }//end of assign numbers




        /**************************     problem solve method ************************************
         * checks whether the assigned numbers solved the problem puzzle or not
         takes the assignments , both the inputs and the output
         makes a bool variable solved with default state false - if assignments and solution is correct make it true
         initialize power, 3 integers to store corresponding numerical values for each string input/output
         */
        public static bool problemsolve(Dictionary<char, int> assignments, string i1, string i2, string op)
        {
            bool solved = false;
            int pow = 0;
            int a_ip1 = 0;
            int b_ip2 = 0;
            int c_op = 0;

            //translating  the three words into the 3 numbers one by one 
            /*for each character in the string, start with the right most (that depicts 10s)
             * add it to the corresponding integer variable -a_ip1 for first input
             * increase the power by 1 (units to 10s, tens to hundereds and hundereds to thousands and so on)
             * gives the sum (integer) depicting the word
             */
            for (int x = i1.Length - 1; x >= 0; x--)
            {
                a_ip1 += Convert.ToInt32(assignments[i1[x]] * Math.Pow(10, pow));
                pow++;
            }

            /*set power back to 0 (to get units) before starting it for next word */
            pow = 0;
            for (int x = i2.Length - 1; x >= 0; x--)
            {
                b_ip2 += Convert.ToInt32(assignments[i2[x]] * Math.Pow(10, pow));
                pow++;
            }


            pow = 0;
            for (int x = op.Length - 1; x >= 0; x--)
            {
                c_op += Convert.ToInt32(assignments[op[x]] * Math.Pow(10, pow));
                pow++;
            }
            /*if sum of the two input integers depicted by words == output depicted by words - we have found the solution
             *display it 
             return true*/
            if (a_ip1 + b_ip2 == c_op)
            {
                solved = true;
                Console.WriteLine(i1 + "  " + a_ip1);
                Console.WriteLine(i2 + "  " + b_ip2);
                Console.WriteLine(op + "  " + c_op);
                foreach (KeyValuePair<char, int> item in assignments)
                {
                    Console.Write("{0}={1}  ", item.Key.ToString().ToUpper(), item.Value);
                }
            }
            return solved;
        }


        /****************  Solve puzzle method      ********************/
        /* display the inputs first
         * populate unique alphabets
         * initialize depth and max depth
         * check for corner case
         * start the recursion
         */
        public static void SolvePuzzle(string i1, string i2, string op)
        {
            try
            {
                Console.WriteLine("input1 is: " + i1);
                Console.WriteLine("input2 is: " + i2);
                Console.WriteLine("output is: " + op);

                /** step1 **/ //call function to populate distinct alphabets.
                Dictionary<char, int> assignments = Populate_unique_alpabets(i1, i2, op);
                //initialize variable depth to keep a track of how deep we are inside the recursive loops and when to stop recursion
                int depth = 0;
                //this is based on the fact that each alphabet can take a max of 10 values (0,1,2,3,4,5,6,7,8,9)
                int maxdepth = assignments.Count;
                int iterationend = 10;
                /*handling the corner case of more than 10 unique alphabets - since only 1 digit is allowed
                per alphabet and no repetitions - and we have total 10 single length digits in maths*/
                if (assignments.Count > 10)
                {
                    Exception ex = new Exception("unique alphabets are more than 10");
                    throw ex;
                }
                /** step2 - start recursion
                 * initialize an empty string s which will store all the probable values for the answer
                 * and unique alphabets assignment**/
                string s = "";
                /*pass start as 1 since no number is allowed to be started with a zero 
                and since our unique assignments always has the
                answer as first number 1 so start first loop by 1 and remaining can be 0*/
                Recursionfunction(1, depth, maxdepth, iterationend, s, assignments, i1, i2, op);
            }//end of try

            catch (Exception)
            {
                Console.WriteLine();
            }
        }//end of solvepuzzle


    }
}
