public class Solution {
    public bool CheckIfExist(int[] arr) {
        int i, j;
        for(i=0;i<arr.Length;i++){
            for(j=0;j<arr.Length;j++){
                if(i!=j)if(arr[i] == 2*arr[j])return true; 
            }   
        }   
        return false;
    }
}