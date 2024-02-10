using Microsoft.AspNetCore.Mvc;
using WebApplication1.Services;

namespace WebApplication1.Controllers;

[ApiController]
[Route("[controller]/[action]")]
public class Controller1 : ControllerBase
{
    private readonly IService1 _service1;
    public Controller1(IService1 service1)
    {
        _service1 = service1;
    }
    
    [HttpGet(Name = "MaxProfit")]
    public IActionResult MaxProfit([FromQuery] int[] prices)
    {
        var res = _service1.MaxProfit(prices);

        return Ok(res);
    }
    
    [HttpGet(Name = "FindDifference")]
    public IActionResult FindDifference([FromQuery] int[] nums1, [FromQuery] int[] nums2)
    {
        var res = _service1.FindDifference(nums1, nums2);

        return Ok(res);
    }
    
    [HttpPost(Name = "TwoSum")]
    public int[] TwoSum(int[] nums, int target)
    {
        return _service1.TwoSum(nums, target);
    }
    
    [HttpPost(Name = "Search")]
    public int Search(int[] nums, int target)
    {
        return _service1.Search(nums, target);
    }
    
    [HttpPost(Name = "SumOfTwoLowestNumbers")]
    public int SumOfTwoLowestNumbers(int[] nums)
    {
        return _service1.SumOfTwoLowestNumbers(nums);
    }
    
    [HttpPost(Name = "IsPalindrome")]
    public bool IsPalindrome(string s)
    {
        return _service1.IsPalindrome(s);
    }
    
    [HttpPost(Name = "LargestAltitude")]
    public int LargestAltitude(int[] gain)
    {
        return _service1.LargestAltitude(gain);
    }

    [HttpPost(Name = "FindMaxAverage")]
    public double FindMaxAverage(int[] nums, int k)
    {
        return _service1.FindMaxAverage(nums, k);
    }


    [HttpPost(Name = "IsSubsequence")]
    public bool IsSubsequence(string s, string t)
    {
        return _service1.IsSubsequence(s, t);
    }

    [HttpPost(Name = "MoveZeroes")]
    public int[] MoveZeroes(int[] nums)
    {
        return _service1.MoveZeroes(nums);
    }

    [HttpPost(Name = "CanPlaceFlowers")]
    public bool CanPlaceFlowers(int[] flowerbed, int n)
    {
        return _service1.CanPlaceFlowers(flowerbed, n);
    }

    [HttpPost(Name = "KidsWithCandies")]
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies)
    {
        return _service1.KidsWithCandies(candies, extraCandies);
    }

    [HttpGet(Name = "GcdOfStrings")]
    public string GcdOfStrings(string str1, string str2)
    {
        return _service1.GcdOfStrings(str1, str2);
    }
}