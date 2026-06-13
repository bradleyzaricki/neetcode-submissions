public class Solution {
    public int MissingNumber(int[] nums) {
        int n = nums.Length;
        int expectedResult =  (n * (n+1)) /2;
        var result = 0;     

        foreach(int num in nums)
        {
            result += num;
        }
        result = expectedResult - result;
        return result;
    }
}
