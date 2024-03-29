public bool HasCycle(ListNode head) {
        if (head == null)
            return false;
        
        ListNode node1 = head;
        ListNode node2 = node1.next;
        
        while (node1 != null && node2 != null)
        {
            if (node1 == node2)
                return true;
            
            node1 = node1.next;
            node2 = node2.next?.next;
        }
        
        return false;
    }