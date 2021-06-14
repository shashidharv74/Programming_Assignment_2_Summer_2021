using System;
using System.Collections.Generic;
using System.Linq;

namespace Programming_Assignment_2_Summer_2021
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question1:
            Console.WriteLine("Question 1");
            int[] nums1 = { 2, 5, 1, 3, 4, 7 };
            int[] nums2 = { 2, 1, 4, 7 };
            Intersection(nums1, nums2);
            Console.WriteLine("");

            //Question 2 
            Console.WriteLine("Question 2");
            int[] nums = { 1, 3, 5, 6 };
            //int[] nums = { 0, 1, 0, 3, 12 };
            Console.WriteLine("Enter the target number:");
            int target = Int32.Parse(Console.ReadLine());
            int pos = SearchInsert(nums, target);
            Console.WriteLine("Insert Position of the target is : {0}", pos);
            Console.WriteLine("");

            //Question3
            Console.WriteLine("Question 3");
           // int[] ar3 = { 1, 2, 3, 1, 1, 3 };
            int[] ar3 = { 2, 2, 3, 4 };
        int Lnum = LuckyNumber(ar3);
            if (Lnum == -1)
                Console.WriteLine("Given Array doesn't have any lucky Integer");
            else
                Console.WriteLine("Lucky Integer for given array is: {0}", Lnum);

            Console.WriteLine();

            //Question 4
            Console.WriteLine("Question 4");
            Console.WriteLine("Enter the value for n:");
            int n = Int32.Parse(Console.ReadLine());
            int Ma = GenerateNums(n);
            Console.WriteLine("Maximun Element in the Generated Array is {0}", Ma);
            Console.WriteLine();

            //Question 5

            Console.WriteLine("Question 5");
            List<List<string>> cities = new List<List<string>>();
            cities.Add(new List<string>() { "London", "New York" });
            cities.Add(new List<string>() { "New York", "Tampa" });
            cities.Add(new List<string>() { "Delhi", "London" });
            string Dcity = DestCity(cities);
            Console.WriteLine("Destination City for Given Route is : {0}", Dcity);

            Console.WriteLine();

            //Question 6
            Console.WriteLine("Question 6");
            int[] Nums = { 2, 7, 11, 15 };
            int target_sum = 9;
            targetSum(Nums, target_sum);
            Console.WriteLine();

            //Question 7
            Console.WriteLine("Question 7");
            int[,] scores = { { 1, 91 }, { 1, 92 }, { 2, 93 }, { 2, 97 }, { 1, 60 }, { 2, 77 }, { 1, 65 }, { 1, 87 }, { 1, 100 }, { 2, 100 }, { 2, 76 } };
            HighFive(scores);
            Console.WriteLine();

            //Question 8
            Console.WriteLine("Question 8");
            int[] arr = { 1, 2, 3, 4, 5, 6, 7 };
            int K = 3;
            RotateArray(arr, K);

            Console.WriteLine();

            //Question 9
            Console.WriteLine("Question 9");
            int[] arr9 = { 7, 1, 5, 3, 6, 4 };
            int Ms = MaximumSum(arr9);
            Console.WriteLine("Maximun Sum contiguous subarray {0}", Ma);
            Console.WriteLine();

            //Question 10
            Console.WriteLine("Question 10");
            int[] costs = { 10, 15, 20 };
            int minCost = MinCostToClimb(costs);
            Console.WriteLine("Minium cost to climb the top stair {0}", minCost);
            Console.WriteLine();
        }

        //Question 1
        /// <summary>
        //Given two integer arrays nums1 and nums2, return an array of their intersection.
        //Each element in the result must be unique and you may return the result in any order.
        //Example 1:
        //Input: nums1 = [1,2,2,1], nums2 = [2,2]
        //Output: [2]
        //Example 2:
        //Input: nums1 = [4,9,5], nums2 = [9,4,9,8,4]
        //Output: [9,4]
        //
        /// </summary>

        public static void Intersection(int[] nums1, int[] nums2)
        {
            try
            {
                HashSet<int> inter=new HashSet<int>();//declare hashset to hold unique pair of numbers
                for(int i=0; i < nums1.Length; i++)//traverse till end of nums1 array
                {
                    for(int j = 0; j < nums2.Length; j++)//traverse till end of nums2 array
                    {
                        if (nums1[i] == nums2[j])//if same number exist in both nums1 and nums2 array
                        {
                            inter.Add(nums1[i]); //add that number in hashset inter
                        }
                    }
                }
                Console.WriteLine(string.Join(",", inter));//print the unique values which exist in both array
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 2:
        /// <summary>
        //Given a sorted array of distinct integers and a target value, return the index if the target is found.If not, return the index where it would be if it were inserted in order.
        //Note: You must write an algorithm with O(log n) runtime complexity.
        //Example 1:
        //Input: nums = [1, 3, 5, 6], target = 5
        //Output: 2
        //Example 2:
        //Input: nums = [1, 3, 5, 6], target = 2
        //Output: 1
        //Example 3:
        //Input: nums = [1, 3, 5, 6], target = 7
        //Output: 4
        //Example 4:
        //Input: nums = [1, 3, 5, 6], target = 0
        //Output: 0
        /// </summary>

        public static int SearchInsert(int[] nums, int target)
        {
            try
            {
                int low = 0; //holds low value 
                int high = nums.Length - 1; //holds high value
                int index = 0; //holds index
                int pos = 0; //to hold position
                while(low <= high) //traverse till low is less than high
                {
                    index++; //increment the index
                    var mid = (low + high) / 2; // calculate the mid of the array
                    if (target == nums[mid]) //if the target is found at mid
                    {
                        Console.WriteLine("Target found at:{0}",index); //print index of mid
                        return index;
                    }
                    else if (target < nums[mid])//if value of target is less than the number present at mid
                    {
                        high = mid - 1; //change high to hold mid-1
                    }
                    else //if target is greater than number present at the mid of array
                        low = mid + 1; //change low to start from mid+1
                    for (int i = 0; i < nums.Length; i++) //starting from first number in array traverse right
                    {
                        if (target > nums[i])//compare target with the next number present in the array
                        {
                            pos = i+1;//position where the target should be inserted would be i+1
                        }
                    }
                    return pos; //print the position where the target should be inserted if not found
                }
                return -1;
            }
            catch (Exception)
            {
                throw;
            }
        }


        //Question 3
        /// <summary>
        //Given an array of integers arr, a lucky integer is an integer which has a frequency in the array equal to its value.
        //Return a lucky integer in the array. If there are multiple lucky integers return the largest of them. If there is no lucky integer return -1.
        //Example 1:
        //Input: arr = [2, 2, 3, 4]
        //Output: 2
        //Explanation: The only lucky number in the array is 2 because frequency[2] == 2.
        /// </summary>

        private static int LuckyNumber(int[] nums)
        {
            try
            {
                var luckyNumber = new int[500];
                foreach(var n in nums)//for all numbers in array nums
                {
                    luckyNumber[n]++;//calculate frequency of the number
                }
                for(int i = nums.Length; i > 0; i--)//starting from the end
                {
                    if (luckyNumber[i] == i)//if the frequency is equal to the value of the number
                    {
                        return i;//print the number
                    }
                }
                return -1;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 4:
        /// <summary>
        //You are given an integer n.An array nums of length n + 1 is generated in the following way:
        //•	nums[0] = 0
        //•	nums[1] = 1
        //•	nums[2 * i] = nums[i]  when 2 <= 2 * i <= n
        //•	nums[2 * i + 1] = nums[i] + nums[i + 1] when 2 <= 2 * i + 1 <= n
        // Return the maximum integer in the array nums.

        //Example 1:
        //Input: n = 7
        //Output: 3
        //Explanation: According to the given rules:
        //nums[0] = 0
        //nums[1] = 1
        //nums[(1 * 2) = 2] = nums[1] = 1
        //nums[(1 * 2) + 1 = 3] = nums[1] + nums[2] = 1 + 1 = 2
        //nums[(2 * 2) = 4] = nums[2] = 1
        //nums[(2 * 2) + 1 = 5] = nums[2] + nums[3] = 1 + 2 = 3
        //nums[(3 * 2) = 6] = nums[3] = 2
        //nums[(3 * 2) + 1 = 7] = nums[3] + nums[4] = 2 + 1 = 3
        //Hence, nums = [0, 1, 1, 2, 1, 3, 2, 3], and the maximum is 3.

        /// </summary>
        private static int GenerateNums(int n)
        {
            try
            {
                if (n > 0)
                {
                    int max = 1;
                    int len = n + 1;//length of the array would be input value + 1
                    int[] nums = new int[len]; //declare an array which is of length n+1
                    nums[0] = 0;
                    nums[1] = 1;
                    for (int i = 1; i < len / 2; i++) //traverse till half of the length of array
                    {
                        nums[(2 * i)] = nums[i];
                        nums[(2 * i) + 1] = nums[i] + nums[i + 1];
                        max = Math.Max(max, nums[(2 * i)]); //calculate max by comparing current max with when nums[(2 * i)]
                        max = Math.Max(max, nums[(2 * i) + 1]);//calculate max by comparing current max with when nums[(2 * i) + 1]
                    }
                    return max; //print max in the array
                }
                return -1;
            }
            catch (Exception)
            {

                throw;
            }

        }

        //Question 5
        /// <summary>
        //You are given the array paths, where paths[i] = [cityAi, cityBi] means there exists a direct path going from cityAi to cityBi.Return the destination city, that is, the city without any path outgoing to another city.
        //It is guaranteed that the graph of paths forms a line without any loop, therefore, there will be exactly one destination city.
        //Example 1:
        //Input: paths = [["London", "New York"], ["New York","Lima"], ["Lima","Sao Paulo"]]
        //Output: "Sao Paulo" 
        //Explanation: Starting at "London" city you will reach "Sao Paulo" city which is the destination city.Your trip consist of: "London" -> "New York" -> "Lima" -> "Sao Paulo".
        /// </summary>
        public static string DestCity(List<List<string>> paths)
        {
            try
            {
                List<string> newlist = new List<string>();
                foreach (var path in paths)
                {
                    newlist.Add(path[1]); //add all cities to the list
                }
                foreach (var path in paths)
                {
                    if (newlist.Contains(path[0]))//check if the city is already present in previous position in list
                    {
                        newlist.Remove(path[0]);//remove if present
                    }
                }
                return newlist.Last();//return the last value from the list
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Question 6:
        /// <summary>
        //Given an array of integers numbers that is already sorted in non-decreasing order, find two numbers such that they add up to a specific target number.
        //Print the indices of the two numbers (1-indexed) as an integer array answer of size 2, where 1 <= answer[0] < answer[1] <= numbers.Length.
        //You may not use the same element twice, there will be only one solution for a given array
        //Example 1:
        //Input: numbers = [2,7,11,15], target = 9
        //Output: [1,2]
        //Explanation: The sum of 2 and 7 is 9. Therefore index1 = 1, index2 = 2.

        /// </summary>
        private static void targetSum(int[] nums, int target)
        {
            try
            {
                int sum = 0;
                HashSet<int> set = new HashSet<int>();//declare hashset to hold unique values from the sorted input array
                for(int k = 0; k < nums.Length; k++)
                {
                    set.Add(nums[k]); //add all the values from the array to set
                }
                if (nums.Length >= 2 && nums.Length <= (3 * 104))
                {
                    if (sum != target) //traverse till sum is not equal to target
                    {
                        for (int i = 0; i < set.Count; i++)//traverse i till number of values present in set
                        {
                            for (int j = 1; j < set.Count; j++)//traverse j till number of values present in set
                            {
                                if (nums[i] >= -1000 && nums[j] >= -1000 && nums[i] <= 1000 && nums[j] <= 1000)
                                {
                                    sum = nums[i] + nums[j];//calculate the sum
                                    if (sum == target)//if sum equal to target
                                    {
                                        Console.WriteLine(string.Join(",", i + 1, j + 1));//print the index of the values that add upto target
                                        return;
                                    }
                                }
                            }
                        }
                    }
                }
               
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 7
        /// <summary>
        /// Given a list of the scores of different students, items, where items[i] = [IDi, scorei] represents one score from a student with IDi, calculate each student's top five average.
        /// Print the answer as an array of pairs result, where result[j] = [IDj, topFiveAveragej] represents the student with IDj and their top five average.Sort result by IDj in increasing order.
        /// A student's top five average is calculated by taking the sum of their top five scores and dividing it by 5 using integer division.
        /// Example 1:
        /// Input: items = [[1, 91], [1,92], [2,93], [2,97], [1,60], [2,77], [1,65], [1,87], [1,100], [2,100], [2,76]]
        /// Output: [[1,87],[2,88]]
        /// Explanation: 
        /// The student with ID = 1 got scores 91, 92, 60, 65, 87, and 100. Their top five average is (100 + 92 + 91 + 87 + 65) / 5 = 87.
        /// The student with ID = 2 got scores 93, 97, 77, 100, and 76. Their top five average is (100 + 97 + 93 + 77 + 76) / 5 = 88.6, but with integer division their average converts to 88.
        /// Example 2:
        /// Input: items = [[1,100],[7,100],[1,100],[7,100],[1,100],[7,100],[1,100],[7,100],[1,100],[7,100]]
        /// Output: [[1,100],[7,100]]
        /// Constraints:
        /// 1 <= items.length <= 1000
        /// items[i].length == 2
        /// 1 <= IDi <= 1000
        /// 0 <= scorei <= 100
        /// For each IDi, there will be at least five scores.
        /// </summary>
        private static void HighFive(int[,] items)
        {
            try
            {
                List<int[]> list = new List<int[]>();
                List<int[,]> res = new List<int[,]>();
                for (int i = 0; i < items.GetLength(0); i++)
                {
                    list.Add(new int[] { items[i, 0], items[i, 1] }); //add all the score of for every student in list
                }

                list.Sort((p, q) => { return (p[0] < q[0]) ? -1 : ((p[0] == q[0]) ? ((p[1] <= q[1]) ? 1 : -1) : 1); });//sort the list in descending order of marks for each student
                int n = list[0][0];
                int counter = 1;
                int sum = list[0][1];
                for (int i = 1; i < list.Count; i++)
                {
                    if (list[i][0] == n && counter < 5)
                    {
                        sum += list[i][1]; //calculate sum of top 5 marks
                        counter += 1;
                    }
                    else if (list[i][0] != n)
                    {
                        res.Add(new int[,] { { n, sum / 5 } });//calculate the average of those top 5 scores

                        Console.Write("[[" + n + "," + sum / 5 + "]" + ",");
                        n = list[i][0];
                        counter = 1;
                        sum = list[i][1];
                    }
                }
                res.Add(new int[,] { { n, sum / 5 } }); //add results for each student to array
                Console.Write("[" + n + "," + sum / 5 + "]]");//print results for each student
                Console.Write("\n");
            }
            catch (Exception)
            {
                throw;
            }
        }

        //Question 8
        /// <summary>
        //Given an array, rotate the array to the right by k steps, where k is non-negative.
        //Print the Final array after rotation.
        //Example 1:
        //Input: nums = [1, 2, 3, 4, 5, 6, 7], k = 3
        //Output: [5,6,7,1,2,3,4]
        //Explanation:
        //rotate 1 steps to the right: [7,1,2,3,4,5,6]
        //rotate 2 steps to the right: [6,7,1,2,3,4,5]
        //rotate 3 steps to the right: [5,6,7,1,2,3,4]
        //Example 2:
        //Input: nums = [-1,-100,3,99], k = 2
        //Output: [3,99,-1,-100]
        //Explanation: 
        //rotate 1 steps to the right: [99,-1,-100,3]
        //rotate 2 steps to the right: [3,99,-1,-100]
        /// </summary>

        private static void RotateArray(int[] arr, int n)
        {
            try
            {
                int[] res = new int[arr.Length];//declare new array with same length of arr
                int len = arr.Length;//store length of arr in len
                for (int i = 0; i < arr.Length; i++)
                {
                    res[(i + n) % len] = arr[i];//calculate the position of res by mod of the rotation value and i added together with length and place the value present at arr[i] in res
                }
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = res[i];//assign values to arr, in same order as in res
                }
                Console.WriteLine(string.Join(",", arr));//print the array
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 9
        /// <summary>
        //Given an integer array nums, find the contiguous subarray(containing at least one number) which has the largest sum and return its sum
        //Example 1:
        //Input: nums = [-2,1,-3,4,-1,2,1,-5,4]
        //Output: 6
        //Explanation: [4,-1,2,1] has the largest sum = 6.
        //Example 2:
        //Input: nums = [1]
        //Output: 1
        // Example 3:
        // Input: nums = [5,4,-1,7,8]
        //Output: 23
        /// </summary>

        private static int MaximumSum(int[] arr)
        {
            try
            {
                if (arr.Length > 0)
                {
                    int max = 0;
                    for (int i = 0; i < arr.Length; i++)
                    {
                        max += arr[i]; //calculate max sum by adding values in array by while traversing and adding back to max
                    }
                    for (int i = 0; i < arr.Length; i++)
                    {
                        int temp = 0;
                        for (int j = i; j < arr.Length; j++)
                        {
                            temp += arr[j]; //calculate temporary sum while traversing through array
                            if (temp > max)//check if the temporary sum is greater than the entire sum of array
                            {
                                max = temp;//assign the max sum to temporary sum
                            }
                        }
                    }
                    return max;//return the max sum
                }
                return 0;
            }
            catch (Exception)
            {

                throw;
            }
        }

        //Question 10
        /// <summary>
        //You are given an integer array cost where cost[i] is the cost of ith step on a staircase.Once you pay the cost, you can either climb one or two steps.
        //You can either start from the step with index 0, or the step with index 1.
        //Return the minimum cost to reach the top of the floor.
        //Example 1:
        //Input: cost = [10, 15, 20]
        //Output: 15
        //Explanation: Cheapest is: start on cost[1], pay that cost, and go to the top.

        /// </summary>

        private static int MinCostToClimb(int[] costs)
        {
            try
            {
                if (costs.Length > 0)
                {
                    if (costs.Length == 2)
                    {
                        return Math.Min(costs[0], costs[1]);//if there are only 2 steps to climb, calculate min of step 1 and step 2 and return
                    }
                    int length = costs.Length;
                    int[] curCost = new int[length];
                    curCost[0] = costs[0];
                    curCost[1] = costs[1];
                    for (int i = 2; i < length; i++)//traverse till end of array starting from 3rd position
                    {
                        curCost[i] = costs[i] + Math.Min(curCost[i - 1], curCost[i - 2]);//calculate total current cost by adding current cost to the minimum of cost obtained from previous two steps
                    }
                    return Math.Min(curCost[length - 1], curCost[length - 2]);//return the minimum cost
                }
                return 0;

            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
