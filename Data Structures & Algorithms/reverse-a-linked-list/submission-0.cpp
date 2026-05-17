/**
 * Definition for singly-linked list.
 * struct ListNode {
 *     int val;
 *     ListNode *next;
 *     ListNode() : val(0), next(nullptr) {}
 *     ListNode(int x) : val(x), next(nullptr) {}
 *     ListNode(int x, ListNode *next) : val(x), next(next) {}
 * };
 */

class Solution {
public:
    ListNode* reverseList(ListNode* head) {
        if (!head) {
            return nullptr;
        }
        ListNode* temp;
        ListNode* tail = head;
        while (tail->next != nullptr) {
            tail = tail->next;
        }

        while (head != tail) {
            temp = head->next;
            head->next = tail->next;
            tail->next = head;
            head = temp;
        }

        return head;
    }
};
