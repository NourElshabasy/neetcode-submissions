class Solution {
public:

    string encode(vector<string>& strs) {
        string result;
        for (int i = 0; i < strs.size(); i++) {
            result += strs[i] + '.';
        }

        return result;
    }

    vector<string> decode(string s) {
        vector<string> result;
        string currentString = "";
        for (int i = 0; i < s.size(); i++) {
            if (s[i] == '.') {
                result.push_back(currentString);
                currentString = "";
            }
            else {
                currentString += s[i];
            }
        }

        return result;
    }
};
