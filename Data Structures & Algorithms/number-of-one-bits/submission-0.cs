public class Solution {
    public int HammingWeight(uint n) 
    {
        int m = Convert.ToInt32(n);
        int count = 0;
        while(m != 0)
        {
            count += m % 2;
            m = m >> 1;
        } 
        return count;
    }
}
