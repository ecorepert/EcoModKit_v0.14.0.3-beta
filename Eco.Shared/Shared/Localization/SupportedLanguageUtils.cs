// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Localization.SupportedLanguageUtils
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Collections.Generic;

#nullable disable
namespace Eco.Shared.Localization;

public static class SupportedLanguageUtils
{
  public static Dictionary<SupportedLanguage, string> DictToCrowdinLangCode;
  /// <summary>
  /// Table for converting eco lang to .NET culture codes for use with external ASP.NET restful services.
  /// A complete list of supported CultureInfo codes can be found here:
  /// https://docs.microsoft.com/en-us/bingmaps/rest-services/common-parameters-and-types/supported-culture-codes
  /// </summary>
  public static Dictionary<SupportedLanguage, string> DictToCultureLangCode;
  /// <summary>
  /// Table for converting eco lang to ISO 639-1 language codes for use with external services.</summary>
  public static Dictionary<SupportedLanguage, string> DictToISOLangCode;

  public static SupportedLanguage Parse(string s);

  public static string ToCrowdinLangCode(this SupportedLanguage lang);

  public static string ToCultureLangCode(this SupportedLanguage lang);

  public static string ToISOLangCode(this SupportedLanguage lang);

  public static SupportedLanguage GetLanguageFromSteamOrISOLangCode(string langCode);
}
