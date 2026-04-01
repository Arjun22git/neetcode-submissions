public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var freq = new Dictionary<int,int>();
        List<int>[] buckets  = new List<int>[nums.Length+1];
        //intialize the buckets with empty lists
        for (int i=0;i<buckets.Length;i++){
            buckets[i] = new List<int>();
        }

        //find the freq
        foreach (int num in nums){
            if(freq.ContainsKey(num)){
                freq[num]++;
            }
            else{
                freq[num]=1;
            }
            
        }
        //app the freq to buckets
        foreach(var val in freq){
            buckets[val.Value].Add(val.Key);
        }

        //create the result array
        int[] res = new int[k];
        int index=0;
        for(int j = buckets.Length-1;j>0 && index<k;j--){
            foreach(int num in buckets[j]){
                res[index]=num;
                index++;
                if(index==k)
                    return res;
            }
        }
        return res;
    }
}
