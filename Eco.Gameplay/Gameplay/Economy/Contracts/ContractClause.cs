// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.Contracts.ContractClause
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Players;
using Eco.Gameplay.Property;
using Eco.Gameplay.Utils;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using PropertyChanged;
using System.Collections.Generic;
using System.ComponentModel;

#nullable enable
namespace Eco.Gameplay.Economy.Contracts;

/// <summary> Base class for any contract clause that a contract can contain. </summary>
/// <remarks> Contract clauses are part of a contract and need to be completed in order to claim the rewards -- which is also a contract clause. </remarks>
[Serialized]
public abstract class ContractClause : 
  IController,
  IViewController,
  IHasUniversalID,
  INotifyPropertyChanged,
  IThreadSafeSubscriptions,
  ISubscriptions<ThreadSafeSubscriptions>,
  ISubscriptions
{
  public event 
  #nullable disable
  PropertyChangedEventHandler PropertyChanged;

  protected static void Changed(object clauseObject, PropertyChangedEventArgs args);

  public ThreadSafeAction<ContractClause> OnChanged { get; }

  [SyncToView(null, true)]
  [DependsOn("ParentContract")]
  public User ContractorUser { get; }

  [SyncToView(null, true)]
  public User ClientUser { get; set; }

  public Contract ParentContract { get; }

  [Notify]
  public virtual IEnumerable<Picker> Pickers { get; }

  public virtual void Initialize(User contractor, User client);

  /// <summary>This is called whenever the contract parent is removed and so all clauses must be cleaned from all subscription.</summary>
  public virtual void OnDisabled();

  public void SetParentContract(Contract contract);

  /// <summary>This is always called after parent contract has already been initialized and set.</summary>
  public void LateInit();

  public virtual void OnCreate(User client);

  public virtual Result CanJoin(User contractor, User client);

  public virtual Result CanSucceed(User contractor, User client);

  public virtual Result Valid(User contractor, User client);

  public virtual void TryPostJob(GameActionPack pack, User client);

  public virtual void TryJoin(GameActionPack pack, User contractor, User client);

  public virtual void TrySucceed(GameActionPack pack, User contractor, User client, bool forced);

  public virtual void TryFail(GameActionPack pack, User contractor, User client);

  public virtual bool ShouldOverrideAuth(GameAction action);

  public virtual bool ActionPerformed(GameAction action);

  public abstract LocString Name { get; }

  public abstract LocString Describe { get; }

  [DoNotNotify]
  public ref int ControllerID { get; }

  protected static Deed GetActionDeed(GameAction action);

  public ref ThreadSafeSubscriptions Subscriptions { get; }
}
