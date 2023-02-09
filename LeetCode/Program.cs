
public static class Program
{
    public static void Main()
    {
        var t = RangeBitwiseAnd(5, 7);


    }
    
    public static int RangeBitwiseAnd(int left, int right) {
        int result = left;
        
        for(int i = left+1; i <= right; i++) {
            result &= i;
        }

        return result;
    }
    
}