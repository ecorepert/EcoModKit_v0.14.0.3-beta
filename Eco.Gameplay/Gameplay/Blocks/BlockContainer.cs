// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Blocks.BlockContainer
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Math;
using Eco.Shared.Networking;
using System.Numerics;

#nullable disable
namespace Eco.Gameplay.Blocks;

/// <summary> A contained area of blocks. </summary>
public class BlockContainer : IPositionAndBounds
{
  public Vector3 Position { get; }

  public Rect Bounds { get; }

  public Vector3 Size { get; }

  /// <summary> Makes new block container at <paramref name="position" /> (it should be pre-wrapped) and with specified <paramref name="size" />. </summary>
  public BlockContainer(WrappedWorldPosition3i position, Vector3 size);

  /// <summary> Checks if <paramref name="position" /> is within the <see cref="T:Eco.Gameplay.Blocks.BlockContainer" />. </summary>
  public bool Contains(WrappedWorldPosition3i position);

  protected bool Equals(BlockContainer other);

  public override bool Equals(object obj);

  public override int GetHashCode();
}
