// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.DemographicChange
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Civics;
using Eco.Gameplay.Civics.Demographics;
using Eco.Gameplay.Players;
using Eco.Gameplay.Settlements;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using LiteDB;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.GameActions;

[Eco.Shared.Networking.Eco(true, Serialized = false)]
[LocCategory("Civics")]
[LocDescription("A citizen either fit or ceased to fit the criteria for a demographic.")]
[ExtendedDescriptionLocStr("Only triggers laws from settlements that the Citizen is a part of.")]
[CannotBePrevented]
public class DemographicChange : 
  AggregatableAction,
  IUserGameAction,
  IController,
  IViewController,
  IHasUniversalID
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The citizen who changed demographics.")]
  [CanAutoAssign]
  public User Citizen { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The demographic that changed.")]
  [CanAutoAssign]
  public Demographic Demographic { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Did The citizen become part of the demographic, or stop being part?")]
  public EnteredOrLeftDemographic Entered { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Was this the first time the citizen has entered/left the demographic since they joined?")]
  public FirstOrNotFirst FirstTime { get; set; }

  [BsonIgnore]
  [JsonIgnore]
  public override IEnumerable<Settlement> SettlementScopes { get; }
}
