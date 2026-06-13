public class Solution 
{
    public bool CanJump(int[] nums)
    {
        int range = 0;
        for(int i = 0; i < nums.Length; i++)
        {
            if(range < i) return false;
            if(range >= nums.Length -1) return true;
            range = Math.Max(i + nums[i], range);
        }
        return false;
    }
  
}
