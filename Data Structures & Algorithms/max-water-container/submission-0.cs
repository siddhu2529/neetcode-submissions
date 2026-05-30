public class Solution {
    public int MaxArea(int[] heights) {
        int i=0;
        int k = heights.Length -1;
        var maxArea=0;
        while(i<=k){
            var area = (k - i) * Math.Min(heights[i],heights[k]);
            if(heights[k]<heights[i]){
                k--;
            }
            else{
                i++;
            }
            if(area>maxArea) maxArea=area;
        }
        return maxArea;
    }
}
