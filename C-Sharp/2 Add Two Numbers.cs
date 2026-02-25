/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class FirstSolution {
    private int additional = 0;

    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        var listAns = new ListNode();
        ListNode currentAns = listAns;
        ListNode currentL1 = l1;
        ListNode currentL2 = l2;

        currentAns.val = OperateNodes(currentAns, currentL1, currentL2);
        while(currentL1.next != null && currentL2.next != null){
            currentAns.next = new ListNode();
            currentAns = currentAns.next;

            currentL1 = currentL1.next;

            currentL2 = currentL2.next;

            currentAns.val = OperateNodes(currentAns, currentL1, currentL2);
        }

        if (currentL1.next != null){
            currentAns = AddRemaining(currentAns, currentL1);
        }
        if (currentL2.next != null){
            currentAns = AddRemaining(currentAns, currentL2);
        }

        if(additional !=0){
            currentAns.next = new ListNode();
            currentAns.next.val = additional;
        }
        return listAns;
    }

    public ListNode AddRemaining(ListNode nodeAns, ListNode nodeL){
        while(nodeL.next != null){
            nodeAns.next = new ListNode();
            nodeAns = nodeAns.next;
            nodeL = nodeL.next;
            if (additional != 0){
                nodeL.val++;
                additional = 0;
            }
            if (nodeL.val >= 10){
                additional++;
                nodeL.val = nodeL.val-10;
            }
            nodeAns.val = nodeL.val;
        }
        return nodeAns;
    }

    public int OperateNodes(ListNode currentAns, ListNode currentL1, ListNode      currentL2){
        var sum = currentL1.val + currentL2.val;
            if (additional != 0){
                sum++;
                additional = 0;
            }
            if (sum >= 10){
                additional++;
                sum = sum-10;
            }
            return sum;
    }
}

public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        ListNode dummyHead = new ListNode(0);
        ListNode current = dummyHead;
        int carry = 0;

        while (l1 != null || l2 != null || carry != 0) {
            int x = (l1 != null) ? l1.val : 0;
            int y = (l2 != null) ? l2.val : 0;
            
            int sum = carry + x + y;
            carry = sum / 10; 
            
            current.next = new ListNode(sum % 10); 
            current = current.next;

            if (l1 != null) l1 = l1.next;
            if (l2 != null) l2 = l2.next;
        }

        return dummyHead.next;
    }
}
