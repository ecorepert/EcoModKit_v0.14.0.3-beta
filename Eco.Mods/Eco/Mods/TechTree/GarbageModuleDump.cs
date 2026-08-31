// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.GarbageModuleDump
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

/// <summary>Empties a parked truck garbage module's storage into a nearby authorized stockpile — the push counterpart to <see cref="T:Eco.Mods.TechTree.GarbageModulePickup" />.</summary>
public static class GarbageModuleDump
{
  /// <summary>Moves the module's contents into the nearest authorized stockpile in its zone. Returns the stockpile dumped into (so the caller can broadcast the animation) or null with a reason.</summary>
  public static WorldObject TryDump(
    WorldObject vehicle,
    PublicStorageComponent moduleStorage,
    Vector3 zoneOffset,
    Player driver,
    out GarbageModuleDump.DumpRejection rejection);

  /// <summary>Reason a dump moved nothing — surfaced to the driver as a toast.</summary>
  public enum DumpRejection
  {
    Success,
    NothingToDump,
    NoStockpileInRange,
    StockpileFull,
  }
}
