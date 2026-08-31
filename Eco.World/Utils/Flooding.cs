// Decompiled with JetBrains decompiler
// Type: Eco.World.Utils.Flooding
// Assembly: Eco.World, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B2A8792E-938E-4BB5-B27F-EF3390C48946
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.xml

using Eco.Core.Utils;
using Eco.Shared.Math;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.World.Utils;

public static class Flooding
{
  public static Result GetAllConectedWater(Vector3i start, out HashSet<Vector3i> waters);

  /// <summary> Deletes the top layer of connected water blocks starting from a given position. </summary>
  public static bool DeleteTopWaterLayer(Vector3i startPos);

  /// <summary> Adds a layer of water blocks by connecting them from the specified starting position. Note: Be careful it fill all empty blocks in that layer </summary>
  public static bool AddWaterLayer(Vector3i startPos);

  /// <summary> Flood-fill algorithm that explores and marks connected positions in the world. </summary>
  public static void FloodFill(
    WorldPosition3i start,
    Func<WorldPosition3i, bool> checkVisited,
    Action<WorldPosition3i> visit);
}
