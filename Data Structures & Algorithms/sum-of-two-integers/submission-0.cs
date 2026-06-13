public class Solution {
    public int GetSum(int a, int b) 
    {
        //used for initial entry and to continue iteration when carrying
        while (b != 0)
        {
            //carry case (both are 1)
            int carry = (a & b) << 1;
            //assign 1 if not carrying and not 0
            a = a ^ b;
            //assign b to the left shifted carry
            b = carry;
        }
        return a;
    }
}
