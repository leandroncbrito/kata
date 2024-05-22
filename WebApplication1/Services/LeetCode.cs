using WebApplication1.Models;

namespace WebApplication1.Services;

public class LeetCode : IService1
{
    public int LengthOfLongestSubstring(string s)
    {
        int leftPointer = 0, rightPointer = 0, maxLength = 0;
        var chars = new HashSet<int>();

        while (rightPointer < s.Length)
        {
            var currChar = s[rightPointer];
            if (chars.Contains(currChar))
            {
                chars.Remove(s[leftPointer]);
                leftPointer++;
            }
            else
            {
                chars.Add(currChar);
                maxLength = Math.Max(maxLength, rightPointer - leftPointer + 1);
                rightPointer++;
            }
        }


        return maxLength;
    }

    public int LongestConsecutive(int[] nums)
    {
        if (nums.Length < 2)
        {
            return nums.Length;
        }

        var hs = new HashSet<int>(nums);
        var longest = 0;

        foreach (var item in hs)
        {
            if (hs.Contains(item - 1) is false)
            {
                var lenght = 0;
                while (hs.Contains(item + lenght)) 
                {
                    lenght++;
                    longest = Math.Max(longest, lenght);
                }
            }
        }

        return longest;
    }

    public int[] TopKFrequent(int[] nums, int k)
    {
        // 1,1,1,2,2,3
        int[] arr = new int[k];
        var dict = new Dictionary<int, int>();

        for (int i = 0; i < nums.Length; i++)
        {
            if (dict.ContainsKey(nums[i]))
            {
                dict[nums[i]]++;
            }
            else
            {
                dict.Add(nums[i], 1);
            }
        }

        var pq = new PriorityQueue<int, int>();
        foreach (var kv in dict)
        {
            pq.Enqueue(kv.Key, kv.Value);
            if (pq.Count > k)
            {
                pq.Dequeue();
            }
        }

        int j = k;
        while (pq.Count > 0)
        {
            arr[j - 1] = pq.Dequeue();
            j--;
        }

        return arr;
    }

    public int ContainerWithMostWater(int[] height)
    {
        var left = 0;
        var right = height.Length - 1;
        var res = 0;

        while (left < right)
        {
            var minHeight = Math.Min(height[left], height[right]);
            var area = minHeight * (right - left);
            res = Math.Max(res, area);

            if (height[left] < height[right])
            {
                left++;
            }
            else
            {
                right--;
            }
        }

        return res;
    }

    public int[] MaxSlidingWindow(int[] nums, int k)
    {
        var queue = new LinkedList<int>();
        var result = new List<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            while (queue.Count > 0 && queue.First.Value < i - k + 1)
            {
                queue.RemoveFirst();
            }

            var currentVal = nums[i];

            while (queue.Count > 0 && nums[queue.Last.Value] < currentVal)
            {
                queue.RemoveLast();
            }

            queue.AddLast(i);

            if (i >= k - 1)
            {
                result.Add(nums[queue.First.Value]);
            }
        }

        return result.ToArray();
    }

    public int MinDeletions(string s)
    {
        var hashMap = new Dictionary<char, int>();
        var hashSet = new HashSet<int>();
        var count = 0;

        foreach (var c in s)
        {
            if (!hashMap.TryAdd(c, 1))
            {
                hashMap[c]++;
            }
        }

        foreach (var freRo in hashMap.Values)
        {
            var freq = freRo;

            while (freq > 0 && hashSet.Contains(freq))
            {
                freq--;
                count++;
            }

            hashSet.Add(freq);
        }

        return count;
    }

    public int CountSubstrings(string s)
    {
        //baab
        var count = 0;

        for (var i = 0; i < s.Length; i++)
        {
            Count(s, i, i);
            Count(s, i, i + 1);
        }

        return count;

        void Count(string s1, int l, int r)
        {
            while (l >= 0 && r < s1.Length && s1[l] == s1[r])
            {
                l--;
                r++;
                count++;
            }
        }
    }

    public int MissingNumber(int[] nums)
    {
        Array.Sort(nums);

        var count = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == count)
            {
                count++;
            }
        }

        return count;
    }

    public int FindDuplicate(int[] nums)
    {
        var hash = new HashSet<int>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (hash.Contains(nums[i]))
            {
                return nums[i];
            }

            hash.Add(nums[i]);
        }

        return 0;
    }

    public int FirstMissingPositive(int[] nums)
    {
        Array.Sort(nums);

        var number = 1;
        for (var i = 0; i < nums.Length; i++)
        {
            if (nums[i] == number)
            {
                number++;
            }
        }

        return number;
    }

    public ListNode ReverseList(ListNode head)
    {
        ListNode prev = null;
        ListNode curr = head;

        while (curr != null)
        {
            var nxt = curr.next;

            curr.next = prev;
            prev = curr;
            curr = nxt;
        }

        return prev;
    }

    public int MaxProfit(int[] prices)
    {
        var left = 0;
        var maxProfit = 0;

        for (int right = 1; right < prices.Length; right++)
        {
            if (prices[left] < prices[right])
            {
                var profit = prices[right] - prices[left];
                maxProfit = Math.Max(maxProfit, profit);
            }
            else
            {
                left = right;
            }
        }

        return maxProfit;
    }

    public List<IList<int>> FindDifference(int[] nums1, int[] nums2)
    {
        // var hash1 = new HashSet<int>(nums1);
        // var hash2 = new HashSet<int>(nums2);
        //
        // hash1.ExceptWith(nums2);
        // hash2.ExceptWith(nums1);
        //
        // return new List<IList<int>>
        // {
        //     hash1.ToList(),
        //     hash2.ToList()
        // };

        var set1 = new HashSet<int>(nums1);
        var set2 = new HashSet<int>(nums2);

        var distinct1 = new List<int>();
        var distinct2 = new List<int>();

        foreach (var integer in set1)
        {
            if (!nums2.Contains(integer))
            {
                distinct1.Add(integer);
            }
        }

        foreach (var integer in set2)
        {
            if (!nums1.Contains(integer))
            {
                distinct2.Add(integer);
            }
        }

        return new List<IList<int>> { distinct1, distinct2 };
    }

    public int[] TwoSum(int[] nums, int target)
    {
        var hashMap = new Dictionary<int, int>();
        for (var i = 0; i < nums.Length; i++)
        {
            var diff = target - nums[i];

            if (hashMap.TryGetValue(diff, out var value))
            {
                return new[] { value, i };
            }

            hashMap[nums[i]] = i;
        }

        return new[] { 0 };
    }

    public int Search(int[] nums, int target)
    {
        int lo = 0;
        int hi = nums.Length - 1;

        while (lo <= hi)
        {
            var mid = lo + (hi - lo) / 2;

            if (nums[mid] == target)
            {
                return mid;
            }

            if (nums[mid] > target)
            {
                hi = mid - 1;
            }
            else
            {
                lo = mid + 1;
            }
        }


        return -1;
    }

    public int SumOfTwoLowestNumbers(int[] nums)
    {
        // var numbers = nums.ToList();

        // numbers.Sort();

        // return numbers[0] + numbers[1];

        // var numbers = new int [] { };

        var len = nums.Length;

        for (var i = 0; i < len - 1; i++)
        {
            var index = 0;
            while (index < len - 1)
            {
                if (nums[index] > nums[index + 1])
                {
                    (nums[index], nums[index + 1]) = (nums[index + 1], nums[index]);
                }

                index++;
            }
        }

        return nums[0] + nums[1];
    }

    public bool IsPalindrome(string s)
    {
        // var res = Regex.Replace(s.ToLowerInvariant(), "[^a-z0-9]", "");
        // var rev = new string(res.ToCharArray().Reverse().ToArray());
        // return res == rev;

        var res = string.Empty;
        foreach (var c in s)
        {
            if (char.IsLetterOrDigit(c))
            {
                res += c;
            }
        }

        res = res.ToLowerInvariant();

        var rev = string.Empty;
        for (var i = res.Length - 1; i >= 0; i--)
        {
            rev += res[i];
        }

        return res == rev;
    }

    public int LargestAltitude(int[] gain)
    {
        var sum = 0;
        var max = 0;

        foreach (var alt in gain)
        {
            sum += alt;
            if (sum > max)
            {
                max = sum;
            }
        }

        return max;
    }

    public double FindMaxAverage(int[] nums, int k)
    {
        double sum = 0;

        for (var i = 0; i < k; i++)
        {
            sum += nums[i];
        }

        double max = sum / k;

        for (var i = k; i < nums.Length; i++)
        {
            sum += nums[i] - nums[i - k];
            max = Math.Max(max, sum / k);
        }

        return max;
    }

    public bool IsSubsequence(string s, string t)
    {
        var sIndex = 0;
        var tIndex = 0;

        while (sIndex < s.Length && tIndex < t.Length)
        {
            if (s[sIndex] == t[tIndex])
            {
                sIndex++;
            }

            tIndex++;
        }

        return sIndex == s.Length;
    }

    public int[] MoveZeroes(int[] nums)
    {
        var pointer = 0;

        for (var index = 0; index < nums.Length; index++)
        {
            if (nums[index] != 0)
            {
                (nums[pointer], nums[index]) = (nums[index], nums[pointer]);
                pointer++;
            }
        }

        return nums;
    }

    public bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        for (var i = 0; i < flowerbed.Length; i++)
        {
            if (flowerbed[i] == 0 &&
                flowerbed.ElementAtOrDefault(i - 1) == 0 &&
                flowerbed.ElementAtOrDefault(i + 1) == 0)
            {
                flowerbed[i] = 1;
                n--;
            }
        }

        return n <= 0;
    }

    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        return candies.Select(c => c + extraCandies >= candies.Max()).ToList();
    }

    public string GcdOfStrings(string str1, string str2)
    {
        if (str1.Length < str2.Length)
        {
            return GcdOfStrings(str2, str1);
        }

        if (str2.Length == 0)
        {
            return str1;
        }

        if (str1.StartsWith(str2))
        {
            return GcdOfStrings(str1.Substring(str2.Length), str2);
        }

        return "";
    }
}