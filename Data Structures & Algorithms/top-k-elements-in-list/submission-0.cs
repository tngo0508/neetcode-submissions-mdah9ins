public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var minHeap = new PriorityQueue<int, int>();
        var freq = new Dictionary<int, int>();
        foreach (var num in nums) {
            freq[num] = freq.GetValueOrDefault(num, 0) + 1;
        }
        foreach (var (num, count) in freq) {
            minHeap.Enqueue(num, count);
            if (minHeap.Count > k) {
                minHeap.Dequeue();
            }
        }
        return minHeap.UnorderedItems.Select(x => x.Element).ToArray();
    }
}
