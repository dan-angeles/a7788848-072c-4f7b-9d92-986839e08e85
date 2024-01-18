using IncreasingSubsequence.Data.Services;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Moq;
using Xunit;

namespace IncreasingSubsequence.Tests;

public class SequenceServiceTests
{

    private readonly SequenceService service;
    private readonly Mock<SequenceService> _service;
    public SequenceServiceTests()
    {
        this._service = new Mock<SequenceService>();
        service = this._service.Object;
    }
    [Fact]
    public void TestCase1()
    {
        List<string> sequences = new List<string>();
        sequences.Add("1 5 9");

        Assert.Equal("1 5 9",service.GetLongestIncNumSeq(sequences));
    }

    [Fact]
    public void TestCase2()
    {
        List<string> sequences = new List<string>();
        sequences.Add("1710 2461 9288 10195 10431 12485");

        Assert.Equal("1710 2461 9288 10195 10431 12485", service.GetLongestIncNumSeq(sequences));
    }
    
    [Fact]
    public void TestCase3()
    {
        List<string> sequences = new List<string>();
        sequences.Add("10298 10897 12291 15037 18446 23435 25333 27266");

        Assert.Equal("10298 10897 12291 15037 18446 23435 25333 27266", service.GetLongestIncNumSeq(sequences));
    }

    [Fact]
    public void TestCase4()
    {
        List<string> sequences = new List<string>();
        sequences.Add("3862 16353 22813 28735");

        Assert.Equal("3862 16353 22813 28735", service.GetLongestIncNumSeq(sequences));
    }

    [Fact]
    public void TestCase5()
    {
        List<string> sequences = new List<string>();
        sequences.Add("11084 11970 24975 30922");

        Assert.Equal("11084 11970 24975 30922", service.GetLongestIncNumSeq(sequences));
    }

    [Fact]
    public void TestCase6()
    {
        List<string> sequences = new List<string>();
        sequences.Add("3808 3908 10386 19306");

        Assert.Equal("3808 3908 10386 19306", service.GetLongestIncNumSeq(sequences));
    }

    [Fact]
    public void TestCase7()
    {
        List<string> sequences = new List<string>();
        sequences.Add("125 1841 5882 18464 28317 31497");

        Assert.Equal("125 1841 5882 18464 28317 31497", service.GetLongestIncNumSeq(sequences));
    }

    [Fact]
    public void TestCase8()
    {
        List<string> sequences = new List<string>();
        sequences.Add("9139 17687 25106 26202 27592 30937");

        Assert.Equal("9139 17687 25106 26202 27592 30937", service.GetLongestIncNumSeq(sequences));
    }

    [Fact]
    public void TestCase9()
    {
        List<string> sequences = new List<string>();
        sequences.Add("918 1089 5133 7725 18035 24605 26716 27095");

        Assert.Equal("918 1089 5133 7725 18035 24605 26716 27095", service.GetLongestIncNumSeq(sequences));
    }

    [Fact]
    public void TestCase10()
    {
        List<string> sequences = new List<string>();
        sequences.Add("2 4 6");

        Assert.Equal("2 4 6", service.GetLongestIncNumSeq(sequences));
    }

    [Fact]
    public void TestCase11()
    {
        List<string> sequences = new List<string>();
        sequences.Add("1 5 9");

        Assert.Equal("1 5 9", service.GetLongestIncNumSeq(sequences));
    }
}