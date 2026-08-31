// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Elections.ElectionResult
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Players;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Civics.Elections;

[Serialized]
public class ElectionResult
{
  [Serialized]
  public SimpleResult[] SimpleResults;
  /// <summary>Data about all votes, filled in on-demand.</summary>
  public LocString CachedAllVotes;
  public float YesVotes;
  public float NoVotes;

  /// <summary>Each voting round, sorted in descending order based on final results.</summary>
  [Serialized]
  public RoundsForChoice[] RoundResultsForEachChoice { get; set; }

  [Serialized]
  public User[] Voters { get; set; }

  [Serialized]
  public ElectionChoiceID[] WinningChoices { get; set; }

  [Serialized]
  public string[] WinningChoiceNames { get; set; }

  [Serialized]
  public bool Vetoed { get; set; }

  [Serialized]
  public User Vetoer { get; set; }

  [Serialized]
  public bool Finished { get; set; }

  [Serialized]
  public bool Tied { get; set; }

  [Serialized]
  public string Description { get; set; }

  [Serialized]
  public User[] WinningUsers { get; set; }

  [Serialized]
  public User[] LosingUsers { get; set; }

  [Serialized]
  public bool Passed { get; set; }
}
