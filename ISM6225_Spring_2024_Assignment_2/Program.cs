/* 
 
YOU ARE NOT ALLOWED TO MODIFY ANY FUNCTION DEFINIDTION's PROVIDED.
WRITE YOUR CODE IN THE RESPECTIVE QUESTION FUNCTION BLOCK


*/

using System.Text;
using System.Xml.Linq;

namespace ISM6225_Spring_2024_Assignment_2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Question 1:
            Console.WriteLine("Question 1:");
            int[] nums1 = { 0, 0, 1, 1, 1, 2, 2, 3, 3, 4 };
            int numberOfUniqueNumbers = RemoveDuplicates(nums1);
            Console.WriteLine(numberOfUniqueNumbers);

            //Question 2:
            Console.WriteLine("Question 2:");
            int[] nums2 = { 0, 1, 0, 3, 12 };
            IList<int> resultAfterMovingZero = MoveZeroes(nums2);
            string combinationsString = ConvertIListToArray(resultAfterMovingZero);
            Console.WriteLine(combinationsString);

            //Question 3:
            Console.WriteLine("Question 3:");
            int[] nums3 = { -1, 0, 1, 2, -1, -4 };
            IList<IList<int>> triplets = ThreeSum(nums3);
            string tripletResult = ConvertIListToNestedList(triplets);
            Console.WriteLine(tripletResult);

            //Question 4:
            Console.WriteLine("Question 4:");
            int[] nums4 = { 1, 1, 0, 1, 1, 1 };
            int maxOnes = FindMaxConsecutiveOnes(nums4);
            Console.WriteLine(maxOnes);

            //Question 5:
            Console.WriteLine("Question 5:");
            int binaryInput = 101010;
            int decimalResult = BinaryToDecimal(binaryInput);
            Console.WriteLine(decimalResult);

            //Question 6:
            Console.WriteLine("Question 6:");
            int[] nums5 = { 3,6,9,1 };
            int maxGap = MaximumGap(nums5);
            Console.WriteLine(maxGap);

            //Question 7:
            Console.WriteLine("Question 7:");
            int[] nums6 = { 2,1,2 };
            int largestPerimeterResult = LargestPerimeter(nums6);
            Console.WriteLine(largestPerimeterResult);

            //Question 8:
            Console.WriteLine("Question 8:");
            string result = RemoveOccurrences("daabcbaabcbc", "abc");
            Console.WriteLine(result);
        }

        /*
        
        Question 1:
        Given an integer array nums sorted in non-decreasing order, remove the duplicates in-place such that each unique element appears only once. The relative order of the elements should be kept the same. Then return the number of unique elements in nums.

        Consider the number of unique elements of nums to be k, to get accepted, you need to do the following things:

        Change the array nums such that the first k elements of nums contain the unique elements in the order they were present in nums initially. The remaining elements of nums are not important as well as the size of nums.
        Return k.

        Example 1:

        Input: nums = [1,1,2]
        Output: 2, nums = [1,2,_]
        Explanation: Your function should return k = 2, with the first two elements of nums being 1 and 2 respectively.
        It does not matter what you leave beyond the returned k (hence they are underscores).
        Example 2:

        Input: nums = [0,0,1,1,1,2,2,3,3,4]
        Output: 5, nums = [0,1,2,3,4,_,_,_,_,_]
        Explanation: Your function should return k = 5, with the first five elements of nums being 0, 1, 2, 3, and 4 respectively.
        It does not matter what you leave beyond the returned k (hence they are underscores).
 

        Constraints:

        1 <= nums.length <= 3 * 104
        -100 <= nums[i] <= 100
        nums is sorted in non-decreasing order.
        */

        public static int RemoveDuplicates(int[] nums)
        {
            try
            {
                // Write your code here and you can modify the return value according to the requirements
                if (nums.Length == 0) // checks if the length of the input array is 0
                {  
                    return 0; // if array is empty returns 0
                }
                int k = 1; //intializing k value to 1
                for (int i = 1; i < nums.Length; i++)  // Iterate through the array starting from index 1.

                {
                    if (nums[i] != nums[i - 1])  // Check if the current element is different from the previous element.

                    {
                        nums[k++] = nums[i]; // If the current element is different, store it at index k and increment k.
                    }
                }
                return k; // returns k value(length of modified array)
            }
            catch (Exception)
            {
                throw; //Re-throw any exceptions
            }
        }

        /*
         self reflection:
         This has indeed given me a very good question, teaching me an important lesson in how to remove duplicates from the sorted array in place efficiently. 
         This utilized two pointers and an iterative way to give me the desired result without any use of extra space.
         This exercise has evidently brought out the importance of being good at array manipulation, which is a stepping stone for many other programming tasks. 
         It emphasized the consideration to be taken when handling sorted arrays to ensure that these are effectively managed using two pointers, which streamline the processes involved in array manipulation.
         Sorted arrays: When presented with sorted arrays, two pointers should be recommended for efficient in-place manipulation. 
         This will also come with understanding the in-depth properties that are carried by sorted arrays, leading to optimized solutions. 
         With the constant practice and working on tasks related to arrays, it will make the skill set for array manipulation better. 
         This will eventually improve skills and, in turn, problem-solving skills, and those can be applied to order a wider variety of programming problems.
         * 

        /*
        
        Question 2:
        Given an integer array nums, move all 0's to the end of it while maintaining the relative order of the non-zero elements.

        Note that you must do this in-place without making a copy of the array.

        Example 1:

        Input: nums = [0,1,0,3,12]
        Output: [1,3,12,0,0]
        Example 2:

        Input: nums = [0]
        Output: [0]
 
        Constraints:

        1 <= nums.length <= 104
        -231 <= nums[i] <= 231 - 1
        */

        public static IList<int> MoveZeroes(int[] nums)
            {
                try
                {
                    // Write your code here and you can modify the return value according to the requirements
                    int nonZeroIndex = 0;  // Declare and initialize a variable 

                for (int i = 0; i < nums.Length; i++) //// Loop through the array 'nums'
                {
                        if (nums[i] != 0) // Check if the current element is not zero
                        {
                            nums[nonZeroIndex++] = nums[i]; // If non-zero, move it to the front of the array, at 'nonZeroIndex'
                        }
                }
                    for (int i = nonZeroIndex; i < nums.Length; i++) // Fill the remaining elements of the array with zeroes
                    {
                        nums[i] = 0;
                    }

                    return new List<int>(nums);// Return a new list containing the modified array

            }
            catch (Exception)
            {
                throw; //Re-throw any exceptions
            }
        }
        /*
         self reflection:  This exercise of dealing with an array that had specific requirements in which zeroes had to be moved to the end while keeping the relative ordering helped me very much to be very effective in handling any manipulations required in arrays. 
         It largely reinforced learning on the need to move through arrays efficiently and handle edge cases gracefully.
         This was explained, and in doing so, I understood vividly how to traverse arrays and how it is important that the structure of data be left intact during its manipulation.
         To continue to develop skills in the manipulation of arrays, practice across different scenarios is strongly recommended. It is always full of fruitarian insights and an extension of perspectives when exploring an alternative way of doing a similar task, such as using a different structure of data or algorithm. Many different techniques for array manipulation will be learned during the exercise in trying out different kinds of approaches with diverse strategies and how they find use in varied contexts. Involving more on the subject of algorithmic efficiency and time complexity analysis would assist me in this way and would bring about a more meaningful approach toward the solution of array manipulation tasks.
         * 


        /*

        Question 3:
        Given an integer array nums, return all the triplets [nums[i], nums[j], nums[k]] such that i != j, i != k, and j != k, and nums[i] + nums[j] + nums[k] == 0.

        Notice that the solution set must not contain duplicate triplets.

 

        Example 1:

        Input: nums = [-1,0,1,2,-1,-4]
        Output: [[-1,-1,2],[-1,0,1]]
        Explanation: 
        nums[0] + nums[1] + nums[2] = (-1) + 0 + 1 = 0.
        nums[1] + nums[2] + nums[4] = 0 + 1 + (-1) = 0.
        nums[0] + nums[3] + nums[4] = (-1) + 2 + (-1) = 0.
        The distinct triplets are [-1,0,1] and [-1,-1,2].
        Notice that the order of the output and the order of the triplets does not matter.
        Example 2:

        Input: nums = [0,1,1]
        Output: []
        Explanation: The only possible triplet does not sum up to 0.
        Example 3:

        Input: nums = [0,0,0]
        Output: [[0,0,0]]
        Explanation: The only possible triplet sums up to 0.
 

        Constraints:

        3 <= nums.length <= 3000
        -105 <= nums[i] <= 105

        */

        public static IList<IList<int>> ThreeSum(int[] nums)
        {
            try
            {
                // Write your code here and you can modify the return value according to the requirements
                Array.Sort(nums);        // Sort the input array of integers in ascending order
                List<IList<int>> result = new List<IList<int>>();        // Initialize a list to store the result (triplets that sum up to zero)
                for (int i = 0; i < nums.Length - 2; i++)        // Loop through the input array, stopping two elements before the end since we need at least three elements for a triplet

                {
                    if (i == 0 || (i > 0 && nums[i] != nums[i - 1]))            // Check if the current element is the first element or different from the previous one to avoid duplicate triplets
                    {
                        int low = i + 1;                 // Set the low pointer to the next element after the current one
                        int high = nums.Length - 1;                 // Set the high pointer to the last element in the array
                        int total = 0 - nums[i];                 // Calculate the target sum for the triplet
                        while (low < high)                 // Execute a while loop to find pairs that sum up to the target sum
                        {
                            if (nums[low] + nums[high] == total) // If the sum of the elements at low and high pointers equals the target sum
                            {
                                result.Add(new List<int> { nums[i], nums[low], nums[high] }); // Add the triplet to the result list
                                while (low < high && nums[low] == nums[low + 1]) low++;  // Skip over any duplicate elements at the low pointer
                                while (low < high && nums[high] == nums[high - 1]) high--;  // Skip over any duplicate elements at the high pointer
                                low++;                        // Move the low pointer to the next element and the high pointer to the previous element
                                high--;
                            }
                            else if (nums[low] + nums[high] < total)  // If the sum of the elements at low and high pointers is less than the target sum
                            {
                                low++; // Move the low pointer to the next element

                            }
                            else  // If the sum of the elements at low and high pointers is greater than the target sum
                            {
                                high--;                         // Move the high pointer to the previous element
                            }
                        }
                    }
                }
                return result;         // Return the list of triplets that sum up to zero
            }
            catch (Exception)
            {
                throw; //Re-throw any exceptions
            }
        }
        /*
         self reflection: Solving the three-sum problem was an intellectually stimulating exercise that made me dig into critical thinking over efficient algorithms in order to find triplets of elements summing up to zero. 
         Over the process, the task reinstated sorting of arrays before two-pointer techniques were applied to improve time complexity. It reinstated careful array manipulation and consideration of edge cases to cover accurate and effective results.
         This process further instilled in me more appreciation for the algorithmic strategies and the practical relevance they assume in real-life situations, which call for problem-solving.
         I could increase my problem-solving ability by taking more difficult algorithms tailored for the solution of array problems. I could even go further to study on dynamic programming or binary searching, where I can learn how to design algorithms while optimizing them. Furthermore, I got to realize the time and space complexity of the algorithms that lead me into deciding while solving problems. So, I would like to read up on the topics with time and get quite a grip on them at least to produce slightly better or more scalable solutions in future pursuits.
         * 

        /*

        Question 4:
        Given a binary array nums, return the maximum number of consecutive 1's in the array.

        Example 1:

        Input: nums = [1,1,0,1,1,1]
        Output: 3
        Explanation: The first two digits or the last three digits are consecutive 1s. The maximum number of consecutive 1s is 3.
        Example 2:

        Input: nums = [1,0,1,1,0,1]
        Output: 2
 
        Constraints:

        1 <= nums.length <= 105
        nums[i] is either 0 or 1.

        */

        public static int FindMaxConsecutiveOnes(int[] nums)
        {
            try
            {
                // Write your code here and you can modify the return value according to the requirements
                int maximumCount = 0;         // Initialize a variable named maximumCount to store the maximum count of consecutive ones found.
                int count = 0;         // Initialize a variable named count to store the current count of consecutive ones.
                foreach (var num in nums)         // Iterate through each element (num) in the input array (nums) using a foreach loop.
                {
                    if (num == 1)             // Check if the current element (num) is equal to 1.
                    {
                        count++;                 // If the current element is 1, increment the count of consecutive ones.
                        maximumCount = Math.Max(maximumCount, count);                 // Update the maximumCount with the maximum value between maximumCount and the current count.
                    }
                    else
                    {
                        count = 0;                // If the current element is not 1, reset the count of consecutive ones to 0.
                    }
                }
                return maximumCount;         // Return the maximum count of consecutive ones found.
            }
            catch (Exception)
            {
                throw; //Re-throw any exceptions
            }
        }
        /*
         Self-reflection: This is a task whereby sharp iteration and keeping a count are key to arriving at the maximum consecutive ones in the binary array.
         It just elicits an understanding of the importance of well-understood problem constraints, which, therefore, make solutions thought out to be in such a manner that they meet the constraints yet gain optimality in performance.
         Involving myself in this problem, it added better insight into binary array manipulation and subtleties of ways to maximize consecutive ones.
         Understand and solve problems related to bitwise operations and array traversals in binary arrays by practicing a good number of problems based on it. Also, try to optimize and incorporate the maximum optimization techniques for improvement in time and space complexity. This way, by checking out other ways and how effective they are, it will be gained very valuable knowledge about the efficiency of the algorithmic and improvement of problems' solution. Active learning and practical experience with these exercises will further consolidate deeper insight into binary array manipulations and their applications in all walks of computational based tasks.
         * 

        /*

        Question 5:
        You are tasked with writing a program that converts a binary number to its equivalent decimal representation without using bitwise operators or the `Math.Pow` function. You will implement a function called `BinaryToDecimal` which takes an integer representing a binary number as input and returns its decimal equivalent. 

        Requirements:
        1. Your program should prompt the user to input a binary number as an integer. 
        2. Implement the `BinaryToDecimal` function, which takes the binary number as input and returns its decimal equivalent. 
        3. Avoid using bitwise operators (`<<`, `>>`, `&`, `|`, `^`) and the `Math.Pow` function for any calculations. 
        4. Use only basic arithmetic operations such as addition, subtraction, multiplication, and division. 
        5. Ensure the program displays the input binary number and its corresponding decimal value.

        Example 1:
        Input: num = 101010
        Output: 42


        Constraints:

        1 <= num <= 10^9

        */

        public static int BinaryToDecimal(int binary)
        {
            try
            {
                // Write your code here and you can modify the return value according to the requirements
                int decimalNum = 0;         // Initialize decimalNum to store the final decimal value
                int value = 1;         // Initialize value to represent the current power of 2 being applied
                while (binary > 0)         // Iterate through each digit of the binary number until none are left
                {
                    int remainder = binary % 10;             // Extract the rightmost digit (remainder) of the binary number
                    binary /= 10;             // Remove the rightmost digit from the binary number
                    decimalNum += remainder * value;             // Update decimalNum by adding the product of remainder and current power of 2
                    value *= 2;             // Update the value to represent the next higher power of 2
                }

                return decimalNum;         // Return the calculated decimal value
            }
            catch (Exception)
            {
                throw; //Re-throw any exceptions
            }
        }
        /*
         Self-reflection: The trouble with solving the problem of how to convert from a binary number to a decimal number without using bitwise operators was fairly great.
         It called for great thinking out of the box and extremely solid understanding of arithmetic operations.
         But doing the same—with only basic arithmetic operations at my disposal and avoiding those with the bitwise operations—resulted in some very diligent manipulation of digits at my end so that I could safely convert from the binary representation to the correct decimal equivalence while taking all precautions to avoid mistakes.
         This further highlights the fact of the need for algorithmic thinking and basic principles of mathematics for every concept of computer science.
         Further research needs to be conducted in number system conversions and arithmetic operations to enhance problem-solving capabilities in this area. With more practice sessions of this kind, where the algorithms are to be implemented without built-in functions, one goes deeper into the subtleties of numeric conversion and reinforces their algorithmic thinking. 
         Besides, trying different techniques and perfecting the algorithms for efficiency shall make it one of the even more learned and experienced ways of doing things. 
         With further honing of the skills, a strong toolkit can be developed to take up challenges effectively so that mastery is ensured over the realm of number manipulation and algorithm design.
         *

        /*

        Question:6
        Given an integer array nums, return the maximum difference between two successive elements in its sorted form. If the array contains less than two elements, return 0.
        You must write an algorithm that runs in linear time and uses linear extra space.

        Example 1:

        Input: nums = [3,6,9,1]
        Output: 3
        Explanation: The sorted form of the array is [1,3,6,9], either (3,6) or (6,9) has the maximum difference 3.
        Example 2:

        Input: nums = [10]
        Output: 0
        Explanation: The array contains less than 2 elements, therefore return 0.
 

        Constraints:

        1 <= nums.length <= 105
        0 <= nums[i] <= 109

        */

        public static int MaximumGap(int[] nums)
        {
            try
            {
                // Write your code here and you can modify the return value according to the requirements
                Array.Sort(nums);         // Sort the input array in ascending order
                int maximumGap = 0;         // Initialize a variable to hold the maximum gap
                for (int i = 1; i < nums.Length; i++)         // Iterate through the sorted array starting from the second element
                {
                    maximumGap = Math.Max(maximumGap, nums[i] - nums[i - 1]); // Calculate the difference between consecutive elements and update the maximum gap if the current difference is greater
                }
                return maximumGap;         // Return the maximum gap found in the sorted array
            }
            catch (Exception)
            {
                throw; //Re-throw any exceptions
            }
        }
        /*
        Self-reflection: Engaging in the computation of the maximum gap between elements of a sorted array was a deep learning experience. 
        It also helped improve my skills in sorting algorithms while emphasis was placed on the very critical factor of data structures and suitable algorithm selection for specific problem constraints.
        In this manner, the sorting techniques and their applications in this case are formed for deriving ways to improve the performance and efficiency of the algorithmic solutions.
        Future readings for better understanding might involve sorting algorithms and their complex implementations. You could get drowned in all those small details of the techniques—quicksort, mergesort, heapsort, and so on—but take them all in, and you have a pretty good feel for the time and space complexities. 
        Besides, the trials of trying varied ways of solving array-related problems will serve to be creative in the design of algorithms. 
        To embrace the mindset of always exploring and experimenting is something destined to contribute toward mastery in the software development and computational problem-solving space.
        /*

        Question:7
        Given an integer array nums, return the largest perimeter of a triangle with a non-zero area, formed from three of these lengths. If it is impossible to form any triangle of a non-zero area, return 0.

        Example 1:

        Input: nums = [2,1,2]
        Output: 5
        Explanation: You can form a triangle with three side lengths: 1, 2, and 2.
        Example 2:

        Input: nums = [1,2,1,10]
        Output: 0
        Explanation: 
        You cannot use the side lengths 1, 1, and 2 to form a triangle.
        You cannot use the side lengths 1, 1, and 10 to form a triangle.
        You cannot use the side lengths 1, 2, and 10 to form a triangle.
        As we cannot use any three side lengths to form a triangle of non-zero area, we return 0.

        Constraints:

        3 <= nums.length <= 104
        1 <= nums[i] <= 106

        */

        public static int LargestPerimeter(int[] nums)
        {
            try
            {
                // Write your code here and you can modify the return value according to the requirements
                Array.Sort(nums);         // Sort the array in ascending order to easily find the largest perimeter.
                int n = nums.Length;         // Get the length of the array.
                for (int i = n - 1; i >= 2; i--)         // Iterate through the array starting from the end, as we want to find the largest perimeter.
                {
                    if (nums[i - 2] + nums[i - 1] > nums[i])             // Check if the sum of two smaller sides is greater than the largest side.
                    {
                        return nums[i - 2] + nums[i - 1] + nums[i];                 // If the condition is met, return the sum of the sides, which represents the largest perimeter.
                    }
                }
                return 0;         // If no valid triangle can be formed, return 0.

            }
            catch (Exception)
            {
                throw; //Re-throw any exceptions
            }
        }
        /*
         Self-reflection: Solving the assignment of finding the largest perimeter of a triangle made me dig deep into the details of geometric computations.
         I was able to recall that basic geometric knowledge does become helpful while solving problems algorithmically. 
         The above-mentioned challenge, as explained, forced me to consider thinking innovatively in identifying valid triangle combinations which needed both geometric constraints and attention due to the algorithmic strategies used.
         In this regard, I further wish to address other geometric algorithms and their own uses as tools in practice towards problem-solving within computation. 
         This will definitely enhance my understanding of geometric ideas and improve my overall approach to problem-solving, way much better.
         I will also try to get some practice breaking complicated geometric problems down into smaller, more manageable subproblems. 
         This will help enlighten not just the understanding of the problems in me but also how much better, efficient, and elegant the solutions have to be devised.
         So, I shall get improvement in my knowledge of this sphere and get brushed up on my problem-solving techniques in geometry to solve more dexterously a wider range of computational problems.
         * 

        /*

        Question:8

        Given two strings s and part, perform the following operation on s until all occurrences of the substring part are removed:

        Find the leftmost occurrence of the substring part and remove it from s.
        Return s after removing all occurrences of part.

        A substring is a contiguous sequence of characters in a string.

 

        Example 1:

        Input: s = "daabcbaabcbc", part = "abc"
        Output: "dab"
        Explanation: The following operations are done:
        - s = "daabcbaabcbc", remove "abc" starting at index 2, so s = "dabaabcbc".
        - s = "dabaabcbc", remove "abc" starting at index 4, so s = "dababc".
        - s = "dababc", remove "abc" starting at index 3, so s = "dab".
        Now s has no occurrences of "abc".
        Example 2:

        Input: s = "axxxxyyyyb", part = "xy"
        Output: "ab"
        Explanation: The following operations are done:
        - s = "axxxxyyyyb", remove "xy" starting at index 4 so s = "axxxyyyb".
        - s = "axxxyyyb", remove "xy" starting at index 3 so s = "axxyyb".
        - s = "axxyyb", remove "xy" starting at index 2 so s = "axyb".
        - s = "axyb", remove "xy" starting at index 1 so s = "ab".
        Now s has no occurrences of "xy".

        Constraints:

        1 <= s.length <= 1000
        1 <= part.length <= 1000
        s​​​​​​ and part consists of lowercase English letters.

        */

        public static string RemoveOccurrences(string s, string part)
        {
            try
            {
                // Write your code here and you can modify the return value according to the requirements
                while (s.Contains(part)) // Check if the string 's' contains the substring 'part'
                {
                    int index = s.IndexOf(part); // Find the index of the first occurrence of 'part' in 's'
                    s = s.Remove(index, part.Length); // Remove 'part' from 's' starting from the found index
                }
                return s; // Return the modified string after removing all occurrences of 'part'
            }
            catch (Exception)
            {
                throw; //Re-throw any exceptions
            }
        }
        /*Self-reflection: Working on the task of removing occurrences of a substring from the string just emphasized how much care has to be taken while doing anything with string manipulation; it's full of subtleties and nuances.
         This exercise highlights why it is important to learn different operations on strings and come up with proper algorithms of processing texts. Dealing with this problem brought out clearly how complex it is to have string integrity yet modify it; hence, good comprehension of the string manipulation techniques.
         To further become proficient in text processing activities, it is important to continue practicing solving problems of string manipulation.
         This definitely includes the exploration of a variety of string algorithms and what they apply to in computational challenges.
         In so doing, problem-solving skills in this area may be greatly enhanced. 
         These help you deepen the knowledge and adaptability for providing solutions over various scenarios in text processing by not stopping experimenting around different kinds of techniques for string manipulation and the ways of applying them.
         *

        /* Inbuilt Functions - Don't Change the below functions */
        static string ConvertIListToNestedList(IList<IList<int>> input)
        {
            StringBuilder sb = new StringBuilder();

            sb.Append("["); // Add the opening square bracket for the outer list

            for (int i = 0; i < input.Count; i++)
            {
                IList<int> innerList = input[i];
                sb.Append("[" + string.Join(",", innerList) + "]");

                // Add a comma unless it's the last inner list
                if (i < input.Count - 1)
                {
                    sb.Append(",");
                }
            }

            sb.Append("]"); // Add the closing square bracket for the outer list

            return sb.ToString();
        }


        static string ConvertIListToArray(IList<int> input)
        {
            // Create an array to hold the strings in input
            string[] strArray = new string[input.Count];

            for (int i = 0; i < input.Count; i++)
            {
                strArray[i] = "" + input[i] + ""; // Enclose each string in double quotes
            }

            // Join the strings in strArray with commas and enclose them in square brackets
            string result = "[" + string.Join(",", strArray) + "]";

            return result;
        }
    }
}