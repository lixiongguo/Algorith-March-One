using System.Collections;
using System.Collections.Generic;
public class LCode1262 
{
    // Start is called before the first frame update
    //void Start()
    //{
    //    int[] nums = { 3, 6, 5, 1, 8 };
    //    Debug.Log(MaxSumDivThree(nums));
    //}
    public int MaxSumDivThree(int[] nums)
    {
        int[,] divide = new int[nums.Length, 3];
        for (int i = 0; i < nums.Length; i++)
        {
            if (i == 0)
            {
                switch (nums[i] % 3)
                {
                    case 0:
                        divide[i, 0] = nums[i];
                        divide[i, 1] = 0;
                        divide[i, 2] = 0;
                        break;
                    case 1:
                        divide[i, 1] = nums[i];
                        divide[i, 0] = 0;
                        divide[i, 2] = 0;
                        break;
                    case 2:
                        divide[i, 2] = nums[i];
                        divide[i, 1] = 0;
                        divide[i, 0] = 0;
                        break;
                }
            }
            else
            {
                switch (nums[i] % 3)
                {
                    case 0:
                        divide[i, 0] = nums[i] + divide[i - 1, 0];
                        divide[i, 1] = nums[i] + divide[i - 1, 1];
                        divide[i, 2] = nums[i] + divide[i - 1, 2];
                        break;
                    case 1:
                        divide[i, 0] = nums[i] + divide[i - 1, 2];
                        divide[i, 1] = nums[i] + divide[i - 1, 0];
                        divide[i, 2] = nums[i] + divide[i - 1, 1];
                        break;
                    case 2:
                        divide[i, 0] = nums[i] + divide[i - 1, 1];
                        divide[i, 1] = nums[i] + divide[i - 1, 2];
                        divide[i, 2] = nums[i] + divide[i - 1, 0];
                        break;
                }
                //Debug.Log(divide[i, 0]);
                //Debug.Log(divide[i, 1]);
                //Debug.Log(divide[i, 2]);
                //Debug.Log("--------");
            }

        }
        return divide[nums.Length - 1, 0];
    }
    // Update is called once per frame
    void Update()
    {

    }



}
