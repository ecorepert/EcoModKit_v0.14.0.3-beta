// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.NewTooltip.TooltipLibraryFiles.WorldObjectsTooltipLibrary
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.PropertyHandling;
using Eco.Gameplay.Objects;
using Eco.Mods.TechTree;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using System;

#nullable disable
namespace Eco.Gameplay.Systems.NewTooltip.TooltipLibraryFiles;

[TooltipLibrary]
public static class WorldObjectsTooltipLibrary
{
  public static void Initialize();

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.SubType, 0, TTCat.Default, TTFlags.None, typeof (WorldObject), new Type[] {})]
  public static LocString IdentityTooltip(Type type);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 0, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString PlacedItemIdentityTooltip(this PlacementItemObject placementItem);

  [TooltipAffectedBy(typeof (WorldObject), "Auth", "OwnerChanged", null)]
  [TooltipAffectedBy(typeof (WorldObject), "OwnersMarkedUpName", null, null)]
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 1, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString OwnerTooltip(this WorldObject worldObj);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.SubType, 100, TTCat.Default, TTFlags.AllowInstanceForSubTypeCache, null, new Type[] {})]
  public static LocString TierTooltip(WorldObject worldObject);
}
