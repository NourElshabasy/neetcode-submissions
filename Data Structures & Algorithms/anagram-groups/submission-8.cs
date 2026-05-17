public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, List<string>> map = new();

        foreach (string s in strs) {
            int[] count = new int[26];

            foreach (char c in s) {
                count[c - 'a']++;
            }

            // string key = count[0].ToString();
            // for (int i = 1; i < 26; ++i) {
            //     key += ',' + count[i].ToString();
            // }
            // can replace all this with this:
            string key = string.Join(",", count);

            if (!map.ContainsKey(key))
                map[key] = new List<string>();

            map[key].Add(s);
        }

        // List<List<string>> result = new();

        // foreach (var pair in map) {
        //     result.Add(pair.Value);
        // }

        // return result;
        // can replace all this with:

        return map.Values.ToList<List<string>>();
    }
}
