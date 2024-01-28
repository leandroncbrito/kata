namespace WebApplication1.Services;

public interface IService1
{
    List<IList<int>> FindDifference(int[] nums1, int[] nums2);
    int[] TwoSum(int[] nums, int target);
    int Search(int[] nums, int target);
    int SumOfTwoLowestNumbers(int[] nums);
    bool IsPalindrome(string s);
    int LargestAltitude(int[] gain);
    double FindMaxAverage(int[] nums, int k);
    bool IsSubsequence(string s, string t);
    int[] MoveZeroes(int[] nums);
    bool CanPlaceFlowers(int[] flowerbed, int n);
    IList<bool> KidsWithCandies(int[] candies, int extraCandies);
    string GcdOfStrings(string str1, string str2);
}