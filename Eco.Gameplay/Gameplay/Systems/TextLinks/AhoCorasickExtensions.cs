// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.TextLinks.AhoCorasickExtensions
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Ganss.Text;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Systems.TextLinks;

internal static class AhoCorasickExtensions
{
  /// <summary>
  /// Performs Aho-Corasick search on a query and applies post-processing steps:
  /// <list type="bullet">
  /// <item><description>Remove matches with invalid neighbors. See <see cref="M:Eco.Gameplay.Systems.TextLinks.WordMatchExtensions.ValidNeighbors(Ganss.Text.WordMatch,System.String)" /> </description></item>
  /// <item><description>Remove matches that aren't in <paramref name="valid" />. Aho-Corasick doesn't allow keyword removal so this <see cref="T:System.Collections.Generic.IDictionary`2" /> must keep track of the valid keywords </description></item>
  /// <item><description>Combine overlapping matches, keeping the longest one. </description></item>
  /// </list>
  /// </summary>
  public static 
  #nullable disable
  IEnumerable<WordMatch> WholeSearch<T>(
    this AhoCorasick ac,
    string query,
    IDictionary<string, T> valid);
}
