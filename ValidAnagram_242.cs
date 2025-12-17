public class Solution 
{
    //Input: s = "anagram", t = "nagaram"

    // 1)Convert to characters present in string s
    // 2)Then add those characters to new counts dictionary object.
    // 3)While adding, increment the count of character only for already added character in counts dictionary , for not found character it will initialize to 1.
    // 4)Now do the same steps for string s , that is convert to characters present in string t.
    // 5)Here sub those characters found in counts dictionary object if not found assign -1.
    // 6)At last step , check whether all the characters after subtracting becomes 0 in counts dictionary.


    public bool Main(string s, string t)
    {
        
        if(s.Length!=t.Length)
        {
            return false;
        }

         Dictionary<char,int> counts= new Dictionary<char,int>();

        foreach(char c in s)
        {
        counts[c] = counts.TryGetValue(c ,out int a) ? a+1 : 1;
        }

        foreach(char c in t)
        {
        counts[c]=counts.TryGetValue(c,out int a) ? a-1 : -1;
        }

        return counts.Values.All(v=>v==0);

    }
}