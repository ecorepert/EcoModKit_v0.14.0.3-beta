// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.NewTooltip.TooltipLibraryFiles.CraftingComponentTooltipLibrary
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.PropertyHandling;
using Eco.Gameplay.Components;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using System;

#nullable disable
namespace Eco.Gameplay.Systems.NewTooltip.TooltipLibraryFiles;

[TooltipLibrary]
public static class CraftingComponentTooltipLibrary
{
  public static void Initialize();

  [TooltipAffectedBy("WorkOrders", null, null)]
  [TooltipAffectedBy("WorkOrders", "CurrentRecipe", null)]
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 100, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString TooltipWorkOrders(this CraftingComponent craftingComponent);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Disabled, 101, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString GarbageAccumulatorTooltip(this CraftingComponent craftingComponent);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Disabled, 100, TTCat.Controls, TTFlags.None, null, new Type[] {})]
  public static LocString OwnershipTooltip(this WorkOrder workOrder, User user);
}
