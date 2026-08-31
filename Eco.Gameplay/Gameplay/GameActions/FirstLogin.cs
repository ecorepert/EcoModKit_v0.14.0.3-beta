// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.FirstLogin
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Civics;
using Eco.Gameplay.Civics.Laws;
using Eco.Gameplay.Players;
using Eco.Gameplay.Settlements;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using LiteDB;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.GameActions;

[Eco.Shared.Networking.Eco(true, Serialized = false)]
[LocCategory("Citizens")]
[LocDescription("A citizen logged in for the first time. This action triggers laws for all founded settlements on the server.")]
[RelatedFeature("UseSettlementSystem", false)]
public class FirstLogin : 
  AggregatableAction,
  IUserGameAction,
  IController,
  IViewController,
  IHasUniversalID,
  IPositionGameAction,
  IDynamicPreventability
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The citizen who performed the interaction.")]
  [CanAutoAssign]
  public User Citizen { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The position of The citizen when they first login.")]
  public Vector3i ActionLocation { get; set; }

  public static Result CanPreventStatic(LawSection section);

  public Result CanPrevent(LawSection section);

  [BsonIgnore]
  [JsonIgnore]
  public override IEnumerable<Settlement> SettlementScopes { get; }
}
