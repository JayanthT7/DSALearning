    //input nums[] = [1,2,3,1]   //4

public class CheckDuplicates_217
{
    HashSet<int> seen = new HashSet<int>();
    public bool IsDuplicate(int[] nums)
    {
     foreach(int num in nums)
     {
        if(seen.Contains(num))
        {
            return true;

        }
        else{
            seen.Add(num);
        }
     }
   
    return false;
    }
}