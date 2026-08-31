// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.PayRentOrMoveInFee
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Property;
using Eco.Gameplay.Settlements;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using LiteDB;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.GameActions;

[Eco.Shared.Networking.Eco(true)]
[LocCategory("Finance")]
[LocDescription("Pay move in or rent property fee.")]
[ExtendedDescriptionLocStr("Triggers laws on settlements influencing the deed.")]
[ChangeParentConfigLoc("Citizen", "Tenant", null, null, false)]
[ChangeParentConfigLoc("Earner", "Landlord", null, null, false)]
public class PayRentOrMoveInFee : 
  RecurringPayment,
  ICurrencyGameAction,
  IController,
  IViewController,
  IHasUniversalID
{
  [BsonIgnore]
  public override AccessType AccessNeeded { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The deed taking the rent payment.")]
  public Deed Deed { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Define the type of payment.")]
  public MoveInOrRentFee MoveInOrRentFee { get; set; }

  [BsonIgnore]
  [JsonIgnore]
  public override IEnumerable<Settlement> SettlementScopes { get; }
}
