public class Solution {
    public bool IsValid(string s) {
        char[] str = s.ToCharArray();
        Stack st = new Stack();
        Dictionary<char,char> d = new Dictionary<char,char>();
        d.Add(')','(');
        d.Add('}','{');
        d.Add(']','[');
        if(str.Length == 0)
            return true;
        if(str.Length %2 != 0)
            return false;
        for(int i=0;i<str.Length;i++)
        {
            char c = str[i];
            if(d.ContainsKey(c))
            {
                char top = (st.Count==0)? '#' : (char)st.Pop();
                char val;
                d.TryGetValue(c, out val);
                if(top != val)
                {
                    return false;
                }
            }
            else{
                st.Push(c);
            }
            
        }
        return (st.Count == 0);
    }
}