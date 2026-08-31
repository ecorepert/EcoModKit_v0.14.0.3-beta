// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Elections.VoteCounts
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Localization;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Civics.Elections;

/// <summary>Stores all the types of votes allowed. </summary>
[Serialized]
public struct VoteCounts
{
  [Serialized]
  public int UserVotes;
  [Serialized]
  public float TwitchVotes;

  public VoteCounts(int user, float twitch);

  public float Total { get; }

  public LocString Describe();
}
