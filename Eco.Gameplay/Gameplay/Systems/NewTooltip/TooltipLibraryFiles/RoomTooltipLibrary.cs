// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.NewTooltip.TooltipLibraryFiles.RoomTooltipLibrary
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.PropertyHandling;
using Eco.Gameplay.Housing.PropertyValues;
using Eco.Gameplay.Housing.PropertyValues.Internal;
using Eco.Gameplay.Players;
using Eco.Gameplay.Rooms;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using System;

#nullable disable
namespace Eco.Gameplay.Systems.NewTooltip.TooltipLibraryFiles;

[TooltipLibrary]
public static class RoomTooltipLibrary
{
  public static void Initialize();

  [TooltipAffectedBy(typeof (Room), "RoomValue", null, null)]
  [NewTooltipTitle(CacheAs.Global, 0, TTCat.Default, TTFlags.None, typeof (Room), "")]
  public static LocString RoomTooltipTitle();

  [TooltipAffectedBy(typeof (Room), "RoomStats", null, null)]
  [TooltipAffectedBy(typeof (Room), "RoomValue", null, null)]
  [TooltipAffectedBy(typeof (Room), "RoomValue", "Description", null)]
  [TooltipAffectedBy(typeof (Room), "RoomStats", "DescriptionText", null)]
  [TooltipAffectedBy(typeof (Room), "RoomDeed", "ResidentsChangedEvent", null)]
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance | CacheAs.User, 10, TTCat.Default, TTFlags.ClearCacheForAllUsers, null, new Type[] {})]
  public static LocString RoomDescription(this Room room, User user);

  [NewTooltipTitle(CacheAs.Instance, 0, TTCat.Default, TTFlags.None, null, "")]
  public static LocString RoomValueTooltipTitle(this StandardFurnishedRoomValue value);

  [NewTooltipTitle(CacheAs.Instance, 20, TTCat.Default, TTFlags.None, null, "")]
  public static LocString RoomCategoryTitle(this RoomCategory roomCat);

  [NewTooltipTitle(CacheAs.SubType, 0, TTCat.Default, TTFlags.None, typeof (PropertyValue), "")]
  public static LocString PropertyValueTooltipTitle(Type type);

  [TooltipAffectedBy(typeof (PropertyValue), "Description", null, null)]
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 100, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString PropertyDescription(this PropertyValue propertyValue);
}
