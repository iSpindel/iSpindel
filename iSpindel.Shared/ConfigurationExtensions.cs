using Microsoft.Extensions.Configuration;
using System;

namespace iSpindel.Shared
{
    public static class ConfigurationExtensions
    {
        /*
        public static T GetSanitizedValue<T>(this IConfigurationRoot configurationRoot, string configKey, T defaultValue = default(T))
        {
            var configEntry = configurationRoot.GetValue<T>(configKey);

            if (
                (configEntry is string strEntry && String.IsNullOrWhiteSpace(strEntry)) ||
                (configEntry == null && defaultValue == null)
             )
            {
                throw new ArgumentException($"Config key {configKey} is empty or missing and has no default value");
            }

            return configEntry ?? defaultValue;
        }
        */
    }
}
