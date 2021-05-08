using System;
using System.Diagnostics;
using Serilog.Configuration;

namespace Serilog.Enrichers.ActivityTags
{
   

    /// <summary>
    /// <see cref="LoggerEnrichmentConfiguration"/> extension methods.
    /// </summary>
    public static class LoggerEnrichmentConfigurationExtensions
    {
        /// <summary>
        /// Enrich logger output with span information from the current <see cref="Activity"/>.
        /// </summary>
        /// <param name="loggerEnrichmentConfiguration">The enrichment configuration.</param>
        /// <returns>Configuration object allowing method chaining.</returns>
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
