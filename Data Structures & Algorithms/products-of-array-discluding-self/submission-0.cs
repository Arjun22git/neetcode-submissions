 public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] prefix = new int[nums.Length];
        int[] suffix = new int[nums.Length];
        int[] result = new int[nums.Length];
        int i=1;
        prefix[0]=i;
        for (int j=1;j<nums.Length;j++){
          prefix[j] = nums[j-1] * i;
          i=prefix[j];
        }
        suffix[nums.Length-1]=1;
        for(int k=nums.Length-2;k>=0;k--){
          suffix[k] = suffix[k+1]*nums[k+1];
        }
        for (int p=0;p<nums.Length;p++){
          result[p] = prefix[p]*suffix[p];
        }
        return result;
    }
}
