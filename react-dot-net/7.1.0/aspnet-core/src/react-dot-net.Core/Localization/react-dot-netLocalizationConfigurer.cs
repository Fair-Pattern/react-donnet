using Abp.Configuration.Startup;
using Abp.Localization.Dictionaries;
using Abp.Localization.Dictionaries.Xml;
using Abp.Reflection.Extensions;

namespace react-dot-net.Localization
{
    public static class react-dot-netLocalizationConfigurer
    {
        public static void Configure(ILocalizationConfiguration localizationConfiguration)
        {
            localizationConfiguration.Sources.Add(
                new DictionaryBasedLocalizationSource(react-dot-netConsts.LocalizationSourceName,
                    new XmlEmbeddedFileLocalizationDictionaryProvider(
                        typeof(react-dot-netLocalizationConfigurer).GetAssembly(),
                        "react-dot-net.Localization.SourceFiles"
                    )
                )
            );
        }
    }
}
