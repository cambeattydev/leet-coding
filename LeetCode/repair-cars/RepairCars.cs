namespace LeetCode.repair_cars;

public class Solution {
    
    public long RepairCars(int[] ranks, int cars)
    {
        var max = ranks.Max();

        //Used to keep which mechanics can work, not really needed though
        /*
        var freqs = new int[max +1];
        foreach (var rank in ranks)
        {
            freqs[rank]++;
        }
        Console.WriteLine(string.Join(",", freqs));
        */
        long minTimeToWork = 1;
        long maxTimeToWork = (long)max * cars * cars;
        //binary search
        while (minTimeToWork < maxTimeToWork)
        {
            long mid = (minTimeToWork + maxTimeToWork) / 2;
            long carsRepaired = 0;

            foreach (var rank in ranks)
            {
                carsRepaired += (long)Math.Sqrt(1.0 * mid / (double)rank);
                Console.WriteLine($"Repaired cars: {carsRepaired}   ");
            }
            /*
            for (var rank = 1; rank <= max; rank++) {
                //carsRepaired += freqs[rank] *c
                Console.WriteLine(carsRepaired);
            }
            */

            if (carsRepaired >= cars)
            {
                maxTimeToWork = mid;
            }
            else
            {
                minTimeToWork = mid +1;
            }
            //Console.WriteLine("---------------------------------------");
        }
        return minTimeToWork;
    }
}