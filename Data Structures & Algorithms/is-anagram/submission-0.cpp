class Solution {
public:
    bool isAnagram(string s, string t) {
        if (s.length() != t.length()) {
            return false;
        }

        unordered_map<char, int> freqS;
        unordered_map<char, int> freqT;

        for (auto c : s)
        {
            freqS[c]++;
        }
        for (auto c : t)
        {
            freqT[c]++;
        }

        return freqS == freqT;
    }
};
