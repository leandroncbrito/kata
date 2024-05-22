using System.Net.Http.Json;
using Microsoft.AspNetCore.Mvc.Testing;
using WebApplication1.Services;

namespace TestProject1;

public class LeetCodeTests : IClassFixture<WebApplicationFactory<Program>>
{
    private readonly WebApplicationFactory<Program> _factory;

    public LeetCodeTests(WebApplicationFactory<Program> factory)
    {
        _factory = factory;
    }

    [Theory]
    [InlineData("zxyzxyz", 3)]
    [InlineData("abcabcbb", 3)]
    [InlineData("pwwkew", 3)]
    [InlineData("xxxx", 1)]

    public void LengthOfLongestSubstring(string s, int expected)
    {
        var sut = new LeetCode();

        var result = sut.LengthOfLongestSubstring(s);

        Assert.Equal(expected, result);
    }    
    
    [Theory]
    [InlineData(new int[] { 2, 20, 4, 10, 3, 4, 5 }, 4)]
    [InlineData(new int[] { 0, 3, 2, 5, 4, 6, 1, 1 }, 7)]

    public void LongestConsecutive(int[] nums, int expected)
    {
        var sut = new LeetCode();

        var result = sut.LongestConsecutive(nums);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(new int[] { 1,1,1,2,2,3 }, 2, new int[] { 1,2 })]
    [InlineData(new int[] { 1 }, 1, new int[] { 1 })]

    public void TopKFrequent(int[] nums, int k, int[] expected)
    {
        var sut = new LeetCode();

        var result = sut.TopKFrequent(nums, k);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(new int[] { 1,8,6,2,5,4,8,3,7 }, 49)]
    [InlineData(new int[] { 1,1 }, 1)]

    public void ContainerWithMostWater(int[] height, int expected)
    {
        var sut = new LeetCode();

        var result = sut.ContainerWithMostWater(height);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(new int[] { 1, 3, -1, -3, 5, 3, 6, 7 }, 3, new int[] { 3, 3, 5, 5, 6, 7 })]

    public void MaxSlidingWindow(int[] nums, int k, int[] expected)
    {
        var sut = new LeetCode();

        var result = sut.MaxSlidingWindow(nums, k);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("aaabbbcc", 2)]
    [InlineData("aab", 0)]
    [InlineData("ceabaacb", 2)]
    
    public void MinDeletions(string s, int expected)
    {
        var sut = new LeetCode();

        var result = sut.MinDeletions(s);

        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData("abc", 3)]
    public void CountSubstrings(string s, int expected)
    {
        var sut = new LeetCode();

        var result = sut.CountSubstrings(s);

        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData(new[] { 3, 0, 1 }, 2)]
    [InlineData(new[] { 0, 1 }, 2)]
    [InlineData(new[] { 1 }, 0)]
    [InlineData(new[] { 9, 6, 4, 2, 3, 5, 7, 0, 1 }, 8)]
    public void MissingNumber(int[] nums, int expected)
    {
        var sut = new LeetCode();

        var result = sut.MissingNumber(nums);

        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData(new[] { 3, 1, 3, 4, 2 }, 3)]
    [InlineData(new[] { 1, 3, 4, 2, 2 }, 2)]
    public void FindDuplicate(int[] nums, int expected)
    {
        var sut = new LeetCode();

        var result = sut.FindDuplicate(nums);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(new[] { -1, -3 }, 1)]
    [InlineData(new[] { 1, 2, 0 }, 3)]
    [InlineData(new[] { 3, 4, -1, 1 }, 2)]
    [InlineData(new[] { 3, 4, 1, 2, 6, 1 }, 5)]
    public void FirstMissingPositive(int[] nums, int expected)
    {
        var sut = new LeetCode();

        var result = sut.FirstMissingPositive(nums);

        Assert.Equal(expected, result);
    }
    
    [Theory]
    [InlineData(new[] { 7, 1, 5, 3, 6, 4 }, 5)]
    [InlineData(new[] { 2, 4, 1 }, 2)]
    public void MaxProfit(int[] prices, int expected)
    {
        var sut = new LeetCode();

        var result = sut.MaxProfit(prices);

        Assert.Equal(expected, result);
    }

    [Fact]
    public async Task FindDifference()
    {
        var expected = new List<List<int>> { new() { 1, 3 }, new() { 4, 6 } };

        var client = _factory.CreateClient();

        var nums1 = string.Join("&nums1=", new[] { 1, 2, 3 });
        var nums2 = string.Join("&nums2=", new[] { 2, 4, 6 });

        var response = await client.GetAsync($"/Controller1/FindDifference?nums1={nums1}&nums2={nums2}");

        response.EnsureSuccessStatusCode();

        var result = await response.Content.ReadFromJsonAsync<List<List<int>>>();

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 })]
    [InlineData(new[] { 3, 2, 4 }, 6, new[] { 1, 2 })]
    [InlineData(new[] { 3, 3 }, 6, new[] { 0, 1 })]
    [InlineData(new[] { 1, 1, 1, 1, 1, 4, 1, 1, 1, 1, 1, 7, 1, 1, 1, 1, 1 }, 11, new[] { 5, 11 })]
    public void TwoSum(int[] nums, int target, int[] expected)
    {
        var sut = new LeetCode();

        var result = sut.TwoSum(nums, target);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(new[] { -1, 0, 3, 5, 9, 12 }, 9, 4)]
    [InlineData(new[] { -1, 0, 3, 5, 9, 12 }, 2, -1)]
    public void Search(int[] nums, int target, int expected)
    {
        var sut = new LeetCode();

        var result = sut.Search(nums, target);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(new[] { 4, 2, 8, 5, 1, 7 }, 3)]
    [InlineData(new[] { 9, 3, 5, 8, 2, 1 }, 3)]
    [InlineData(new[] { -3, 6, 9, -2, 5 }, -5)]
    [InlineData(new[] { 5, 2, 5, 8, 2, 1 }, 3)]
    [InlineData(new[] { 0, 4, 0, 2, 8, 5, 1, 7 }, 0)]
    [InlineData(new int[] { -1, -1, 2, 2 }, -2)]
    [InlineData(new[] { 10, 2, 4 }, 6)]
    [InlineData(new[] { 3, 9 }, 12)]
    [InlineData(new[] { 100, 200, 300, 400, 500, 600, 700, 800, 900, 1000 }, 300)]
    public void SumOfTwoLowestNumbers(int[] nums, int expected)
    {
        var sut = new LeetCode();

        var result = sut.SumOfTwoLowestNumbers(nums);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("A man, a plan, a canal: Panama", true)]
    [InlineData(" ", true)]
    [InlineData("race a car", false)]
    public void IsPalindrome(string s, bool expected)
    {
        var sut = new LeetCode();

        var result = sut.IsPalindrome(s);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(new[] { -5, 1, 5, 0, -7 }, 1)]
    [InlineData(new[] { -4, -3, -2, -1, 4, 3, 2 }, 0)]
    public void LargestAltitude(int[] gain, int expected)
    {
        var sut = new LeetCode();

        var result = sut.LargestAltitude(gain);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(new[] { 1, 12, -5, -6, 50, 3 }, 4, 12.75000)]
    [InlineData(new[] { -1 }, 1, -1.00000)]
    public void FindMaxAverage(int[] nums, int k, double expected)
    {
        var sut = new LeetCode();

        var result = sut.FindMaxAverage(nums, k);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("abc", "ahbgdc", true)]
    [InlineData("axc", "ahbgdc", false)]
    [InlineData("ab", "baab", true)]
    [InlineData("leeeeetcode", "lyyeyyyeyyyyyeyyyyeyyyeyyyytyyycyyyyyoyyydyyyyye", true)]
    public void IsSubsequence(string s, string t, bool expected)
    {
        var sut = new LeetCode();

        var result = sut.IsSubsequence(s, t);

        Assert.Equal(expected, result);
    }

    [Fact]
    public void MoveZeroes()
    {
        var sut = new LeetCode();

        var numbers = new[] { 2, 1, 0, 3, 12 };

        var result = sut.MoveZeroes(numbers);

        Assert.Equal(new[] { 2, 1, 3, 12, 0 }, result);
    }

    [Theory]
    [InlineData(new[] { 1, 0, 0, 0, 1 }, 1, true)]
    [InlineData(new[] { 1, 0, 1, 0, 0 }, 1, true)]
    [InlineData(new[] { 0, 0, 1, 0, 1 }, 1, true)]
    [InlineData(new[] { 1, 0, 0, 0, 0 }, 2, true)]
    [InlineData(new[] { 0, 0, 0, 0, 1 }, 2, true)]
    [InlineData(new[] { 1, 0, 1, 0, 1 }, 1, false)]
    [InlineData(new[] { 1, 0, 0, 0, 1 }, 2, false)]
    [InlineData(new[] { 0 }, 1, true)]
    [InlineData(new[] { 0, 1, 0 }, 1, false)]
    public void CanPlaceFlowers(int[] flowerbed, int n, bool expected)
    {
        var sut = new LeetCode();

        var result = sut.CanPlaceFlowers(flowerbed, n);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(new[] { 2, 3, 5, 1, 3 }, 3, new[] { true, true, true, false, true })]
    [InlineData(new[] { 4, 2, 1, 1, 2 }, 1, new[] { true, false, false, false, false })]
    [InlineData(new[] { 12, 1, 12 }, 10, new[] { true, false, true })]
    public void KidsWithCandies(int[] candies, int extraCandies, bool[] expected)
    {
        var sut = new LeetCode();

        var result = sut.KidsWithCandies(candies, extraCandies);

        Assert.Equal(expected, result);
    }
}