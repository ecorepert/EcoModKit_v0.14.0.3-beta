// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.EducationAction
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Players;
using Eco.Gameplay.Settlements;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using LiteDB;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.GameActions;

public abstract class EducationAction : AggregatableAction
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Student enrolling.")]
  [CanAutoAssign]
  public User Student { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The teacher, if one is assigned.")]
  public User Teacher { get; set; }

  [BsonIgnore]
  [JsonIgnore]
  public override IEnumerable<Settlement> SettlementScopes { get; }
}
