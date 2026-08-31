// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.BoatCaptainShortsItem
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Localization;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Items;

/// <summary>
/// Temporary location for holding item / objects from server side for twitch drop rewards.
/// TODO: Migrate this to a more sensible long lasting less overhead system with a potential tech tree and scripting upgrade.
/// </summary>
[Serialized]
[System.ComponentModel.Category("Hidden")]
[NotSpawnable]
[LocDisplayName("Boat Captain Shorts")]
[LocDescription("A versatile and eye grabbing pair of shorts that are quick to dry in all situations.")]
[TwitchDrop("42c8cc8e-31f9-41a6-b036-29763880a662")]
public class BoatCaptainShortsItem : ClothingItem
{
  public override LocString DisplayNamePlural { get; }

  public override string Slot { get; }

  public override bool Starter { get; }
}
