public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> freq = new Dictionary<int, int>();

        // Đếm tần số
        foreach (int num in nums)
        {
            if (!freq.ContainsKey(num))
                freq[num] = 0;
            freq[num]++;
        }

        // Sắp xếp theo tần số giảm dần và lấy k phần tử
        return freq.OrderByDescending(x => x.Value)
                   .Take(k)
                   .Select(x => x.Key)
                   .ToArray();
    }
}
