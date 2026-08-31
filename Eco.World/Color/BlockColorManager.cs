// Decompiled with JetBrains decompiler
// Type: Eco.World.Color.BlockColorManager
// Assembly: Eco.World, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B2A8792E-938E-4BB5-B27F-EF3390C48946
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.xml

using Eco.Core.Serialization;
using Eco.Shared.Math;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;
using System.Collections.Generic;

#nullable disable
namespace Eco.World.Color;

[Serialized]
public sealed class BlockColorManager : AutoSingleton<BlockColorManager>
{
  /// <summary>Initializes the <see cref="T:Eco.World.Color.BlockColorManager" /> instance.</summary>
  public void Initialize();

  /// <summary>Sets the color of a block at a specific location.</summary>
  /// <param name="pos">Position to modify.</param>
  /// <param name="color">Color to set.</param>
  public void SetColor(Vector3i pos, ByteColor color);

  public void SetColor(WrappedWorldPosition3i pos, ByteColor color);

  /// <summary> Clears block color at Vector3i position, wraps inside. Returns true if color was actually changed. </summary>
  public bool ClearColor(Vector3i pos, bool notify = true);

  /// <summary> Clears block color at WrappedWorldPosition3i. Returns true if color was actually changed. </summary>
  public bool ClearColor(WrappedWorldPosition3i pos, bool notify = true);

  /// <summary> Clears colors in batch, then triggers chunk update once only on changed positions efficiently </summary>
  public void ClearColors(IEnumerable<Vector3i> positions, bool notify = true);

  /// <summary> Retrieves the color at a specific block position. If no color is defined then the default </summary>
  public bool TryGetColorData(Vector3i pos, out ByteColor color);

  public bool TryGetColorDataWrappedPos(Vector3i pos, out ByteColor color);

  [Serialized]
  public class BlockColorData : IStorage, ISerializable
  {
    public IPersistent StorageHandle { get; set; }
  }
}
