using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace StackifySupport.Localization
{
    public static class StackifySupportLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(StackifySupportConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(StackifySupportLocalizationConfigurer).GetAssembly(),
                        "StackifySupport.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
