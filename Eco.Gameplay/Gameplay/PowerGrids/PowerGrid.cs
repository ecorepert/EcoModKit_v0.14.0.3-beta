// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.PowerGrids.PowerGrid
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Components;
using Eco.Shared.View;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.PowerGrids;

/// <summary>
/// Represents a power grid. A <see cref="T:Eco.Gameplay.PowerGrids.PowerGrid" /> is a collection of <see cref="T:Eco.Gameplay.Components.PowerGridComponent" />s that all share the same energy type.
/// A power grid is always fully connected. The three major operations on a power grid are <see cref="M:Eco.Gameplay.PowerGrids.PowerGrid.Join(Eco.Gameplay.Components.PowerGridComponent,Eco.Gameplay.Components.PowerGridComponent)" />, <see cref="M:Eco.Gameplay.PowerGrids.PowerGrid.DisconnectAndSplit(Eco.Gameplay.Components.PowerGridComponent)" />, and <see cref="M:Eco.Gameplay.PowerGrids.PowerGrid.Tick" />.
/// <see cref="T:Eco.Gameplay.PowerGrids.PowerGrid" /> is not thread safe.
/// </summary>
/// <remarks>
/// A <c>PowerGrid</c> automatically registers itself to <see cref="T:Eco.Gameplay.PowerGrids.PowerGridManager" /> when it is constructed. To de-register the <c>PowerGrid</c>, use the <see cref="M:Eco.Gameplay.PowerGrids.PowerGrid.Cleanup" /> function.
/// Internally, the <see cref="T:Eco.Gameplay.Components.PowerGridComponent" />s are stored as an undirected graph in adjacency set representation.
/// <see cref="T:Eco.Gameplay.PowerGrids.PowerGrid" />s are not stored. They are re-constructed every time the server loads the world.
/// </remarks>
public class PowerGrid : IController, IViewController, IHasUniversalID
{
  public readonly IPowerEnergyType EnergyType;

  [SyncToView(null, true)]
  public float EnergySupply { get; }

  [SyncToView(null, true)]
  public float EnergyDemand { get; }

  public float Load { get; }

  public float Efficiency { get; }

  public IEnumerable<PowerGridComponent> Components { get; }

  public int ComponentCount { get; }

  [SyncToView(null, true)]
  public string EnergyTypeName { get; }

  public ref int ControllerID { get; }

  public PowerGrid(PowerGridComponent component);

  /// <summary>Tick the power grid, update the stored power supply and demand. All power grids tick in parallel, so no race conditions allowed here.</summary>
  public void Tick();

  /// <summary>Add <paramref name="current" /> to <paramref name="target" />'s power grid and mark them as connected.</summary>
  public static void Join(PowerGridComponent current, PowerGridComponent target);

  /// <summary>Remove a component from the power grid. Detect whether removing the component breaks the connected-ness of the power grid connection graph. If that is the case, split this power grid into multiple grids based on connected components.</summary>
  public void DisconnectAndSplit(PowerGridComponent disconnectComponent);

  public bool IsEmpty();

  /// <summary>Clears internal storage and removes this power grid from <see cref="T:Eco.Gameplay.PowerGrids.PowerGridManager" />, which will stop ticking this power grid. Call this function when the power grid should be destroyed.</summary>
  public void Cleanup();

  public bool TryAccumulate(float requestedAmount, out float accumulated);
}
