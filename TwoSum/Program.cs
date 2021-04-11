/***
* 
给定一个整数数组 nums 和一个整数目标值 target，请你在该数组中找出 和为目标值 的那 两个 整数，并返回它们的数组下标。
你可以假设每种输入只会对应一个答案。但是，数组中同一个元素在答案里不能重复出现。
你可以按任意顺序返回答案。
来源：力扣（LeetCode）
链接：https://leetcode-cn.com/problems/two-sum
著作权归领扣网络所有。商业转载请联系官方授权，非商业转载请注明出处。
*
**/
using System;

namespace TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            int[] nums = { 2, 4, 12, 45, 30, 67 };
            int sum = 75;
            int[] x = TwoSum(nums, sum);
            System.Console.WriteLine("result=[{0},{1}]", x[0], x[1]);

        }
        public static int[] TwoSum(int[] nums, int target)
        {
            int[] x = new int[2];
            for (int i = 0; i < nums.Length - 1; i++)
            {
                for (int j = i + 1; j < nums.Length; j++)
                {
                    if (nums[i] + nums[j] == target)
                    {
                        x = new int[] { i, j };
                        return x;
                    }
                }
            }
            return new int[] { 0, 0 };
        }

    }
}
