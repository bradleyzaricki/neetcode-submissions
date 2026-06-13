public class Solution {
    public bool CanJump(int[] nums)
    {
        var numsDict = nums
            .Select((value, index) => new { value, index })
            .ToDictionary(x => x.index, x => x.value);
        HashSet<int> visited = new HashSet<int>();
        var finalValue = nums.Length -1;

        return (DFS(0,0,finalValue, numsDict, visited) > 0);

    }
    int DFS(int index, int prevIndex, int finalValue, Dictionary<int,int> values, HashSet<int> visited)
    {
        visited.Add(index);
        if(index == finalValue) return 1;

        if(values.TryGetValue(index, out var value))
        {
            for(int i = 0; i <= value; i++)
            {
                int location = index + i;
                if(visited.Contains(location)) continue;
                Console.WriteLine($"Moving to {value} from {index}");

                if (DFS(location, index, finalValue, values, visited) == 1)
                    return 1;   
            }
        }
        return 0;
    
    }
}
