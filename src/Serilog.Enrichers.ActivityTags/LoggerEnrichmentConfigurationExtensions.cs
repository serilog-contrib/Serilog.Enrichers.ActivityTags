using System;
using Serilog.Configuration;

namespace Serilog.Enrichers.ActivityTags
{
    public static class LoggerEnrichmentConfigurationExtensions
    {
        public static LoggerConfiguration WithActivityTags(this LoggerEnrichmentConfiguration loggerEnrichmentConfiguration)
        {
            if (loggerEnrichmentConfiguration is null)
            {
                throw new ArgumentNullException(nameof(loggerEnrichmentConfiguration));
            }

            return loggerEnrichmentConfiguration.With<ActivityTagsEnricher>();
        }
    }
}
