public class Solution
{
    public int Reverse(int x)
    {
        int [] vs = new int [10];
        int digts=0;

        while(x != 0)
        {
            vs [digts++] = x%10;
            x /= 10;
        }
        long y=0;
        for (int i = 0; i < digts; i++)
        {
            y=y*10+vs[i];
        }
        
        if ((y> 2147483648 )||( y < -2147483648)){
            return 0;
        }
        return (int)y;

    }
}