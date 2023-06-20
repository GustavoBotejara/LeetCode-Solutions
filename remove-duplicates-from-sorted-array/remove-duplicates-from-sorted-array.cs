public class Solution {
    public int RemoveDuplicates(int[] nums) {
        int[] distinOcur = nums.ToList().Distinct().ToArray();

        for(int i=0;i<distinOcur.Length;i++) nums[i] = distinOcur[i];
        for(int i=distinOcur.Length;i<nums.Length;i++) nums[i] = 0;

        return distinOcur.Count();
    }
}