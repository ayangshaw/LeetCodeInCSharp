using System;
using System.IO;
using System.Collections.Generic;

namespace Hash
{
    class Hash2
    {
        static void Main(string[] args)
        {
            int[] nums = { 2, 4, 12, 45, 30, 67 };
            int sum = 75;
            int[] x = TwoSum1(nums, sum);
            System.Console.WriteLine("result=[{0},{1}]", x[0], x[1]);
        }
        //方法二：两遍哈希表
        public static int[] TwoSum1(int[] nums, int target)
        {
            Dictionary<int, int> kvs = new Dictionary<int, int>();
            for (int i = 0; i < nums.Length; i++)
            {
                //需要对重复值进行判断；因为结果的唯一，所以若有重复值，且答案中包含了重复值的话，说明必有 重复值*2==target; 否则直接忽略重复值即可
                if (kvs.ContainsKey(nums[i]))
                {
                    if (nums[i] * 2 == target)
                    {
                        return new int[] { i, kvs[nums[i]] };
                    }
                }
                else
                {
                    kvs.Add(nums[i], i);
                }
            }
            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];
                if (kvs.ContainsKey(complement) && kvs[complement] != i)
                {
                    return new int[] { i, kvs[complement] };
                }
            }
            return new int[] { 0, 0 };
        }
    }
}


