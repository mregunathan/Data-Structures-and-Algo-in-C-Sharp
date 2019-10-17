/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) { val = x; }
 * }
 */
public class Solution {
    
    /* Brute Force Version - does not work well with int overflow
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        long n1 = 0, n2 = 0, sum = 0;
        List<int> num1 = new List<int>();
        List<int> num2 = new List<int>();
        ListNode temp = l1;
        
        while(l1.next!=null)
        {
            num1.Add(l1.val);
            l1 = l1.next;
        }
        num1.Add(l1.val);
        
        //num1.Reverse();
        for(int m=0;m<num1.Count;m++)
        {
            n1 += num1[m] * (int)Math.Pow(10, m);
        }
        
        while(l2.next!=null)
        {
            num2.Add(l2.val);
            l2 = l2.next;
        }
        num2.Add(l2.val);
        
        //num2.Reverse();
        
        //n2 = num2[num2.Count-1];
        foreach(int k in num2)
            Console.WriteLine(k);
        for(int m=0;m<num2.Count;m++)
        {
            n2 += num2[m] * (int)Math.Pow(10, m);
        }
        
        Console.WriteLine("n1: " + n1);
        Console.WriteLine("n2: " + n2);
        sum = n1 + n2;
        if(sum == 0)
        {
            return new ListNode(0);
        }
        List<int> d = new List<int>();
        int sum1 = (int) sum;
        while(sum1 > 0)
        {
            d.Add(sum1 %10);
            sum1 = sum1 / 10;
        }
        //d.Reverse();
        
        int i = d.Count - 1;
        ListNode head = null;
        for(int j =0; j< d.Count; j++)
        {
            ListNode node = CreateNew(d[j], head);
            head = node;
            
            Console.WriteLine("Returned node data");
            ListNode dup= node;
            while(dup!=null)
              {
                Console.WriteLine(dup.val);
             dup = dup.next;
            }
            
        }
        return head;
    }
    
    public ListNode CreateNew(int data, ListNode head)
    {
        
        ListNode d= new ListNode(data);
        d.next = null;
        ListNode p = null;
        if(head == null)
        {
            d.next = null;
            p =d;
        }
        else
        {
        //node.next = d;
        ListNode current = head;
        while (current.next != null)
        {
            
            current = current.next;
        }

        current.next = d;
        

         p= head;
        }        
        
        ListNode dup1 = p;
        Console.WriteLine("Node values iside function");
        while(dup1!=null)
        {
            
            Console.WriteLine(dup1.val);
            dup1 = dup1.next;
        }
    
        return p;
    }
*/
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        int carryover = 0;
        ListNode cur1 = l1, cur2 = l2;
        ListNode res = null;
        int sum = 0; 
       
        while(cur1 != null && cur2 != null)
        {                           
            sum = cur1.val + cur2.val + carryover;
            if(sum > 9)
            {
                carryover = sum / 10;
                sum = sum % 10;
            }
            else
                carryover = 0;            
            ListNode node = AddLast(res, sum);
            res = node;            
            
            cur1 = cur1.next;
            cur2 = cur2.next;
        }
       
        while(cur1 !=null)
        {
                sum = cur1.val + carryover;
            if(sum > 9)
            {
                carryover = sum / 10;
                sum = sum % 10;
            }
            else
                carryover = 0; 
            ListNode node = AddLast(res, sum);
            res = node; 
            cur1 = cur1.next;
        }
        while(cur2 !=null)
        {
            sum = cur2.val + carryover;
            if(sum > 9)
            {
                carryover = sum / 10;
                sum = sum % 10;
            }
            else
                carryover = 0; 
            
            ListNode node = AddLast(res, sum);
            res = node; 
            cur2 = cur2.next;            
        }
        if(carryover ==1)
        {
            ListNode node = AddLast(res, carryover);
            res = node;
        }
        
        return res;
    }
    
    public ListNode AddLast(ListNode head, int n)
    {        
        ListNode p = new ListNode(n);
        p.next = null;
        ListNode ret = null;
        ListNode cur = head;
        if(cur == null)
        {
            ret = p;
        }
        else
        {
            while(cur.next !=null)
            {
                cur = cur.next;
            }
            cur.next = p;
            ret = head;
        }
        return ret;
    }
}