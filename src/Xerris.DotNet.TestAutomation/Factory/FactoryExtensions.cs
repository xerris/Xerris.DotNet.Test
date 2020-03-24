namespace Xerris.DotNet.TestAutomation.Factory
{
    public static class FactoryExtensions
    {
        public static int NextId(this object item)
        {
            return FactoryGirl.UniqueId();
        }

        public static string UniqueName(this object item, string prefix = "Name")
        {
            return $"{prefix} {FactoryGirl.UniqueId()}";
        }
    }
}