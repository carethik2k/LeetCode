public class TwoSumSolution{
    public int[] TwoSum(int[] nums, int target) 
    {
        // for(int i=0; i<= nums.Length-1;i++)
        // {
        //     for(int j= i+1; j<=nums.Length-1; j++)
        //     {
        //         if(nums[i] + nums[j] == target)
        //             return new int[]{i, j};
        //     }
        // }

        Dictionary<int,int> dictNum = new Dictionary<int, int>();
        for(int i=0; i<= nums.Length-1;i++)
        {
            var targetNum = target - nums[i];
            if(dictNum.ContainsKey(targetNum))
            {
                return new int[]{dictNum[targetNum],i};
            }
            dictNum.TryAdd(nums[i],i);
        }

        return new int[1]{0};
    }
}