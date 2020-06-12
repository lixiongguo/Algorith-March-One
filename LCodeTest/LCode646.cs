using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LCode
{
    class LCode646
    {
        //        给出 n个数对。 在每一个数对中，第一个数字总是比第二个数字小。

        //现在，我们定义一种跟随关系，当且仅当 b<c时，数对(c, d) 才可以跟在(a, b) 后面。我们用这种形式来构造一个数对链。

        //给定一个对数集合，找出能够形成的最长数对链的长度。你不需要用到所有的数对，你可以以任何顺序选择其中的一些数对来构造。

        //示例 :

        //输入: [[1,2], [2,3], [3,4]]
        //输出: 2
        //解释: 最长的数对链是[1, 2] -> [3,4]
        //        注意：

        //给出数对的个数在[1, 1000] 范围内。

        struct ChainData
        {
            public int end_value;
            public int start_value;
        }
        public int FindLongestChain(int[][] pairs)
        {
            List<ChainData> chainDatas = new List<ChainData>();

            for (int i = 0; i < pairs.Length; i++)
            {
                ChainData chainData = new ChainData();
                chainData.start_value = pairs[i][0];
                chainData.end_value = pairs[i][1];
                chainDatas.Add(chainData);
            }
            int cnt = 0;
            chainDatas.Sort((ChainData a, ChainData b) => { return a.end_value - b.end_value; });
            ChainData lastChainData = chainDatas[0];
            foreach (ChainData chainData in chainDatas)
            {
                if (cnt == 0 || chainData.end_value > lastChainData.end_value)
                {
                    cnt++;
                }
            }
            return cnt;
        }
    }
}
