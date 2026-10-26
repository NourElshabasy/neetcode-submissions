public class TimeMap {
    private Dictionary<string, List<(string value, int timestamp)>> map = new();

    public void Set(string key, string value, int timestamp) {
        if (!map.ContainsKey(key))
            map[key] = new();

        map[key].Add((value, timestamp));
    }

    public string Get(string key, int timestamp) {
        if (!map.TryGetValue(key, out var list))
            return "";

        string res = "";
        int l = 0, r = list.Count - 1;

        while (l <= r) {
            int m = l + (r - l) / 2;

            if (list[m].timestamp <= timestamp) {
                res = list[m].value;
                l = m + 1;
            } else {
                r = m - 1;
            }
        }

        return res;
    }
}