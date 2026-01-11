public class Solution {

    //Input : strs = ["eat","tea","tan","ate","nat","bat"]
    //Output: [["bat"],["nat","tan"],["ate","eat","tea"]
    public IList<IList<string>> GroupAnagrams(string[] strs) {

        //Create an empty (map) Dictionary key,Value
        //Convert the string[] to string
        //Convert the string to Char []
        //Sort the Char[]
        //Convert the Char[] back to string key.

        //Check if key is present in map dictionary
        //If not present , add that key to map along with empty list.
        //If yes , present , then add the string (s) to list.

        //Finally after foreach loop , return only Values from map.

    Dictionary<string,List<string>> map = new Dictionary<string,List<string>>(); 

    foreach(string s in strs)
    {
        char[] charArr= s.ToCharArray();
        Array.Sort(charArr);
        string key = new string(charArr);

        if(!map.TryGetValue(key,out List<string> list))
        {
            list=new List<string>();
            map.Add(key,list);
        }
        list.Add(s);
    }

    return map.Values.Select(l=>(IList<string>)l).ToList();
        
        
    }
}