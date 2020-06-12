using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCode
{
    //    输入: "babad"
    //输出: "bab"
    //注意: "aba" 也是一个有效答案。

    class LCode5
    {
        public string LongestPalindrome(string s)
        {
            int maxLenth = 0;
            int idx_i=0;
            int idx_j=0;
            int[][] f = new int[s.Length][];
            for (int i = 0; i < s.Length; i++)
            {
                f[i][i] = 1;
            }
            for (int i = 0; i < s.Length; i++)
            {
                for (int k= 1; k < s.Length - i; k++)
                {
                    int j = i + k;
                    if (s[i] == s[j])
                    {
                        f[i][j] = f[i + 1][j - 1] + 2;
                        if (f[i][j] > maxLenth)
                        {
                            idx_i = i + 1;
                            idx_j = j - 1;
                        }
                    }
                    else
                    {
                        if (f[i][j] > maxLenth)
                        {
                            idx_i = i + 1;
                            idx_j = j - 1;
                        }
                        f[i][j] = Math.Max(f[i + 1][j], f[i][j - 1]);
                    }
                }
            }
            return s.Substring(idx_i, idx_j - idx_i + 1);
        }
    }
}
