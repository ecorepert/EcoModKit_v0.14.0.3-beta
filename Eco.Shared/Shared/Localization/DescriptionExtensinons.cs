// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Localization.DescriptionExtensinons
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.View;
using System.Collections.Generic;

#nullable enable
namespace Eco.Shared.Localization;

public static class DescriptionExtensinons
{
  /// <summary> Gets ViewClassInfo's display name and tags. </summary>
  public static (
  #nullable disable
  string DisplayName, IEnumerable<string> Tags) GetNamesAndTags(this ViewClassInfo info);

  /// <summary> Gets display name and tags of every ViewClassInfo in the collection. </summary>
  public static IEnumerable<(string DisplayName, IEnumerable<string> Tags)> GetNamesAndTagsFromViews(
    this IEnumerable<object> views);
}
