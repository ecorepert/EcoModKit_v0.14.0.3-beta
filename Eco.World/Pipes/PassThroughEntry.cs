// Decompiled with JetBrains decompiler
// Type: Eco.World.Pipes.PassThroughEntry
// Assembly: Eco.World, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B2A8792E-938E-4BB5-B27F-EF3390C48946
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.xml

using Eco.Shared.Math;
using Eco.Shared.Serialization;
using System;

#nullable disable
namespace Eco.World.Pipes;

/// <summary>The pipe type running through a wall voxel and the axis it crosses on.</summary>
[Serialized]
public struct PassThroughEntry
{
  [Serialized]
  public Type PipeBlockType;
  [Serialized]
  public Direction Orientation;

  public PassThroughEntry(Type pipeBlockType, Direction orientation);
}
