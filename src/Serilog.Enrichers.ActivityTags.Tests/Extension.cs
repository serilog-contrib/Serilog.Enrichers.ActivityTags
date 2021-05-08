using Serilog.Events;

namespace Serilog.Enrichers.ActivityTags.Tests
{
    internal static class Extensions
    {
        public static object LiteralValue(this LogEventPropertyValue @this)
        {
            return ((ScalarValue)@this).Value;
        }
    }
}
