// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.ParkedVehicleModuleComponent
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Controller;
using Eco.Gameplay.Components;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Mods.TechTree;

/// <summary>Base for vehicle-module components whose driver actions require the vehicle to be parked: provides the settled check and the shared driver+parked RPC prologue.</summary>
[Serialized]
[NoIcon]
public abstract class ParkedVehicleModuleComponent : WorldObjectComponent
{
  protected VehicleComponent Vehicle { get; }

  protected bool NotParked { get; }

  public override void Initialize();

  /// <summary>True when <paramref name="player" /> is the current driver and the vehicle is parked; otherwise toasts <paramref name="parkedMsg" /> (drivers only — non-drivers are rejected silently) and returns false.</summary>
  protected bool CheckDriverAndParked(Player player, string parkedMsg);
}
