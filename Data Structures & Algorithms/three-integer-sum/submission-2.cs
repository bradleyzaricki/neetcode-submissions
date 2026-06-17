public class Solution {
    public List<List<int>> ThreeSum(int[] nums)
    {
        Array.Sort(nums);
        int? prev = null;
        Dictionary<int,List<int>> numsDictionary = new Dictionary<int,List<int>>();
        List<List<int>> solution = new List<List<int>>();
        //create dictionary
        for(int i = 0; i < nums.Length; i++)
        {
            if(!numsDictionary.ContainsKey(nums[i]))
            {
                numsDictionary.Add(nums[i],new List<int>{i});
            }
            else
            numsDictionary[nums[i]].Add(i);
        }
        for(int i = 0; i < nums.Length; i++)
        {
            if(nums[i] <= prev && prev != null) continue;
            for(int j = i+1; j< nums.Length; j++)
            {
                if(nums[j] <= prev && prev != null) continue;
                int sum = nums[i] + nums[j];
                if(-sum >= nums[j] && numsDictionary.ContainsKey(0-sum))
                {
                    int count = numsDictionary[-sum].Count;
                    if(-sum == nums[j] && count < 3) 
                    {
                        if(-sum == nums[i]) 
                            continue;
                        if(count < 2)
                            continue;
                    }

                    solution.Add(new List<int>(){nums[i],nums[j],-sum});
                }
                prev = nums[j];  
            }
            prev = nums[i];
        }

    
        return solution;

    }
}
