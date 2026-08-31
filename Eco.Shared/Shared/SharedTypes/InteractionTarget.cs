// Decompiled with JetBrains decompiler
// Type: Eco.Shared.SharedTypes.InteractionTarget
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Math;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using System.Collections.Generic;
using System.Numerics;

#nullable disable
namespace Eco.Shared.SharedTypes;

/// <summary>Struct that defines something the player is looking at.  Can be a block or object.</summary>
[BsonAutoSerialize]
public struct InteractionTarget : IBsonSerialize, IBsonSerializable, IBsonDeserializable
{
  public Vector3i? BlockPosition;
  public Vector3i BlockPositionOffset;
  public Direction Normal;
  public int TargetObjNetID;
  public int SubTargetIndex;
  public InteractionTargetPriority Priority;
  public List<EnvVar> EnvVars;
  /// These aren't used for equality checks, make sure these are excluded from .Equals()
  public Vector3 HitPos;
  public Vector3 HitNormal;
  public static readonly InteractionTarget Dummy;

  public INetObject NetObj { get; }

  public bool IsBlock { get; }

  public InteractionTargetFlags Flags { get; set; }

  [BsonSerializeIgnore]
  public object GameObject { get; set; }

  [BsonSerializeIgnore]
  public object Entity { get; set; }

  [BsonSerializeIgnore]
  public object CachedWorldObjectView { get; set; }

  public readonly bool IsDummy { get; }

  public Vector3? TryGetBlockPlusNormalsPosition();

  public bool TryGetParameter(string parameterName, out object parameterValue);

  public bool ContainsParameter(string parameterName);

  public override string ToString();

  public void FromBson(BSONArray bson);

  public BSONArray ToBson();
}
