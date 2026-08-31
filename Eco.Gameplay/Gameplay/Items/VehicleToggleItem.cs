// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.VehicleToggleItem
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Components;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using System;

#nullable disable
namespace Eco.Gameplay.Items;

[Serialized]
[LocDisplayName("Vehicle Tool Toggle")]
[System.ComponentModel.Category("Hidden")]
[Eco.Gameplay.Items.MaxStackSize(1)]
[LocDescription("Press to toggle digging/driving mode.")]
internal class VehicleToggleItem : Item
{
  [Serialized]
  protected VehicleToolComponent tool;

  public VehicleToggleItem(VehicleToolComponent tool);

  public VehicleToggleItem();

  public override void OnLeftClicked(Player player, ItemStack stack);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Global, 100, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString VehicleToolToggleControlsTooltip();
}
