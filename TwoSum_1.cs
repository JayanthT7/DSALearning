    public class Solution {
        //parse the elements till nums-1 length
        //get the remainder value by subtracting , remainder = target - nums[i] 
        //Check if remainder is found in the dictionary if no , then add the key as "nums[i]" and value as its respective index.
        //if yes , return the "nums[i]" element index and current index as a two sum pair.
        public int[] TwoSum(int[] nums, int target) {
            Dictionary<int,int> keyValuePairs = new Dictionary<int, int>();
            for(int i=0;i<=nums.Length-1;i++)
            {
                int remainder = target - nums[i];
                if(keyValuePairs.TryGetValue(remainder, out int j))
                {
                    return new int[] {j,i};
                }

                keyValuePairs.Add(nums[i],i);
        
            }
             throw new ArgumentException("No two sum solution pair found in given input nums array");
        }
    }