public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        var triplet = new List<List<int>>();
        Array.Sort(nums);
        for(int i=0;i<nums.Length-2;i++){

            if(i>0 && nums[i]==nums[i-1])
                continue;

            int j=i+1,k=nums.Length-1;

            while(j<k){
                int sum = nums[j]+nums[k]+nums[i];

                if(sum==0){

                triplet.Add([nums[i],nums[j],nums[k]]);

                while(j<k && nums[j]== nums[j+1]) j++;
                while(j<k && nums[k]== nums[k-1]) k--;

                j++;
                k--;
                }
                else if(sum<0)
                    j++;
                else{
                    k--;
                }
            }
        }
        return triplet;
    }
}
