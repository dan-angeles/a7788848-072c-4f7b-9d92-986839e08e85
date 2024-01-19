using IncreasingSubsequence.Data.Services;
using IncreasingSubsequence.Data.Utilities;
using IncreasingSubsequence.Tests.Utilities;
using Microsoft.AspNetCore.Authorization.Infrastructure;
using Moq;
using Xunit;

namespace IncreasingSubsequence.Tests;

public class SequenceServiceTests
{

    private readonly SequenceService service;
    private readonly Mock<SequenceService> _service;
    private readonly string testFilePath;
    private readonly string expDataFilePath;
    public SequenceServiceTests()
    {
        this._service = new Mock<SequenceService>();
        service = this._service.Object;
        testFilePath = @"TestData/";
        expDataFilePath = @"ExpectedData/";


    }

    [Fact]
    public void TestCase1()
    {
        //Get TestCase Data and pass it to a list of string
        List<string> sequences = StringTools.SplitStringToList(
               FileHandling.ReadFileToString(testFilePath + "TestCase1.txt"), " "
           );
        
        //Assign the longest increasing number sequence to a string
        string actualData = service.GetLongestIncNumSeq(sequences);
        
        //Get expected data
        string expectedData = FileHandling.ReadFileToString(expDataFilePath + "TestCase1_ExpData.txt");

        //Test
        Assert.Equal(expectedData, actualData);
    }

    [Fact]
    public void TestCase2()
    {
        //Get TestCase Data and pass it to a list of string
        List<string> sequences = StringTools.SplitStringToList(
               FileHandling.ReadFileToString(testFilePath + "TestCase2.txt"), " "
           );
        
        //Assign the longest increasing number sequence to a string
        string actualData = service.GetLongestIncNumSeq(sequences);
        
        //Get expected data
        string expectedData = FileHandling.ReadFileToString(expDataFilePath + "TestCase2_ExpData.txt");

        //Test
        Assert.Equal(expectedData, actualData);
    }

    [Fact]
    public void TestCase3()
    {
        //Get TestCase Data and pass it to a list of string
        List<string> sequences = StringTools.SplitStringToList(
               FileHandling.ReadFileToString(testFilePath + "TestCase3.txt"), " "
           );
        
        //Assign the longest increasing number sequence to a string
        string actualData = service.GetLongestIncNumSeq(sequences);
        
        //Get expected data
        string expectedData = FileHandling.ReadFileToString(expDataFilePath + "TestCase3_ExpData.txt");

        //Test
        Assert.Equal(expectedData, actualData);
    }

    [Fact]
    public void TestCase4()
    {
        //Get TestCase Data and pass it to a list of string
        List<string> sequences = StringTools.SplitStringToList(
               FileHandling.ReadFileToString(testFilePath + "TestCase4.txt"), " "
           );
        
        //Assign the longest increasing number sequence to a string
        string actualData = service.GetLongestIncNumSeq(sequences);
        
        //Get expected data
        string expectedData = FileHandling.ReadFileToString(expDataFilePath + "TestCase4_ExpData.txt");
        
        //Test
        Assert.Equal(expectedData, actualData);
    }

    [Fact]
    public void TestCase5()
    {
        //Get TestCase Data and pass it to a list of string
        List<string> sequences = StringTools.SplitStringToList(
               FileHandling.ReadFileToString(testFilePath + "TestCase5.txt"), " "
           );
        
        //Assign the longest increasing number sequence to a string
        string actualData = service.GetLongestIncNumSeq(sequences);
        
        //Get expected data
        string expectedData = FileHandling.ReadFileToString(expDataFilePath + "TestCase5_ExpData.txt");
        
        //Test
        Assert.Equal(expectedData, actualData);
    }

    [Fact]
    public void TestCase6()
    {
        //Get TestCase Data and pass it to a list of string
        List<string> sequences = StringTools.SplitStringToList(
               FileHandling.ReadFileToString(testFilePath + "TestCase6.txt"), " "
           );

        //Assign the longest increasing number sequence to a string
        string actualData = service.GetLongestIncNumSeq(sequences);

        //Get expected data
        string expectedData = FileHandling.ReadFileToString(expDataFilePath + "TestCase6_ExpData.txt");

        //Test
        Assert.Equal(expectedData, actualData);
    }

    [Fact]
    public void TestCase7()
    {
        //Get TestCase Data and pass it to a list of string
        List<string> sequences = StringTools.SplitStringToList(
               FileHandling.ReadFileToString(testFilePath + "TestCase7.txt"), " "
           );

        //Assign the longest increasing number sequence to a string
        string actualData = service.GetLongestIncNumSeq(sequences);

        //Get expected data
        string expectedData = FileHandling.ReadFileToString(expDataFilePath + "TestCase7_ExpData.txt");

        //Test
        Assert.Equal(expectedData, actualData);
    }

    [Fact]
    public void TestCase8()
    {
        //Get TestCase Data and pass it to a list of string
        List<string> sequences = StringTools.SplitStringToList(
               FileHandling.ReadFileToString(testFilePath + "TestCase8.txt"), " "
           );

        //Assign the longest increasing number sequence to a string
        string actualData = service.GetLongestIncNumSeq(sequences);

        //Get expected data
        string expectedData = FileHandling.ReadFileToString(expDataFilePath + "TestCase8_ExpData.txt");

        //Test
        Assert.Equal(expectedData, actualData);
    }

    [Fact]
    public void TestCase9()
    {
        //Get TestCase Data and pass it to a list of string
        List<string> sequences = StringTools.SplitStringToList(
               FileHandling.ReadFileToString(testFilePath + "TestCase9.txt"), " "
           );

        //Assign the longest increasing number sequence to a string
        string actualData = service.GetLongestIncNumSeq(sequences);

        //Get expected data
        string expectedData = FileHandling.ReadFileToString(expDataFilePath + "TestCase9_ExpData.txt");

        //Test
        Assert.Equal(expectedData, actualData);
    }

    [Fact]
    public void TestCase10()
    {
        //Get TestCase Data and pass it to a list of string
        List<string> sequences = StringTools.SplitStringToList(
               FileHandling.ReadFileToString(testFilePath + "TestCase10.txt"), " "
           );

        //Assign the longest increasing number sequence to a string
        string actualData = service.GetLongestIncNumSeq(sequences);

        //Get expected data
        string expectedData = FileHandling.ReadFileToString(expDataFilePath + "TestCase10_ExpData.txt");

        //Test
        Assert.Equal(expectedData, actualData);
    }

    [Fact]
    public void TestCase11()
    {
        //Get TestCase Data and pass it to a list of string
        List<string> sequences = StringTools.SplitStringToList(
               FileHandling.ReadFileToString(testFilePath + "TestCase11.txt"), " "
           );

        //Assign the longest increasing number sequence to a string
        string actualData = service.GetLongestIncNumSeq(sequences);

        //Get expected data
        string expectedData = FileHandling.ReadFileToString(expDataFilePath + "TestCase11_ExpData.txt");

        //Test
        Assert.Equal(expectedData, actualData);
    }
}