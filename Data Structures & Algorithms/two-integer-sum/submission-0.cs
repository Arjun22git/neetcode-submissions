public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int,int> visited = new Dictionary<int,int>();
        for(int i =0; i<nums.Length; i++){
            int newTarget = target-nums[i];
            if(visited.ContainsKey(newTarget))
                return [visited[newTarget],i];
            else{
                visited.Add(nums[i],i);
            }
        }
        return null;
    }
}
