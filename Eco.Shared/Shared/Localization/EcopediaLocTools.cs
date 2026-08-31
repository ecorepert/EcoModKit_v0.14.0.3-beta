// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Localization.EcopediaLocTools
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Collections.Generic;

#nullable disable
namespace Eco.Shared.Localization;

public static class EcopediaLocTools
{
  public static string EcopediaLocAttribute;
  public static string EcopediaCSVName;
  public static string EcopediaMainLocFolder;
  public static string EcopediaDefaultLangCode;
  public static string[] EcopediaSections;

  public static List<EcopediaFile> LoadEcopediaFiles(string targetDirectoryPath, bool translate = false);

  public static Dictionary<int, string> GetEcopediaTranslation(string path, bool isFullPath = false);

  public static string GetLocalizedFileForCurrentLang(string ecopediaRootPath);

  public static string LocalizedStringsFile(string ecopediaRootPath, string langCode);

  public static string LocalizedStringsXliffFile(string ecopediaRootPath, string langCode);
}
