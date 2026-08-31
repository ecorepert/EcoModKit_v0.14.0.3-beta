// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Housing.Internal.RoomSpecification
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Gameplay.Property;
using Eco.Shared.Math;
using System;
using System.Diagnostics.CodeAnalysis;
using System.Runtime.CompilerServices;
using System.Text;

#nullable enable
namespace Eco.Gameplay.Housing.Internal;

/// <summary>Room specification for <see cref="T:Eco.Gameplay.Housing.HousingCommands" />. Contains all information about room and may be used for spawn position search methods to ensure there enough space.</summary>
public class RoomSpecification : IEquatable<
#nullable disable
RoomSpecification>
{
  public required Vector3i InteriorSize;
  public required 
  #nullable enable
  Type FloorBlock;
  public required Type WallBlock;
  public required Type RoofBlock;
  public required RoofType RoofType;
  public Type? DoorType;
  public Type? WindowBlock;
  public Type? NorthSouthWindowBlock;

  [CompilerGenerated]
  protected virtual Type EqualityContract { get; }

  public Vector3i ExteriorSize { get; }

  public Vector3i BuildingSize { get; }

  /// <summary>Creates <see cref="T:Eco.Gameplay.Housing.Internal.RoomSpecification" /> with given material, size and options.</summary>
  public static ValResult<RoomSpecification> Create(
    string materialName,
    Vector3i interiorSize,
    RoofType roofType = RoofType.Flat,
    bool windows = true,
    int doorTier = 0);

  /// <summary>Creates <see cref="T:Eco.Gameplay.Housing.Internal.RoomSpecification" /> with given tier, size and options.</summary>
  public static ValResult<RoomSpecification> Create(
    int tier,
    Vector3i interiorSize,
    RoofType roofType = RoofType.Flat,
    bool windows = true);

  [CompilerGenerated]
  public override string ToString();

  [CompilerGenerated]
  protected virtual bool PrintMembers(StringBuilder builder);

  [CompilerGenerated]
  public static bool operator !=(RoomSpecification? left, RoomSpecification? right);

  [CompilerGenerated]
  public static bool operator ==(RoomSpecification? left, RoomSpecification? right);

  [CompilerGenerated]
  public override int GetHashCode();

  [CompilerGenerated]
  public override bool Equals(object? obj);

  [CompilerGenerated]
  public virtual bool Equals(RoomSpecification? other);

  [CompilerGenerated]
  public virtual RoomSpecification \u003CClone\u003E\u0024();

  [CompilerGenerated]
  [SetsRequiredMembers]
  protected RoomSpecification(RoomSpecification original);

  public RoomSpecification();
}
