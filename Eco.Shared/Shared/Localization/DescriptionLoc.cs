// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Localization.DescriptionLoc
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Collections.Generic;

#nullable disable
namespace Eco.Shared.Localization;

public static class DescriptionLoc
{
  /// <summary> Searches for the rarest tag that is present in every selected element. Can also determine if all elements of this tag have been selected. </summary>
  public static (string BestTag, bool All) MutualTag(
    IEnumerable<(string Name, IEnumerable<string> Tags)> entries,
    IEnumerable<(string Name, IEnumerable<string> Tags)> selectedEntries,
    HashSet<string> tagsOnEverySelection);

  /// <summary> Tries to combine entries into groups. See SearchableListUI.UpdateSlots on the client side for a demo. </summary>
  ///  // Handy converter for the client side.
  public static LocString DescribeViews(
    IEnumerable<object> views,
    IEnumerable<object> selectedViews,
    HashSet<string> tagsOnEverySelection,
    string entryDescriptionPlural);
}
