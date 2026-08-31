// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.GarbageCollectionComponent
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

/// <summary>Installed on a vehicle by a garbage module; exposes the driver-initiated pickup RPC. Server validates and transfers atomically — the animation is cosmetic.</summary>
[Serialized]
[NoIcon]
public class GarbageCollectionComponent : ParkedVehicleModuleComponent
{
  public Vector3 CollectionOffset;
  public Vector3? DumpOffset;
  public float MaxPricePerItem;
  public float TransferDelaySeconds;

  public override void Initialize();

  /// <summary>Driver-initiated pickup. Server validates auth + that the truck is parked and resolves the source up front (so obvious no-ops toast without animating), broadcasts the cosmetic animation,
  /// then runs the transfer <see cref="F:Eco.Mods.TechTree.GarbageCollectionComponent.TransferDelaySeconds" /> later — when the animation visually empties the bin into the truck — revalidating everything atomically at that point. A source that
  /// changed mid-animation (claimed, emptied, destroyed, truck filled) moves nothing and toasts late. No mid-animation sync — late joiners just miss the animation.</summary>
  [RPC]
  public void TryStartGarbagePickup(
  #nullable disable
  Player player);

  /// <summary>Driver-initiated dump. Server validates auth + that the truck is parked, empties the module into the nearest authorized stockpile, then broadcasts the cosmetic open-back animation. Mirrors the pickup flow.</summary>
  [RPC]
  public void TryStartGarbageDump(Player player);
}
