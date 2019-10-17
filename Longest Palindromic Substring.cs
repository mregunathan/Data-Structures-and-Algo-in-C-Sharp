public class Solution {
    public string LongestPalindrome(string s) {
        bool[,] table = new bool[s.Length,s.Length];
        int maxLength = 1, start = 0;
        int n = s.Length;
        if(s.Length == 0)
            return s;
        for(int i=0;i<s.Length; i++)
            {
                for (int j = 0; j < s.Length; j++)
                    table[i, j] = false;
            }
        for(int i=0; i < s.Length; i++)
        {
            table[i,i] = true;
        }
        for(int i=0; i < s.Length-1; i++)
        {
            if(s[i] == s[i+1])                
            {
                table[i,i+1] = true;
                maxLength = 2;
                start = i;
            }
        }
        for(int k =3; k<= s.Length; k++)
        {
            for(int i=0;i<n-k +1;i++)
            {
                int j = i+ k - 1;
                if((table[i+1, j-1]) && (s[i] == s[j]))
                {
                    table[i, j] = true;
                    if( k > maxLength)
                    {
                        maxLength = k;
                        start = i;
                    }
                }              
            }
        }
        return s.Substring(start, maxLength);
    }
}