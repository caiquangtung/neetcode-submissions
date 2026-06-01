public class Solution {
    public int MaxArea(int[] heights) {
        int left = 0;
        int right = heights.Length -1;
        int max_area = 0;
        int area = 0;
        while(left < right)
        {
            area = Math.Min(heights[left],heights[right])*(right - left);
            max_area = Math.Max(max_area, area);
            if(heights[left] < heights[right])
                left += 1;
            else
                right -= 1;
        }  
        return max_area; 
    }
}
