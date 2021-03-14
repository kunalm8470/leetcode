using System;
using System.Collections.Generic;

namespace palindrome_linked_list
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    class Program
    {
        public static bool IsPalindrome(ListNode head)
		{
			ListNode dummy = head;
			Stack<int> stk = new Stack<int>();

			while (dummy != default(ListNode))
			{
				stk.Push(dummy.val);
				dummy = dummy.next;
			}

			while (head != default(ListNode))
			{
				if (head.val != stk.Pop())
				{
					return false;
				}

				head = head.next;
			}

			return true;
		}

		static void Main(string[] args)
        {
			ListNode head1 = new ListNode(1, new ListNode(2, new ListNode(2, new ListNode(1, null))));
			bool res1 = IsPalindrome(head1);

			ListNode head2 = new ListNode(1, new ListNode(2, null));
			bool res2 = IsPalindrome(head2);
		}
    }
}
