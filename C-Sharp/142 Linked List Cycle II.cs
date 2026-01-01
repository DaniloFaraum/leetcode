/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int x) {
 *         val = x;
 *         next = null;
 *     }
 * }
 */
public class Solution {
    public ListNode DetectCycle(ListNode head) {
        if (head == null || head.next == null) return null;

        var slow = head;
        var fast = head;

        while (fast != null && fast.next != null){
            slow = slow.next;
            fast = fast.next.next;
            if (slow == fast){
                var pointer = head;
                while (pointer != slow){
                    if (pointer == slow) return pointer;
                    pointer = pointer.next;
                    slow = slow.next;
                }
            }
        }
        return null;
    }
}
