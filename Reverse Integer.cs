public class Solution {
    /*
    public int Reverse(int x) {
        try
        {
        long sum = 0;
        
        List<int> a = new List<int>(); 
            bool isneg = false;

        if(x==0)
            return 0;        
        else if(x<0)
        {
            isneg = true;
            //x = Math.Abs(x);
            x = x > 0 ? x : -x;
        }
        int n = (int)Math.Floor(Math.Log10(x) + 1);

        while(x > 0)
        {        
            a.Add(x%10);
            x = x/10;
        }
        n--;
        foreach(int b in a)
        {
            sum = sum + b*(int)Math.Pow(10, n);
            if (sum > Int32.MaxValue || sum < Int32.MinValue)
                return 0;
            n--;
        }
        if (sum > Int32.MaxValue || sum < Int32.MinValue)
            throw new OverflowException();
        if(isneg)
            return (int)sum*-1;
        else
            return (int)sum;
    }
    catch(OverflowException)
    {
        return 0;
    }
    }
    */
    public int Reverse(int x) {
        long rev = 0;
        
        while(x != 0)
        {
            rev = rev*10 + x%10;
            x = x/10;
        }
        
        if(rev < Int32.MinValue || rev > Int32.MaxValue)
            return 0;
        return (int)rev;
    }

}