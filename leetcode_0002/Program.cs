using System;

namespace LeetCode_0002
{
    /**
    1-声明一个链表类；
    2-
    **/
    public class ListNode
    {
        public int val; //字段
        public ListNode next;//类的实例
        public ListNode(int x) { val = x; }//这是一个和类同名的构造函数方法；叫做重构函数；
    }
    class Program
    {
        static void Main()
        {
            // Console.WriteLine("Hello World!");
            var l1 = generateList(new int[] { 1, 5, 7 });
            var l2 = generateList(new int[] { 9, 8, 2, 9 });
            printList(l1);
            printList(l2);
            Solution s = new Solution();
            var sum = s.AddTwoNumbers(l1, l2);
            printList(sum);

        }

        static ListNode generateList(int[] vals)
        {
            ListNode res = null;
            ListNode last = null;
            foreach (var val in vals)
            {
                if (res is null)
                {
                    res = new ListNode(val);
                    last = res;
                }
                else
                {
                    last.next = new ListNode(val);
                    last = last.next;
                }
            }
            return res;

        }
        static void printList(ListNode l)
        {
            while (l != null)
            {
                Console.Write($"{l.val}, ");
                l = l.next;
            }
            Console.WriteLine("");
        }
    }
    public class Solution
    {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int val = 0;
            ListNode prenode = new ListNode(0);
            ListNode lastnode = prenode;
            while (l1 != null || l2 != null || val != 0)
            {
                val = val + (l1 == null ? 0 : l1.val) + (l2 == null ? 0 : l2.val);
                lastnode.next = new ListNode(val % 10);
                lastnode = lastnode.next;
                val = val / 10;
                l1 = l1 == null ? null : l1.next;
                l2 = l2 == null ? null : l2.next;
            }
            return prenode.next;
        }
    }

}
