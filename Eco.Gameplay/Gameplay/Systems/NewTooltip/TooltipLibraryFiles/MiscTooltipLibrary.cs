// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.NewTooltip.TooltipLibraryFiles.MiscTooltipLibrary
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.PropertyHandling;
using Eco.Core.Stats;
using Eco.Core.Systems;
using Eco.Gameplay.Civics.GameValues;
using Eco.Gameplay.Components;
using Eco.Gameplay.Items;
using Eco.Gameplay.Items.Recipes;
using Eco.Gameplay.Items.SearchAndSelect;
using Eco.Gameplay.Minimap;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.RegistrarSystem;
using Eco.Gameplay.Systems.TextLinks;
using Eco.Gameplay.Utils;
using Eco.Gameplay.Wires;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using System;

#nullable disable
namespace Eco.Gameplay.Systems.NewTooltip.TooltipLibraryFiles;

[TooltipLibrary]
public static class MiscTooltipLibrary
{
  public static void Initialize();

  [TooltipAffectedBy(typeof (SimpleEntry), "CreatorText", null, null)]
  [TooltipAffectedBy(typeof (SimpleEntry), "CachedValidity", null, null)]
  [TooltipAffectedBy(typeof (SimpleEntry), "UserDescription", null, null)]
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance | CacheAs.User, 1, TTCat.Default, TTFlags.ClearCacheForAllUsers, null, new Type[] {typeof (WorkOrder)})]
  public static LocString SimpleEntryTooltip(this SimpleEntry simpleEntry, User reader);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 100, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString StatDescription(this StatEntry statEntry);

  [TooltipAffectedBy(typeof (SimpleNamedOption), "Tooltip", null, null)]
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 100, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString SimpleNamedOptionTooltip(this SimpleNamedOption namedOption);

  [TooltipAffectedBy("ConsumersUpdatedEvent", null, null)]
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 190, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString AuthItemTooltip(this AuthItemData authItem, TooltipOrigin origin);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Disabled, 2, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString LocationTooltip(this IHasPosition thing, User user);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Disabled, 100, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString Vector3TooltipDirection(this Vector3Tooltip vector3Tooltip, User user);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Disabled, 100, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString Vector2TooltipDirection(this Vector2Tooltip vector2Tooltip, User user);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 200, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString ReferenceTooltip(this IHasID obj);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.SubType, 100, TTCat.Default, TTFlags.None, typeof (ModuleItem), new Type[] {})]
  public static LocString UnlocksDescription(Type type, TooltipOrigin origin);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.SubType, 0, TTCat.Details, TTFlags.None, typeof (IController), new Type[] {})]
  public static LocString TypeDesc(Type type);

  [NewTooltipTitle(CacheAs.Global, 100, TTCat.Default, TTFlags.None, typeof (ExhaustionMonitor), "Exhaustion")]
  public static LocString ExhaustionMonitorTooltipTitle { get; }

  [TooltipAffectedBy(typeof (IMinimapObject), "DisplayName", null, null)]
  [NewTooltipTitle(CacheAs.Instance, 100, TTCat.Default, TTFlags.None, null, "")]
  public static LocString IMinimapObjectTooltipTitle(this IMinimapObject minimapObject);

  [NewTooltipTitle(CacheAs.Disabled, 50, TTCat.Default, TTFlags.None, null, "")]
  public static LocString ILinkableTooltipTitle(this ILinkable linkable);

  [NewTooltipTitle(CacheAs.Instance, 40, TTCat.Default, TTFlags.None, null, "")]
  public static LocString CraftingElementTitle(this CraftingElement craftingElement);

  [NewTooltipTitle(CacheAs.Instance, 10, TTCat.Default, TTFlags.None, null, "")]
  public static LocString GameValueTitle(this IGameValueContext context);

  [TooltipAffectedBy(typeof (WireConnection), "Name", null, null)]
  [NewTooltipTitle(CacheAs.Instance, 0, TTCat.Default, TTFlags.None, null, "")]
  public static LocString WireConnectionTooltipTitle(this WireConnection connection);

  [TooltipAffectedBy(typeof (SearchAndSelectItem), "Stack", null, null)]
  [NewTooltipTitle(CacheAs.Instance, 0, TTCat.Default, TTFlags.None, null, "")]
  public static LocString SearchAndSelectItemTooltipTitle(this SearchAndSelectItem searchItem);

  [TooltipAffectedBy(typeof (SimpleEntry), "Name", null, null)]
  [TooltipAffectedBy(typeof (SimpleEntry), "NameSuffix", null, null)]
  [NewTooltipTitle(CacheAs.Instance, 1, TTCat.Default, TTFlags.None, null, "")]
  public static LocString SimpleEntryTitle(this SimpleEntry entry);

  [TooltipAffectedBy(typeof (Eco.Gameplay.UI.WorldMarker.WorldMarker), "DisplayName", null, null)]
  [NewTooltipTitle(CacheAs.Instance, 1, TTCat.Default, TTFlags.None, null, "")]
  public static LocString WorldMarkerTooltipTile(this Eco.Gameplay.UI.WorldMarker.WorldMarker worldMarker);

  [NewTooltipTitle(CacheAs.Instance, 1, TTCat.Default, TTFlags.None, null, "")]
  public static LocString DeedSalesTooltipTitle(this DeedSalesItemData deed);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance | CacheAs.User, 500, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString TeleportTo(this IHasTeleportOption target, User user);
}
