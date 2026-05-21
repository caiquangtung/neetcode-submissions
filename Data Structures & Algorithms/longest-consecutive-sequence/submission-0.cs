public class Solution {
    public int LongestConsecutive(int[] nums) {
        if (nums.Length == 0) return 0;

        HashSet<int> numSet = new HashSet<int>(nums);
        int longest = 0;

        foreach (int num in numSet) {
            if (!numSet.Contains(num - 1)) {
                int currentNum = num;
                int length = 1;

                while (numSet.Contains(currentNum + 1)) {
                    currentNum++;
                    length++;
                }

                longest = Math.Max(longest, length);
            }
        }

        return longest;
    }
}
