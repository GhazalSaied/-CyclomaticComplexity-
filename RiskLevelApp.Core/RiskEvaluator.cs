namespace RiskLevelApp.Core;

public static class RiskEvaluator
{
    public static string GetRiskLevel(int age, bool smoker, bool hasCondition)
    {
        if (IsChild(age))
            return "Low";
        if (IsYoungAdult(age))
            return EvaluateYoungAdult(hasCondition);
        if (IsOlder(age))
            return EvaluateOlder(smoker, hasCondition);
        return "Unknown";
    }
    private static bool IsChild(int age) => age > 0 && age < 18;
    private static bool IsYoungAdult(int age) => age >= 18 && age < 40;
    private static bool IsOlder(int age) => age >= 40;
    private static string EvaluateYoungAdult(bool hasCondition)
    {
        return (hasCondition) ? "Medium" : "Low";
    }
    private static string EvaluateOlder(bool smoker, bool hasCondition)
    {
        if (smoker && hasCondition)
            return "High";
        if (smoker || hasCondition)
            return "Medium";
        return "Low";
    }
}