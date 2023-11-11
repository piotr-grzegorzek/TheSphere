namespace Constant
{
    internal static class Error
    {
        internal static string NullWarning(string className, string methodName, string variableName)
        {
            return $"{className}.{methodName}: {variableName} is null";
        }
        internal static string TagNotFoundWarning(string className, string methodName, string tagName)
        {
            return $"{className}.{methodName}: Tag {tagName} not found";
        }
    }
}