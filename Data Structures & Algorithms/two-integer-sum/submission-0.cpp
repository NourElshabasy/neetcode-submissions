class Solution {
public:
    vector<int> twoSum(vector<int>& nums, int target) {
        unordered_map<int, int> map;    

        for (int k = 0; k < nums.size(); k++)
        {
            map[nums[k]] = k;
        }

        for (int i = 0; i < nums.size(); i++)
        {
            if (map.count(target - nums[i]) && map[target - nums[i]] != i)
            {
                return {i, map[target - nums[i]]};
            }
        }
    }
};