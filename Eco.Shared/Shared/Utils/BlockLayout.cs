// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.BlockLayout
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Math;
using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Shared.Utils;

/// <summary>A set of blocks represented by dictionary of block positions mapped to block IDs. Used in blueprints and multi-block placement.</summary>
public sealed class BlockLayout : IEquatable<BlockLayout>
{
  [Eco.Shared.Networking.Eco(true)]
  public SortedDictionary<Vector3i, ushort> Blocks { get; set; }

  public BlockLayout();

  public BlockLayout(IEnumerable<KeyValuePair<Vector3i, ushort>> blocks);

  public int Count { get; }

  public bool Equals(BlockLayout? other);

  public override bool Equals(object? obj);

  public override int GetHashCode();

  public static bool operator ==(BlockLayout? lhs, BlockLayout? rhs);

  public static bool operator !=(BlockLayout? lhs, BlockLayout? rhs);

  /// <summary> Set the block ID of a relative position, overwriting any existing block ID. </summary>
  public void SetValue(Vector3i offset, ushort blockId);

  /// <summary> Clear the block from the given position if it is set.</summary>
  public void RemoveValue(Vector3i offset);

  /// <summary> Gets the block ID for the given position if it exists. </summary>
  public bool TryGetValue(Vector3i offset, out ushort value);

  /// <summary> Clear all block IDs from the blueprint. </summary>
  public void Clear();

  /// <summary> Sets the blueprint to all the blocks of the range, relative to WorldRange.min, set to the given block ID. </summary>
  public void SetFromRangeAndBlockId(IEnumerable<Vector3i> worldRange, ushort blockId);
}
