// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Localization.LocalizationExtractionUtils
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;
using System.Collections.Generic;
using System.Reflection;

#nullable enable
namespace Eco.Shared.Localization;

/// <summary>Utils for localization string extractions</summary>
public class LocalizationExtractionUtils
{
  /// <summary>Localization types to extract loc strings from</summary>
  /// <param name="excludeShared">Ignore shared namespace (so it doesn't get extracted twice)</param>
  public static 
  #nullable disable
  IEnumerable<TypeInfo> TypesToExtract(bool excludeShared = false);

  /// <summary>Extract localization strings from classes or enums with <see cref="T:Eco.Shared.Localization.LocalizedAttribute" /></summary>
  /// 
  ///             From classes will extract properties and/or fields
  ///             From enums will extract
  ///             <param name="type">type with attribute</param>
  /// <param name="locData">list to add new localization data</param>
  /// <param name="localizedAttr">actual attribute</param>
  /// <param name="includeFields">should also include fields</param>
  public static void ExtractLocalizedAttr(
    Type type,
    List<StringLocalizedData> locData,
    LocalizedAttribute localizedAttr,
    bool includeFields = false);

  /// <summary>Extract loc display name of type from <see cref="P:Eco.Shared.Localization.LocalizedAttribute.CustomDisplayName" /> or RemoveCamelCase</summary>
  public static string GetTypeLocName(Type type, LocalizedAttribute attr);
}
