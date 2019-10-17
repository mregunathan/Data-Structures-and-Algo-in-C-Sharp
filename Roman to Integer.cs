public class Solution {
    public int RomanToInt(string s) {
        Dictionary<char, int> dict = new Dictionary<char, int>();
        dict.Add('I',1);
        dict.Add('V',5);
        dict.Add('X',10);
        dict.Add('L',50);
        dict.Add('C',100);
        dict.Add('D',500);
        dict.Add('M',1000);
        
        int sum = 0;
        for(int i=0; i < s.Length; i++)
        {
            if(s[i] == 'I')
            {
                if((i+1 < s.Length) && (s[i+1] == 'V' || s[i+1] == 'X'))
                {
                    sum += dict[s[i+1]] - dict[s[i]];
                    i++;
                }  
                else
                {
                    sum+=dict[s[i]];
                }
            }
            else if(s[i] == 'X')
            {
                if((i+1 < s.Length) && (s[i+1] == 'L' || s[i+1] == 'C'))
                {
                    sum += dict[s[i+1]] - dict[s[i]];
                    i++;
                }  
                else
                {
                    sum+=dict[s[i]];
                }
            }
            else if(s[i] == 'C')
            {
                if((i+1 < s.Length) && (s[i+1] == 'D' || s[i+1] == 'M'))
                {
                    sum += dict[s[i+1]] - dict[s[i]];
                    i++;
                }  
                else
                {
                    sum+=dict[s[i]];
                }
            }
            else
            {
                sum+=dict[s[i]];
            }
        }
        return sum;   
    }
}