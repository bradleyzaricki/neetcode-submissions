public class Solution {
    public bool IsAnagram(string s, string t) 
    {
        Dictionary<int,int> sValues  = new Dictionary<int,int>();
        Dictionary<int,int> tValues = new Dictionary<int,int>();

        foreach(char sChar in s)
        {
            if(sValues.TryGetValue(sChar, out var count))
            {
                sValues[sChar] = ++count;
                continue;
            }
            sValues[sChar] = 1;
        }
        foreach(char tChar in t)
        {
            if(tValues.TryGetValue(tChar, out var count))
            {
                tValues[tChar] = ++count;
                continue;
            }
            tValues[tChar] = 1;
        }

        //Verify with LINQ query, kvp exists in both and values are equal for both
        return
        (tValues.Count == sValues.Count) &&
        tValues.All(kvp => sValues.TryGetValue(kvp.Key, out var value) && (kvp.Value == value));      

    }
}
