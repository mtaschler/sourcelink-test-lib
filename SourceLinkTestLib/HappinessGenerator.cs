namespace SourceLinkTestLib
{
    /// <summary>
    /// Stupid class that tests stepping into internal/private classes/methods.
    /// </summary>
    internal class HappinessGenerator
    {
        internal string GenerateHappiness()
        {
            return GetHappinessText();
        }

        private string GetHappinessText()
        {
            return ":)";
        }
    }
}
