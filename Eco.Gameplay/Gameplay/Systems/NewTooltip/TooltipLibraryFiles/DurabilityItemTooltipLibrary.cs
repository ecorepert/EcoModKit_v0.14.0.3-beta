// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.NewTooltip.TooltipLibraryFiles.DurabilityItemTooltipLibrary
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.PropertyHandling;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using System;

#nullable disable
namespace Eco.Gameplay.Systems.NewTooltip.TooltipLibraryFiles;

[TooltipLibrary]
public static class DurabilityItemTooltipLibrary
{
  public static void Initialize();

  [TooltipAffectedBy(typeof (WorldObjectItem), "Durability", null, null)]
  [TooltipAffectedBy(typeof (DurabilityItem), "DurabilityPercent", null, null)]
  [TooltipAffectedBy(typeof (RepairableItem), "IntegrityAmount", null, null)]
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance | CacheAs.User, 11, TTCat.Controls, TTFlags.ClearCacheForAllUsers | TTFlags.ForceInstantUpdate, null, new Type[] {})]
  public static LocString TooltipDurability(this DurabilityItem durItem, User user);
}
