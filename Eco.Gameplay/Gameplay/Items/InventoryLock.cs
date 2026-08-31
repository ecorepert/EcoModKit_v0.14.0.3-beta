// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.InventoryLock
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Items;

/// <summary>Represents a lock acquired by a thread on one or more inventories.</summary>
public sealed class InventoryLock : IDisposable
{
  /// <summary>Returns true if the current thread already holds an inventory lock. Useful for deferring operations that would acquire a new lock to avoid deadlocks.</summary>
  public static bool IsHeldByCurrentThread { get; }

  /// <summary>Runs an action once the current thread releases its outermost inventory lock, or immediately if it holds none.</summary>
  /// <remarks>For work that needs to lock inventories outside the current lock set, which would otherwise deadlock.</remarks>
  public static void DeferUntilReleased(Action action);

  public Inventory[] DebugSortedLockedObjects { get; }

  /// <summary>Can be used to detect if lock is stuck (deadlock).</summary>
  public long CreationTime { get; }

  public bool Disposed { get; }

  public string GetCreationStacktrace();

  public InventoryLock(IEnumerable<Inventory> inventories);

  public void Dispose();
}
