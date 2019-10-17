public class Solution {
    public bool IsPalindrome(int x) {
        bool isPal = false;
        int y = x;
        if(x<0)
            return isPal;
        
        int res = 0;
        while(x != 0)
        {
            res = res*10 + x % 10;
            x = x / 10;
        }
        
        //Console.WriteLine(res);
        
        if(res == y)
            isPal = true;
        else
            isPal = false;
        
        return isPal;        
    }
}