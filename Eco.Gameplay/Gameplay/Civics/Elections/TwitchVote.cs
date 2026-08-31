// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Elections.TwitchVote
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Civics.Elections;

/// <summary>A vote from a twitch user. They dont do runoff voting, just a single selection.</summary>
[Serialized]
public struct TwitchVote
{
  [Serialized]
  public ElectionChoiceID ChoiceID;
  [Serialized]
  public bool Subscriber;
  [Serialized]
  public string UserName;

  public TwitchVote();

  public float Weight(ElectionProcess process);
}
