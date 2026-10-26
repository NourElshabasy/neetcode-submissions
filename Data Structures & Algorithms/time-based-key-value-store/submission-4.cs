public class TimeMap {
    public Dictionary<string, List<(string value, int timestamp)>> map;

    public TimeMap() {
        map = new Dictionary<string, List<(string, int)>>();
    }

    public void Set(string key, string value, int timestamp) {
        if (!map.ContainsKey(key)) {
            map[key] = new List<(string, int)>();
        }

        map[key].Add((value, timestamp));
    }

    public string Get(string key, int timestamp) {
        if (!map.ContainsKey(key))
            return "";

        int l = 0;
        int r = map[key].Count - 1;

        var next = map[key][0];

        while (l <= r) {
            int m = l + (r - l) / 2;

            if (map[key][m].Item2 == timestamp) {
                return map[key][m].Item1;
            } else if (map[key][m].Item2 < timestamp) {
                l = m + 1;
                if (map[key][m].Item2 > next.Item2)
                    next = map[key][m];
            } else {
                r = m - 1;
            }
        }

        if (next.Item2 > timestamp)
            return "";
        return next.Item1;
    }
}
