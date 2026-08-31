// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.TreasureBackpackItem
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Items;

[Serialized]
[System.ComponentModel.Category("Hidden")]
[NotSpawnable]
[LocDisplayName("Treasure Backpack")]
[LocDescription("A backpack full of odds and ends, bits and bobs, that sort of thing.")]
[TwitchDrop("f0ab6482-5690-4ec1-9535-a3855dc3bc7e")]
public class TreasureBackpackItem : ClothingItem
{
  public override LocString DisplayNamePlural { get; }

  public override string Slot { get; }

  public override bool Starter { get; }

  public override Dictionary<UserStatType, float> GetFlatStats();
}
