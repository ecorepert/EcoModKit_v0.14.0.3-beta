// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.TextLinks.ObjectFinderUtils
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using System.Linq;
using System.Text.RegularExpressions;

#nullable disable
namespace Eco.Gameplay.Systems.TextLinks;

internal static class ObjectFinderUtils
{
  /// <summary>
  /// Create a regex that searches for an occurrence of 'regex' that is not adjacent to word characters
  /// on either side (if regex="axe", match "axe" or "axe?" but not "axer").
  /// </summary>
  public static Regex ToWordRegex(string regex);

  /// <summary>
  /// Create a regex that searches for an occurrence of any word in 'words' that is not adjacent to word characters
  /// on either side (if regex="axe", match "axe" or "axe?" but not "axer").
  /// </summary>
  public static Regex ToWordRegex(IOrderedEnumerable<string> words);
}
