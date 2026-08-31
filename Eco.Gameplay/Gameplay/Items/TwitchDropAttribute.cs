// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.TwitchDropAttribute
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

#nullable disable
namespace Eco.Gameplay.Items;

/// <summary>Matches an Item type to a specific reward in the Twitch drops manager.</summary>
public sealed class TwitchDropAttribute : ItemAttribute
{
  public string RewardId { get; }

  public TwitchDropAttribute(string rewardId);
}
