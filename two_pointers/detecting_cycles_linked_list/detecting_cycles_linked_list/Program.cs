using System;
using System.Collections.Generic;

namespace detecting_cycles_linked_list
{
    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int x)
        {
            val = x;
            next = null;
        }
    }

    class Program
    {
        public static bool HasCycle(ListNode head)
        {
            // Linked list only has a single node
            if (head?.next == default(ListNode)) return false;

            ListNode slowRunner = head;
            ListNode fastRunner = head;

            while (fastRunner != default(ListNode) && fastRunner.next?.next != default(ListNode))
            {
                /*
                 * Slow runner moves 1 step at a time
                 * Fast runner moves 2 steps at a time
                */
                slowRunner = slowRunner.next;
                fastRunner = fastRunner.next?.next;

                if (slowRunner == fastRunner)
                {
                    return true;
                }
            }

            return false;
        }

        static void Main(string[] args)
        {
            ListNode l1 = new ListNode(-21);
            ListNode l2 = new ListNode(10);
            ListNode l3 = new ListNode(17);
            ListNode l4 = new ListNode(8);
            ListNode l5 = new ListNode(4);
            ListNode l6 = new ListNode(26);
            ListNode l7 = new ListNode(5);
            ListNode l8 = new ListNode(35);
            ListNode l9 = new ListNode(33);
            ListNode l10 = new ListNode(-7);
            ListNode l11 = new ListNode(-16);
            ListNode l12 = new ListNode(27);
            ListNode l13 = new ListNode(-12);
            ListNode l14 = new ListNode(6);
            ListNode l15 = new ListNode(29);
            ListNode l16 = new ListNode(-12);
            ListNode l17 = new ListNode(5);
            ListNode l18 = new ListNode(9);
            ListNode l19 = new ListNode(20);
            ListNode l20 = new ListNode(14);
            ListNode l21 = new ListNode(14);
            ListNode l22 = new ListNode(2);
            ListNode l23 = new ListNode(13);
            ListNode l24 = new ListNode(-24);
            ListNode l25 = new ListNode(21);
            ListNode l26 = new ListNode(23);
            ListNode l27 = new ListNode(-21);
            ListNode l28 = new ListNode(5);

            l1.next = l2;
            l2.next = l3;
            l3.next = l4;
            l4.next = l5;
            l5.next = l6;
            l6.next = l7;
            l7.next = l8;
            l8.next = l9;
            l9.next = l10;
            l10.next = l11;
            l11.next = l12;
            l12.next = l13;
            l13.next = l14;
            l14.next = l15;
            l15.next = l16;
            l16.next = l17;
            l17.next = l18;
            l18.next = l19;
            l19.next = l20;
            l20.next = l21;
            l21.next = l22;
            l22.next = l23;
            l23.next = l24;
            l24.next = l25;
            l25.next = l26;
            l27.next = l27;
            l27.next = l28;
            l28.next = default(ListNode);

            bool res1 = HasCycle(l1);
        }
    }
}
