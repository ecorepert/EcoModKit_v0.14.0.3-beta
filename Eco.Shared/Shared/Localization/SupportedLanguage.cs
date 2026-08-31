// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Localization.SupportedLanguage
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.ComponentModel;

#nullable disable
namespace Eco.Shared.Localization;

[TypeConverter(typeof (SupportedLanguageConverter))]
public enum SupportedLanguage
{
  [NotLocalizedDisplayName("English")] English = 1,
  [NotLocalizedDisplayName("Gibberish")] Gibberish = 2,
  [NotLocalizedDisplayName("Français")] French = 3,
  [NotLocalizedDisplayName("Español")] Spanish = 4,
  [NotLocalizedDisplayName("Deutsch")] German = 5,
  [NotLocalizedDisplayName("한국어")] Korean = 6,
  [NotLocalizedDisplayName("Português (Brasil)")] BrazilianPortuguese = 7,
  [NotLocalizedDisplayName("汉语")] SimplifedChinese = 8,
  [NotLocalizedDisplayName("Русский")] Russian = 9,
  [NotLocalizedDisplayName("Italiano")] Italian = 10, // 0x0000000A
  [NotLocalizedDisplayName("Português")] Portuguese = 11, // 0x0000000B
  [NotLocalizedDisplayName("Magyar")] Hungarian = 12, // 0x0000000C
  [NotLocalizedDisplayName("日本語")] Japanese = 13, // 0x0000000D
  [NotLocalizedDisplayName("Norsk")] Norwegian = 14, // 0x0000000E
  [NotLocalizedDisplayName("Polski")] Polish = 15, // 0x0000000F
  [NotLocalizedDisplayName("Nederlands")] Dutch = 16, // 0x00000010
  [NotLocalizedDisplayName("Română")] Romanian = 17, // 0x00000011
  [NotLocalizedDisplayName("Dansk")] Danish = 18, // 0x00000012
  [NotLocalizedDisplayName("Český Jazyk")] Czech = 19, // 0x00000013
  [NotLocalizedDisplayName("Svenska")] Swedish = 20, // 0x00000014
  [NotLocalizedDisplayName("Українська")] Ukrainian = 21, // 0x00000015
  [NotLocalizedDisplayName("Ελληνικά")] Greek = 22, // 0x00000016
  [NotLocalizedDisplayName("عربى")] Arabic = 23, // 0x00000017
  [NotLocalizedDisplayName("Tiếng Việt")] Vietnamese = 24, // 0x00000018
  [NotLocalizedDisplayName("Türk")] Turkish = 25, // 0x00000019
}
