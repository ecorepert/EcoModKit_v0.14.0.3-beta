// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Blocks.BlockContainerManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Math;
using System.Numerics;

#nullable disable
namespace Eco.Gameplay.Blocks;

/// <summary> Manages contained areas of blocks. Can test if an individual block is in any container. </summary>
public class BlockContainerManager
{
  public static readonly BlockContainerManager Obj;

  /// <summary> Adds <see cref="T:Eco.Gameplay.Blocks.BlockContainer" /> at <paramref name="position" /> with <paramref name="size" />. </summary>
  public void AddBlockContainer(WrappedWorldPosition3i position, Vector3 size);

  /// <summary> Removes <see cref="T:Eco.Gameplay.Blocks.BlockContainer" /> at <paramref name="position" /> with <paramref name="size" />. </summary>
  public void RemoveBlockContainer(WrappedWorldPosition3i position, Vector3 size);

  /// <summary> Checks if <paramref name="position" /> contained within any of registered <see cref="T:Eco.Gameplay.Blocks.BlockContainer" /> instances. </summary>
  public bool IsBlockContained(WrappedWorldPosition3i position);
}
