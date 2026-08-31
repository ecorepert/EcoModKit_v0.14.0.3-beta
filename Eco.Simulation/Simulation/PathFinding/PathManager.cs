// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.Pathfinding.PathManager
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Core.Plugins;
using Eco.Core.Serialization;
using Eco.Core.Utils;
using Eco.Shared.Items;
using Eco.Shared.Math;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;
using Eco.Simulation.Pathfinding.Internal;
using System.Numerics;

#nullable disable
namespace Eco.Simulation.Pathfinding;

[Serialized]
public class PathManager : Singleton<PathManager>, ISimplePluginData, IStorage, ISerializable
{
  public static Initializer Initializer;

  public IPersistent StorageHandle { get; set; }

  public bool TryGetNodeAt(WorldPosition3i pos, out PackedPathNode node);

  public void Initialize();

  public (PathRegion Region, WorldPosition3i Pos) GetRegionAt(
    Vector3 rawpos,
    PathRegionType regionType,
    bool allowOtherYValues,
    bool checkNeighbors);

  public int GetFlatness(Vector3i pos);

  public void Update();

  /// <summary> Calls full update on blocks and regions (forced). Useful when there are big changes like from commands and needs immediate update </summary>
  public void ManualUpdate();

  /// <summary> Gets state info for plugin manager </summary>
  public string GetDisplayText();

  public override string ToString();

  public string GetStatus();

  public string GetCategory();

  public PathRegionSet[] GetRegionSetsDebug();
}
