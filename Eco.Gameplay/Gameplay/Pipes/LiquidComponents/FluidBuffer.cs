// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Pipes.LiquidComponents.FluidBuffer
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Items;
using Eco.Shared.Serialization;
using System;

#nullable disable
namespace Eco.Gameplay.Pipes.LiquidComponents;

/// <summary>A typed fluid store in liters (millilitre-backed): the per-port buffer of the quantity-based pipe model. Producers deposit into it (bounded by
/// free space — a purely local, order-independent decision), the owning machine drinks from it each tick. The first fluid deposited locks the type until
/// fully drained. Contents persist; capacity is reconfigured by the owning component each load.</summary>
[Serialized]
public class FluidBuffer
{
  public float CapacityLiters { get; set; }

  public bool Empty { get; }

  public float Stored { get; }

  public Type LockedType { get; }

  public float FreeSpace { get; }

  /// <summary>Room available for <paramref name="itemType" />: the free space, or 0 while locked to another fluid.</summary>
  public float CanAccept(Type itemType);

  /// <summary>Stores up to the free space (locking the type on the first deposit) and returns what was accepted.</summary>
  public float Deposit(Item item, float amount);

  /// <summary>Drains up to <paramref name="amount" /> and returns the drained fluid with what was actually taken; unlocks the type when fully drained.
  /// The type comes out of the same lock as the drain: reading <see cref="P:Eco.Gameplay.Pipes.LiquidComponents.FluidBuffer.LockedType" /> separately races with parallel deposits and can report null
  /// for a take that succeeded.</summary>
  public (Type Type, float Amount) Take(float amount);

  /// <summary>Deletes the contents outright (input-side fluids are discarded on pickup).</summary>
  public void Clear();
}
