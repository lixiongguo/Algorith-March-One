using System;
using System.Collections;
using System.Collections.Generic;

public class LCode149 
{
    public int MaxPoints(int[][] points)
    {
        if (points == null) return 0;
        if (points.Length == 0) return 0;
        if (points[0].Length == 0) return 0;
        Dictionary<float, int> counts = new Dictionary<float, int>();
        int diffY0Cnt = 0;
        int maxCount = 0;
        int surplus = 0;
        for (int i = 0; i < points.Length; i++)
        {
            float kj = 0;
            diffY0Cnt = 0;
            counts.Clear();
            surplus = 0;
            for (int j = 0; j < points.Length; j++)
            {
                if (j == i) continue;
                float diffX = points[i][0] - points[j][0];
                float diffY = points[i][1] - points[j][1];
                if (points[i][0] - points[j][0] == 0 && points[i][1] - points[j][1] == 0)
                {
                    surplus++;
                }
                else
                {
                    if (diffY == 0)
                    {
                        diffY0Cnt++;
                    }
                    else
                    {

                        kj = diffX / diffY;
                        if (!counts.ContainsKey(kj))
                        {
                            counts.Add(kj, 1);
                        }
                        else
                        {
                            counts[kj]++;
                        }
                    }
                }
            }
            foreach (var count in counts)
            {
                int surplusedVal = count.Value + surplus;
                if (surplusedVal > maxCount)
                {
                    maxCount = surplusedVal;
                }
            }
            if (diffY0Cnt + surplus > maxCount)
            {
                maxCount = diffY0Cnt + surplus;
            }
        }
        return maxCount+1;
    }
    private void Test()
    {
        int[][] points = new int[][] {
                new int[]{ 0,0},
                new int[]{ 94911151,94911150},
                new int[]{ 94911152,94911151},
            };
        Console.WriteLine(MaxPoints(points));
    }
}
