// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.TextLinks.WordMatchExtensions
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Ganss.Text;

#nullable disable
namespace Eco.Gameplay.Systems.TextLinks;

internal static class WordMatchExtensions
{
  /// <summary>
  /// Checks if two <see cref="T:Ganss.Text.WordMatch" /> overlap. Two <see cref="T:Ganss.Text.WordMatch" /> overlap when their intervals [<see cref="P:Ganss.Text.WordMatch.Index" />, <see cref="P:Ganss.Text.WordMatch.Index" /> + <see cref="P:Ganss.Text.WordMatch.Word" />.length] in the query string overlap.
  /// </summary>
  public static bool Overlaps(this WordMatch match1, WordMatch match2);

  /// <summary>
  /// Merges two <see cref="T:Ganss.Text.WordMatch" /> and keeps the longest <see cref="P:Ganss.Text.WordMatch.Word" />
  /// </summary>
  public static WordMatch MergeWith(this WordMatch match1, WordMatch match2);

  /// <summary>
  /// Checks if a <see cref="T:Ganss.Text.WordMatch" /> has valid neighbors in the query test. To be valid the <see cref="T:Ganss.Text.WordMatch" /> must not be encompassed by <see cref="M:System.Char.IsLetterOrDigit(System.Char)" /> on either side
  /// </summary>
  public static bool ValidNeighbors(this WordMatch match, string query);
}
