// Decompiled with JetBrains decompiler
// Type: Eco.Mods.Organisms.TrunkPiece
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Items;
using Eco.Shared.Serialization;
using System;
using System.Numerics;

#nullable disable
namespace Eco.Mods.Organisms;

[Serialized]
[Tag("Choppable")]
internal class TrunkPiece
{
  [Serialized]
  public Guid ID;
  [Serialized]
  public float SliceStart;
  [Serialized]
  public float SliceEnd;
  public double LastUpdateTime;
  [Serialized]
  public Vector3 Position;
  [Serialized]
  public Vector3 Velocity;
  [Serialized]
  public Eco.Shared.Math.Quaternion Rotation;
  [Serialized]
  public bool Collected;

  public bool IsValid { get; }

  public bool IsCollectedOrNotValid { get; }

  public BSONObject ToUpdateBson();

  public BSONObject ToInitialBson();
}
