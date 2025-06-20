
using Xunit;
using RiskLevelApp.Core; 
namespace RiskLevelApp.Tests;

public class RiskEvaluatorTests
{
    [Fact]
    public static void GetRiskLevel_Should_ReturnLow_When_AgeUnder18()

    {
        var result = RiskEvaluator.GetRiskLevel(12, false, false);
        Assert.Equal("Low", result);
    }
    [Fact]
    public static void GetRiskLevel_Should_ReturnMedium_When_YoungAdultWithCondition()
    {
        var result = RiskEvaluator.GetRiskLevel(25, false, true);
        Assert.Equal("Medium", result);
    }
    [Fact]
    public static void GetRiskLevel_Should_ReturnHigh_When_OlderSmokerAndHasCondition()
    {
        var result = RiskEvaluator.GetRiskLevel(65, true, true);
        Assert.Equal("High", result);
    }
    [Fact]
    public static void GetRiskLevel_Should_ReturnUnknown_When_AgeIsNegative()
    {
        var result = RiskEvaluator.GetRiskLevel(-1, false, false);
        Assert.Equal("Unknown", result);
    }
}
