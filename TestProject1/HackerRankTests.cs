using WebApplication1.Services;

namespace TestProject1
{
    public class HackerRankTests
    {
        [Theory]
        [InlineData("abc", "YES")]
        [InlineData("abccba", "YES")]
        [InlineData("abcacba", "YES")]
        [InlineData("aabbcc", "YES")]
        [InlineData("aabbc", "YES")]
        [InlineData("abcdefghij", "YES")]
        [InlineData("aaaaabbbbbcccccddddde", "YES")]
        [InlineData("abccc", "NO")]
        [InlineData("aabbcd", "NO")]
        public void SameNumberOfTimes(string input, string expected)
        {
            var sut = new HackerRank();

            var result = sut.SameNumberOfTimes(input);

            Assert.Equal(expected, result);
        }

        [Theory]
        [InlineData(new[] { 100, 100, 50, 40, 40, 20, 10 }, new[] { 5, 25, 50, 120 }, new[] { 6, 4, 2, 1 })]
        public void DenseRank(int[] A, int[] B, int[] expected)
        {
            var sut = new HackerRank();

            var result = sut.DenseRank(A, B);

            Assert.Equal(expected, result);
        }
    }
}
