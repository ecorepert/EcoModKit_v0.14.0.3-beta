// Decompiled with JetBrains decompiler
// Type: Eco.Shared.SharedTypes.ScorpionTrunkSyncData
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Serialization;
using System;
using System.Numerics;

#nullable disable
namespace Eco.Shared.SharedTypes;

/// <summary> TrunkData container for separate smooth network sync where sync physics is an overkill solution </summary>
public class ScorpionTrunkSyncData
{
  public Guid Id;
  public Vector3 Pos;
  public Eco.Shared.Math.Quaternion Rot;

  public static ScorpionTrunkSyncData FromBSON(BSONObject trunkBson);

  public BSONObject ToBSON();
}
