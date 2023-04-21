using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Direct.Shared;
using LanguageIdentification;
using log4net;

namespace NICE_LanguageUtils
{
    [DirectSealed]
    [DirectDom("Language Utils", "General")]
    [ParameterType(false)]
    public static class LanguageUtils
    {
        private static readonly ILog _log = LogManager.GetLogger("LibraryObjects");

        [DirectDom("Identify Text Language")]
        [DirectDomMethod("Identify Language of {Text}. Languages Profiles: {Languages Profiles}, Language Idenitification Method: {Language Idenitification Method}")]
        [MethodDescription("Identifies text language")]
        public static LanguageIdentificationResult GetTextLanguage(string text, string lanProfilesPath, int lanIdentificationMethod) 
        {
            if (string.IsNullOrEmpty(text))
            {
                _log.Error("NICE-LanguageUtils: Text to recognize is empty");
            }

            if (string.IsNullOrEmpty(lanProfilesPath))
            {
                _log.Error("NICE-LanguageUtils: Languages profiles path is empty");
            }

            if (lanIdentificationMethod == 0 || lanIdentificationMethod > 4)
            {
                _log.Error("NICE-LanguageUtils: Only numbers 1 to 4 are supported for language identification method");
            }

            if (_log.IsDebugEnabled)
            {
                _log.Debug("NICE-LanguageUtils: Getting identification method");
            }

            string identificationMethod = GetIdentificationMethod(lanIdentificationMethod);

            try
            {
                if (_log.IsDebugEnabled)
                {
                    _log.Debug("NICE-LanguageUtils: Building Language Identifier");
                }

                LanguageIdentifier languageIdentifier = LanguageIdentifier.New(lanProfilesPath, identificationMethod, -1);

                if (_log.IsDebugEnabled)
                {
                    _log.Debug("NICE-LanguageUtils: Identifying language of text");
                }
                string identificationResult = languageIdentifier.Identify(text);

                CultureInfo culture = new CultureInfo(identificationResult);


                if (_log.IsDebugEnabled)
                {
                    _log.Debug("NICE-LanguageUtils: Returning result");
                }

                return new LanguageIdentificationResult()
                {
                    EnglishName = culture.EnglishName,
                    NativeName = culture.NativeName,
                    TwoLetterName = culture.TwoLetterISOLanguageName,
                    ThreeLetterName = culture.ThreeLetterISOLanguageName,
                };

            }
            catch (Exception e)
            {
                _log.Error("NICE-LanguageUtils: Unexpected error", e);
                return new LanguageIdentificationResult();
            }
        }

        private static string GetIdentificationMethod(int method)
        {
            switch (method) 
            {
                case 1:
                    return "Vector";
                case 2:
                    return "Likely";
                case 3:
                    return "Rank,sf";
                case 4:
                    return "Rank,sr";
                default:
                    return "";
            }
        }
    }
}
