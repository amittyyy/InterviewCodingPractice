Links

https://github.com/vmudinas/InterviewQuestions


https://github.com/wotann07/leetcode_py

Velocity EHS

https://github.com/wotann07/ReversedList/blob/master/src/com/example/reversedList/LinkedList.java


package com.example.reversedList;


/**
 * This is a singly linked list
 */
class LinkedList {
    private Node head;

    LinkedList(Node head) {
        if (head == null) {
            throw new IllegalArgumentException();
        }
        this.head = head;
    }

    void append(Node next) {
        Node tmp = head;
        while (tmp.next != null) {
            tmp = tmp.next;
        }

        tmp.next = next;
    }

    LinkedList getReverseIterative() {
        Node current = head;
        Node reverseHead = new Node(head.value);

        while (current.next != null) {
            Node reverseNext = reverseHead;
            reverseHead = new Node(current.next.value);
            reverseHead.next = reverseNext;
            current = current.next;
        }

        return new LinkedList(reverseHead);
    }

    void reverseIterative() {
        Node current = head;
        Node reverse = null;

        while (current != null) {
            Node next = current.next;
            current.next = reverse;
            reverse = current;
            current = next;
        }

        head = reverse;
    }

    void reverseRecursive() {
        head = reverseRecursiveHelper(head);
    }

    private Node reverseRecursiveHelper(Node n) {
        // empty list
        if (n == null) return null;

        // end of list | one element list
        if (n.next == null) return n;

        // saving pointer to remainder of list
        Node nextNode = n.next;

        // un-linking list to avoid cycle
        n.next = null;

        // recursive call on the remainder of the list
        Node reverse = reverseRecursiveHelper(nextNode);

        // re-linking lists
        nextNode.next = n;

        return reverse;
    }

    void print() {
        Node tmp = head;
        while (tmp.next != null) {
            System.out.println(tmp.value);
            tmp = tmp.next;
        }
        System.out.println(tmp.value);
    }

    static class Node {
        Object value;
        Node next;

        Node(Object value) {
            this.value = value;
            next = null;
        }
    }
}