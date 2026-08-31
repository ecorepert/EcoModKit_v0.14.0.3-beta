// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.GarbageModulePickup
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Gameplay.Components.Storage;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using System.Numerics;

#nullable disable
namespace Eco.Mods.TechTree;

/// <summary>Drains garbage into a parked truck garbage module's storage — preferring a dedicated garbage bin, falling back to a nearby stockpile's garbage-tagged contents.</summary>
public static class GarbageModulePickup
{
  /// <summary>Tag giving a storage world object (e.g. Wooden Dumpster) the stockpile treatment for highlighting and dumping: the client trigger zone
  /// highlights it alongside stockpiles and dumps target it (FullAccess-gated). Collection is decided separately — a tagged object that also
  /// implements <see cref="T:Eco.Mods.TechTree.IGarbageBin" /> is drained bin-style (any driver, bounty honored), just without the client bin visuals.</summary>
  public const string GarbageSweepStorageTag = "GarbageSweepStorage";

  /// <summary>Finds what a pickup in the module's collection zone would collect from — a dedicated bin first (bins hold the collection claim and the pickup bounty, so they take priority),
  /// else an authorized stockpile with garbage — without moving anything, so the animation can start before the transfer. Returns null with a populated rejection when nothing is collectable.</summary>
  public static WorldObject ResolveSource(
    WorldObject vehicle,
    PublicStorageComponent moduleStorage,
    Vector3 collectionOffset,
    Player driver,
    out GarbageModulePickup.PickupRejection rejection);

  /// <summary>Collects from a previously resolved source into the module's storage. Split from <see cref="M:Eco.Mods.TechTree.GarbageModulePickup.ResolveSource(Eco.Gameplay.Objects.WorldObject,Eco.Gameplay.Components.Storage.PublicStorageComponent,System.Numerics.Vector3,Eco.Gameplay.Players.Player,Eco.Mods.TechTree.GarbageModulePickup.PickupRejection@)" /> so the transfer can run when the animation visually empties
  /// the bin into the truck; everything is (re)validated here, so a source that changed mid-animation (claimed, emptied, destroyed, truck filled) just collects nothing with a reason.</summary>
  public static bool TryCollectFrom(
    WorldObject source,
    PublicStorageComponent moduleStorage,
    Player driver,
    float maxPricePerItem,
    out GarbageModulePickup.PickupRejection rejection);

  /// <summary>Reason a pickup attempt collected nothing — surfaced to the driver as a toast so a silent no-op press becomes visible.</summary>
  public enum PickupRejection
  {
    Success,
    NoTargetInRange,
    SourceEmpty,
    ClaimedByOther,
    TooExpensive,
    Unaffordable,
    StorageFull,
  }
}
