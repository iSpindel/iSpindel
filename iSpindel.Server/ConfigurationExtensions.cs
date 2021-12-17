namespace iSpindel.Server
{
    public static class ConfigurationExtensions
    {
        public static T GetSanitizedValue<T>(this IConfigurationRoot configurationRoot, string configKey, T defaultValue = default)
        {
            if (configurationRoot is null)
            {
                throw new ArgumentNullException(nameof(configurationRoot));
            }

            if (string.IsNullOrEmpty(configKey))
            {
                throw new ArgumentException($"\"{nameof(configKey)}\" kann nicht NULL oder leer sein.", nameof(configKey));
            }

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
    }
}
