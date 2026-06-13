public class Solution {
    public int[] TopKFrequent(int[] nums, int k) 
    {
        Dictionary<int,int> occurances = new Dictionary<int,int>();
        foreach(var num in nums)
        {
            if(occurances.ContainsKey(num))
            {
                occurances[num]++;
            }
            else
            {
                occurances[num] = 1;
            }
        }
        return occurances.OrderByDescending(o => o.Value).Select(o => o.Key).Take(k).ToArray();

    }
}
