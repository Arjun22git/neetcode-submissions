public class Solution {
    public int LongestConsecutive(int[] nums) {
        // var numbers = new HashSet<int>();
        var numbers = nums.ToHashSet();

        var maxCount = 0;
        foreach(int val in nums){
            if(!numbers.Contains(val-1)){
                var count = 0;
                while(numbers.Contains(val+count)){
                    count+=1;
                }
                maxCount = Math.Max(maxCount,count);
            }
        }
        return maxCount;
    }
}
