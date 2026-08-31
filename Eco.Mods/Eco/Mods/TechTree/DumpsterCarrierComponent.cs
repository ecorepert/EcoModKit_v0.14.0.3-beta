// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.DumpsterCarrierComponent
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Controller;
using Eco.Gameplay.Players;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using System.Numerics;

#nullable enable
namespace Eco.Mods.TechTree;

/// <summary>Installed on a vehicle by a dumpster loader: lifts a whole liftable container — dumpsters, shipping containers — with its contents into the module's
/// carry slot and sets it back down elsewhere. Auth/laws run through the standard pickup and placement actions — the animations are cosmetic.</summary>
[Serialized]
[NoIcon]
public class DumpsterCarrierComponent : ParkedVehicleModuleComponent
{
  public Vector3 PickupOffset;
  public Vector3 SetdownOffset;
  public float ActionSeconds;

  public bool TransferInProgress { get; }

  [SyncToView(null, true)]
  public bool IsCarrying { get; }

  [SyncToView(null, true)]
  public 
  #nullable disable
  string CarriedItemName { get; }

  public override void Initialize();

  /// <summary>Driver-initiated lift: picks the nearest dumpster in the zone up into the module's carry slot. Pickup failures (auth, laws) toast through the action pack.</summary>
  [RPC]
  public void TryPickupDumpster(Player player);

  /// <summary>Driver-initiated setdown: places the carried dumpster at the setdown zone, truck-aligned. Placement failures (occupancy, deeds) toast through
  /// the placement flow and the dumpster stays aboard.</summary>
  [RPC]
  public void TryPlaceDumpster(Player player);
}
