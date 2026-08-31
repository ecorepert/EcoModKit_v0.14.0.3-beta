// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.Contracts.ContractManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Aliases;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Gameplay.Property;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;
using Eco.Shared.View;
using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Economy.Contracts;

[Serialized]
public class ContractManager : 
  Singleton<
  #nullable disable
  ContractManager>,
  IController,
  IViewController,
  IHasUniversalID,
  IGameActionAware,
  ICanOverrideAuth
{
  public Registrar<Contract> Reg { get; }

  public ref int ControllerID { get; }

  public IEnumerable<Contract> Contracts { get; }

  public IEnumerable<Contract> ContractsWithClient(User user);

  public IEnumerable<Contract> ContractsWithContractor(User user);

  public IEnumerable<Contract> ContractsDisplayed(User user);

  /// <summary> Checks for any contract that use the given world object as a picking target, this is expensive and might need better implementation. </summary>
  /// <param name="obj">The world object that might be used.</param>
  /// <returns>The contracts that are using the given world object.</returns>
  public IEnumerable<Contract> CalculateContractsDependingOnWorldObject(WorldObject obj);

  public ContractClause CreateClauseName(string name, User client);

  public ContractClause CreateClause(Type type, User client);

  public IEnumerable<Contract> GetContractsOnBoard(WorldObject obj);

  public void Initialize();

  public override void ClearSingleton();

  public Contract RepeatContract(Contract oldContract);

  public void ContractChanged(Contract contract);

  public LazyResult ShouldOverrideAuth(IAlias alias, IOwned property, GameAction action);

  public void ActionPerformed(GameAction action);

  public void RecalculateDeedRelatedContracts(User user, Deed deed, LocString notification);

  public IEnumerable<Contract> GetDeedRelatedContracts(User user, Deed deed);
}
