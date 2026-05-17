class Solution {
public:
    vector<int> twoSum(vector<int>& numbers, int target) {
        unordered_map<int, int> map;

        for (int i = 0; i < numbers.size(); ++i) {
            map[numbers[i]] = i+1;
        }

        for (int i = 0; i < numbers.size(); ++i) {
            if (map.count(target - numbers[i])
                && map[target - numbers[i]] != i
                && map[target - numbers[i]] > i) 
                {
                    return {i+1, map[target - numbers[i]]};
                }
        }

        return {};
    }
};
