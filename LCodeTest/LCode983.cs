using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCode
{
    class LCode983
    {
        public int MincostTickets(int[] days, int[] costs)
        {
            int[] year_days = new int[366];
            int[] cost_days = new int[366];
            cost_days[0] = 0;
            for (int i = 0; i < days.Length; i++)
            {
                year_days[days[i]] = 1;
            }
            for (int i = 1; i <= 365; i++)
            {
                if (year_days[i] == 0)
                {
                    cost_days[i] = cost_days[i - 1];
                }
                else
                {
                    if (i >= 30) if (i >= 7 && i < 30)
                        {
                            int cost1 = cost_days[i - 1] + costs[0];
                            int cost2 = cost_days[i - 7] + costs[1];
                            int cost3 = cost_days[i - 30] + costs[2];
                            cost_days[i] = Math.Min(Math.Min(cost1, cost2), cost3);

                        }
                        else if (i >= 7)
                        {
                            int cost1 = cost_days[i - 1] + costs[0];
                            int cost2 = cost_days[i - 7] + costs[1];
                            cost_days[i] = Math.Min(cost1, cost2);
                        }
                        else
                        {
                            int cost1 = cost_days[i - 1] + costs[0];
                            cost_days[i] = cost1;
                        }
                }
            }
            return cost_days[365];
        }
    }
}
