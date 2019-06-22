namespace SourceLinkTestLib
{
    public class HappyEchoService
    {
        public string Echo(string text)
        {
            var happinessGenerator = new HappinessGenerator();
            string happiness = happinessGenerator.GenerateHappiness();

            return $"{happiness} {text} {happiness}";
        }
    }
}
