using WebApplication1.Services;

namespace TestProject1;

public class CodilityTests
{
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