// Decompiled with JetBrains decompiler
// Type: Eco.World.WorldChunkGridBuilder
// Assembly: Eco.World, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B2A8792E-938E-4BB5-B27F-EF3390C48946
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.xml

using Eco.Core.Utils;
using Eco.Shared.Math;
using Eco.World.Blocks;
using System;

#nullable disable
namespace Eco.World;

public class WorldChunkGridBuilder
{
  public WorldChunkGridBuilder();

  public WorldChunkGridBuilder(WorldChunkGrid grid);

  /// <summary>
  /// Let you make building by description string which may be easily copy-pasted.
  /// Following commands supported:
  /// - room:dx:dy:dz:width:height:depth - makes a room with offset from current position (dx, dy, dz) and interior size (width, height, depth)
  /// - hplane:dx:dy:dz:width:depth - makes a side plane with offset from current position (dx, dy, dz) and provided width and depth
  /// - splane:dx:dy:dz:height:depth - makes a vertical plane with offset from current position (dx, dy, dz) and provided height and depth
  /// - fplane:dx:dy:dz:width:height - makes a horizontal plane with offset from current position (dx, dy, dz) and provided width and height
  /// - cube:dx:dy:dz:width:height:depth - makes a room cube offset from current position (dx, dy, dz) and size (width, height, depth)
  /// - b:dx:dy:dz - single block with offset from current position (dx, dy, dz)
  /// - bt:BlockType - set building block type
  /// Commands should be separated with ';'.
  /// Sample (room with door):
  ///  bt:HewnLogCube;room:0:-1:0:3:4:3;bt:Empty;fplane:2:0:0:1:2
  /// .
  /// </summary>
  public Result BuildFromImportString(WrappedWorldPosition3i origin, string importString);

  public WorldChunkGridBuilder AddHorizontalPlane<T>(Vector3i origin, Vector2i size) where T : Block;

  public WorldChunkGridBuilder AddHorizontalPlane(Type blockType, Vector3i origin, Vector2i size);

  public WorldChunkGridBuilder AddSidePlane<T>(Vector3i origin, Vector2i size) where T : Block;

  public WorldChunkGridBuilder AddSidePlane(Type blockType, Vector3i origin, Vector2i size);

  public WorldChunkGridBuilder AddFrontPlane<T>(Vector3i origin, Vector2i size) where T : Block;

  public WorldChunkGridBuilder AddFrontPlane(Type blockType, Vector3i origin, Vector2i size);

  public WorldChunkGridBuilder AddRoom<T>(Vector3i origin, Vector3i interiorSize) where T : Block;

  public WorldChunkGridBuilder AddRoom(Type blockType, Vector3i origin, Vector3i interiorSize);

  public WorldChunkGridBuilder AddCube<T>(Vector3i origin, Vector3i size) where T : Block;

  public WorldChunkGridBuilder AddCube(Type blockType, Vector3i origin, Vector3i size);
}
