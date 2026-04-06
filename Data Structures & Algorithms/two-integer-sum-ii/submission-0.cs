public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int l=0,r=numbers.Length-1;
        while(l<r){
            if (numbers[l]+numbers[r]>target)
                r--;
            else if(target - numbers[r] > numbers[l])
            {
                l++;
            }
            if(numbers[l]+numbers[r] == target)
                return [l+1,r+1];
        }
        return [0];
    }
}
