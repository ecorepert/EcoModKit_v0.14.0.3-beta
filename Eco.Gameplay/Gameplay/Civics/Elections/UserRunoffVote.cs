// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Elections.UserRunoffVote
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Players;
using Eco.Shared.Serialization;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Civics.Elections;

[Serialized]
public struct UserRunoffVote
{
  [Serialized]
  public readonly int VoterID { get; }

  [Serialized]
  public ElectionChoiceID[] RankedVotes { get; set; }

  public UserRunoffVote();

  public UserRunoffVote(User user, params ElectionChoiceID[] votes);

  public User Voter { get; }

  /// <summary>Find the first entry chosen of the remaining options.</summary>
  public ElectionChoiceID TopChoiceOfRemaining(HashSet<ElectionChoiceID> availableOptions);
}
