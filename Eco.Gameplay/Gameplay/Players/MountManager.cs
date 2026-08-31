// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Players.MountManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Components;
using System;

#nullable disable
namespace Eco.Gameplay.Players;

/// <summary>
/// Handles the player's mounting and dismounting.
/// 
/// <para>Use <see cref="E:Eco.Gameplay.Players.MountManager.MountEvent" /> and <see cref="E:Eco.Gameplay.Players.MountManager.DismountEvent" /> to attach listeners for when the player mounts a vehicle.</para>
/// </summary>
public class MountManager
{
  public MountComponent Mount { get; }

  public bool IsMounted { get; }

  public event Action<MountComponent> MountEvent;

  public event Action<MountComponent> DismountEvent;

  public MountManager(
    MovementHackDetector movementHackDetector,
    Action<float?> setMaxAllowedInventory);

  /// <summary>Fired when player has mounted a vehicle.</summary>
  public void OnMount(MountComponent mountComponent);

  /// <summary>Fired when player has dismounted a vehicle.</summary>
  public void OnDismount(MountComponent mountComponent);
}
