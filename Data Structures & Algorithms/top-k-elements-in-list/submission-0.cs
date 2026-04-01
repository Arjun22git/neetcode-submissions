public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        List<int>[] buckets = new List<int>[nums.Length+1];
        var freq = new Dictionary<int,int>();
        for (int i = 0; i < buckets.Length; i++) {
            buckets[i] = new List<int>();
        }
        foreach(int num in nums){
            if(freq.ContainsKey(num)){
                freq[num]++;
            }
            else{
                freq.Add(num,1);
            }
        }
        foreach(var val in freq){
            buckets[val.Value].Add(val.Key);
        }
        int[] res = new int[k];
        int index = 0;
        for(int j = buckets.Length-1;j>0 && index<k;j--){
            foreach(int n in buckets[j]){
                res[index]=n;
                index++;
                if(index==k){
                    return res;
                }
            }
        }
        return res;
        
    }
}
