using WebApplication1.Services;

namespace TestProject1;

public class InterviewsTests
{
    [Theory]
    [InlineData(1, 1, 1)]
    public void Test_Case(int a, int b, int expected)
    {
        var sut = new TomTom();

        var actual = sut.Solution();

        Assert.Equal(expected, actual);
    }

    //[Theory]
    //[InlineData(10, 10, 5)]
    //[InlineData(20, 20, 10)]
    //[InlineData(10, 21, 7)]
    //[InlineData(21, 10, 7)]
    //[InlineData(13, 11, 5)]
    //[InlineData(11, 13, 5)]
    //[InlineData(15, 5, 5)]
    //[InlineData(80, 18, 20)]
    //[InlineData(18, 80, 20)]
    //[InlineData(44, 10, 11)]
    //[InlineData(10, 48, 12)]
    //[InlineData(100000, 100000, 50000)]
    //public void Test_Case(int a, int b, int expected)
    //{
    //    var sut = new CompanyT();

    //    var actual = sut.solution(a, b);

    //    Assert.Equal(expected, actual);
    //}


    //[Theory]
    //[InlineData("-H-HH--", 2)]
    //[InlineData("-H-HH--H", 3)]
    //[InlineData("HH-HH--H", -1)]
    //[InlineData("H-HH-HH", -1)]
    //[InlineData("-H-HHH-H", -1)]
    //[InlineData("HH-HH", -1)]
    //public void Test_Case_1(string s, int expected)
    //{
    //    var sut = new CompanyT1();

    //    var actual = sut.solution(s);

    //    Assert.Equal(expected, actual);
    //}

    //[Theory]
    //[InlineData("bat", "t a")]
    //public void Test_Invert_String(string s, string expected)
    //{
    //    var sut = new CompanyT2();

    //    var actual = sut.solution(s);

    //    Assert.Equal(expected, actual);
    //}

    // [Theory]
    // [InlineData(
    //     new string[] { "16.87.135.129", "60.87.135.129", "130.87.135.129", "180.87.135.129", "225.87.135.129" }, 
    //     new int[] { 1, 2, 3, 4, 5 })]
    // [InlineData(
    //     new string[] { "278.87.135.129", "60.567.135.129", "130.873.135.129", "180.827.135.129", "225.587.135.129" },
    //     new int[] { -1, -1, -1, -1, -1 })]
    // public void Test_Find_Ip_Region(string[] listOfIps, int[] expected)
    // {
    //     var sut = new CompanyT2();

    //     var actual = sut.FindIpRegion(listOfIps);

    //     Assert.Equal(expected, actual);
    // }
}