// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.DevtoolItem
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Gameplay.DynamicValues;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.SharedTypes;
using System;

#nullable disable
namespace Eco.Mods.TechTree;

[Serialized]
[LocDisplayName("Dev Tool")]
[LocDescription("DOES CHEATER THINGS THROUGH CHEATING POWERS!")]
[Eco.Gameplay.Items.IgnoreAuth]
[BuilderCheat]
[Eco.Gameplay.Items.Tier(10f, false)]
[System.ComponentModel.Category("Hidden")]
public class DevtoolItem : HammerItem
{
  public override IDynamicValue CaloriesBurn { get; }

  public override IDynamicValue SkilledRepairCost { get; }

  public override IDynamicValue Tier { get; }

  public override bool Decays { get; }

  [RPC]
  public void Smite(Player player, InteractionTriggerInfo trigger, InteractionTarget target);

  [RPC]
  public void Sample(Player player, InteractionTarget target, bool maxAmount = false);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Global, 200, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString ControllsTooltip();

  public override string OnUsed(Player player, ItemStack itemStack);
}
