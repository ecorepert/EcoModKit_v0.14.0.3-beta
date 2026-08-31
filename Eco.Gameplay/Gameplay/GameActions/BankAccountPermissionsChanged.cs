// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.BankAccountPermissionsChanged
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Economy;
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

[Eco.Shared.Networking.Eco(true)]
[LocCategory("Economy")]
[LocDescription("A citizen changed the managers or the users of a bank account.")]
[ExtendedDescriptionLocStr("Only triggers laws from settlements that the Citizen is a part of, or settlements (and their parents) holding the bank account.")]
public class BankAccountPermissionsChanged : 
  AggregatableAction,
  IBankAccountGameAction,
  IController,
  IViewController,
  IHasUniversalID,
  IAuthGameAction,
  IUserGameAction
{
  public AccessType AccessNeeded { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The citizen who updated the bank account permissions.")]
  [CanAutoAssign]
  public User Citizen { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The bank account that got updated.")]
  public BankAccount BankAccount { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Did the user gain or lose access to the account?")]
  public BankAccountAccessAction AccessAction { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The specific permissions that got updated.")]
  public PermissionsType PermissionsChanged { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The user that gained or lost access to the bank account.")]
  public User CitizenChanged { get; set; }

  [BsonIgnore]
  [JsonIgnore]
  public override IEnumerable<Settlement> SettlementScopes { get; }
}
