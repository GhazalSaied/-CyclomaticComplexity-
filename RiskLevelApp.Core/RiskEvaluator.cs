namespace RiskLevelApp.Core;
public static class RiskEvaluator
{
    static string GetRiskLevel(int age, bool smoker, bool hasCondition)
    {
        if (age < 18)
            return "Low";
        if (age >= 18 && age < 40)
        {
            if (smoker)
            {
                if (hasCondition)
                    return "Medium";
                else
                    return "Low";
            }
            else
            {
                if (hasCondition)
                    return "Medium";
                else
                    return "Low";
            }
        }
        if (age >= 40)
        {
            if (smoker && hasCondition)
                return "High";
            else if (smoker || hasCondition)
                return "Medium";
            else
                return "Low";
        }
        return "Unknown";
    }
}