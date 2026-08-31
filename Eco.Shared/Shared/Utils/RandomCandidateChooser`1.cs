// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.RandomCandidateChooser`1
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;

#nullable disable
namespace Eco.Shared.Utils;

/// <summary>
/// Random Candidate Chooser from unknown size number of candidates.
/// As soon as first candidate tested it will be auto-winner, but also it will randomly select next winner index and reset candidate counter.
/// As soon as we have candidate with selected winner index it will replace previous winner and we select next winner index.
/// It uses some adjustments to make replacement more often for low number of elements and less often as number of elements growth.
/// 
/// This algorithm is adaptation of https://en.wikipedia.org/wiki/Reservoir_sampling for k = 1.
/// </summary>
public class RandomCandidateChooser<T>
{
  /// <summary> Current winner. Should be selected by <see cref="M:Eco.Shared.Utils.RandomCandidateChooser`1.TestCandidate(`0)" />. </summary>
  public T Winner { get; }

  public RandomCandidateChooser(Random random);

  /// <summary> Test the <paramref name="candidate" /> if it is the next winner. Updates <see cref="P:Eco.Shared.Utils.RandomCandidateChooser`1.Winner" /> if test succeed. </summary>
  public bool TestCandidate(T candidate);
}
