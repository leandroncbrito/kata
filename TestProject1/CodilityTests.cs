using WebApplication1.Services;

namespace TestProject1;

public class CodilityTests
{
    [Theory]
    [InlineData(6, 11, 2, 3)]
    [InlineData(11, 345, 17, 20)]
    public void CountDiv(int A, int B, int K, int expected)
    {
        var sut = new Codility();

        var result = sut.CountDiv(A, B, K);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData("racecar", 3)]
    [InlineData("x", 0)]
    public void StrSymmetryPoint(string S, int expected)
    {
        var sut = new Codility();

        var result = sut.StrSymmetryPoint(S);

        Assert.Equal(expected, result);
    }

    [Theory]
    [InlineData(new[] { 1, 4, 3, 3, 1, 2, }, 4)]
    [InlineData(new[] { 6, 4, 4, 6 }, -1)]
    public void UniqueNumber(int[] A, int expected)
    {
        var sut = new Codility();

        var result = sut.UniqueNumber(A);

        Assert.Equal(expected, result);
    }     
    
    [Theory]
    [InlineData(new[] { 3, 4, 3, 2, 3, -1, 3, 3 }, 4)]
    [InlineData(new[] { 3, 3, 4, 5, 6, 6, 6 }, -1)]
    [InlineData(new[] { 6, 2, 2 }, 1)]
    [InlineData(new[] { 1, 2, 1 }, 2)]
    [InlineData(new[] { 0, 0, 1, 1, 1 }, 2)]
    [InlineData(new int[] { }, -1)]
    public void Dominator(int[] A, int expected)
    {
        var sut = new Codility();

        var result = sut.Dominator(A);

        Assert.Equal(expected, result);
    }  
    
    [Theory]
    [InlineData(new[] { 2, 1, 1, 2, 3, 1 }, 3)]
    [InlineData(new[] { 2, 2, 2, 2, 2, 2 }, 1)]
    [InlineData(new[] { 2 }, 1)]
    [InlineData(new[] { -2, 2 }, 2)]
    [InlineData(new[] { 1, 2 }, 2)]
    [InlineData(new int[] { }, 0)]
    public void DistinctNumbers(int[] A, int expected)
    {
        var sut = new Codility();

        var result = sut.DistinctNumbers(A);

        Assert.Equal(expected, result);
    }  
    
    [Theory]
    [InlineData(new[] { 0, 1, 0, 1, 1 }, 5)]
    public void PassingCars(int[] A, int expected)
    {
        var sut = new Codility();

        var result = sut.PassingCars(A);

        Assert.Equal(expected, result);
    }  
    
    [Theory]
    [InlineData(new[] { 4, 1, 3, 2 }, 1)]
    [InlineData(new[] { 1, 3, 2 }, 1)]
    [InlineData(new[] { 4, 1, 3 }, 0)]
    [InlineData(new[] { 4, 1, 2 }, 0)]
    [InlineData(new[] { 4, 1, 3, 2, 6 }, 0)]
    public void Permutation(int[] A, int expected)
    {
        var sut = new Codility();

        var result = sut.Permutation(A);

        Assert.Equal(expected, result);
    }  
    
    [Theory]
    [InlineData("{[()()]}", 1)]
    [InlineData("([)()]", 0)]
    public void ValidBrackets(string S, int expected)
    {
        var sut = new Codility();

        var result = sut.ValidBrackets(S);

        Assert.Equal(expected, result);
    }  
    
    [Theory]
    [InlineData("(()(())())", 1)]
    [InlineData("((()())()())(())())", 0)]
    [InlineData("())", 0)]
    [InlineData("()", 1)]
    [InlineData("(())", 1)]
    [InlineData("", 1)]
    [InlineData(")(", 0)]
    public void IsValidParentheses(string S, int expected)
    {
        var sut = new Codility();

        var result = sut.ValidParentheses(S);

        Assert.Equal(expected, result);
    }   
    
    [Theory]
    [InlineData(new[] { 1, 2, 3, 4 }, 4, new[]{ 1, 2, 3, 4 })]
    [InlineData(new[] { 3, 8, 9, 7, 6 }, 3, new[]{ 9, 7, 6, 3, 8 })]
    [InlineData(new[] { 0, 0, 0 }, 1, new[]{ 0, 0, 0 })]
    [InlineData(new[] { 1 }, 1, new[]{ 1 })]
    [InlineData(new[] { 1, 2 }, 1, new[]{ 2, 1 })]
    [InlineData(new int [] {}, 1, new int[]{ })]
    public void CyclingRotate(int[] nums, int k, int[] expected)
    {
        var sut = new Codility();

        var result = sut.CyclingRotate(nums, k);

        Assert.Equal(expected, result);
    }   
    
    [Theory]
    [InlineData(new[] { 9, 3, 9, 3, 9, 7, 9 }, 7)]
    [InlineData(new[] { 42 }, 42)]
    [InlineData(new[] { 0, 0, 1 }, 1)]
    [InlineData(new[] { 0, 1, 0 }, 1)]
    [InlineData(new[] { 1, 0, 0 }, 1)]
    [InlineData(new[] { 1, 1, 4, 2, 4, 2, 3 }, 3)]
    public void FindOddNumber(int[] nums, int expected)
    {
        var sut = new Codility();

        var result = sut.FindOddNumber(nums);
        var result2 = sut.FindOddNumber2(nums);

        Assert.Equal(expected, result);
        Assert.Equal(expected, result2);
    }    
}