public class Solution {
    public int CarFleet(int target, int[] position, int[] speed) {
        int fleets = 0;
        double slowestTime = 0;
        var cars = position.Zip(speed, (p, s) => (Position: p, Speed: s)).ToArray();
        Array.Sort(cars, (a, b) => b.Position.CompareTo(a.Position));

        for (int i = 0; i < position.Length; i++)
        {
            double time = (target - cars[i].Position) / (double)cars[i].Speed;
            if (time > slowestTime)
            {
                fleets++;
                slowestTime = time;
            }
        }
        
        return fleets;
    }
}
