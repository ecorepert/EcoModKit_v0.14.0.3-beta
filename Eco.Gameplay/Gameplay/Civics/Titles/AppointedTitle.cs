// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Titles.AppointedTitle
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Aliases;
using Eco.Gameplay.Economy;
using Eco.Gameplay.Economy.Money;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Civics.Titles;

/// <summary>
/// A title that can be assigned managers and users.
/// This is different from an <see cref="T:Eco.Gameplay.Civics.Titles.ElectedTitle" /> in that it can be created and set by anyone at a Registrar object, whereas <see cref="T:Eco.Gameplay.Civics.Titles.ElectedTitle" /> can only be set via elections.
/// Functionally, they both serve the same purpose: defining a set of users represented by a title.
/// </summary>
[Serialized]
public class AppointedTitle : 
  Title,
  IHasDualPermissions,
  ICustomSubmitButton,
  IController,
  IViewController,
  IHasUniversalID,
  IReferrerDependentValidity,
  ICustomValidity,
  IValidity,
  IRPCAuthChecks
{
  [Notify]
  public static ThreadSafeAction<AppointedTitle> ManagerSetAliasRenamedEvent { get; }

  public static ThreadSafeAction<Title, IEnumerable<User>> ManagerSetChangedEvent { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  [ScanProp]
  [IgnoreValidity]
  [AllowEmpty]
  public DualPermissions DualPermissions { get; set; }

  public IEnumerable<IAlias> AppointedBy { get; }

  public override bool ContainsUser(User user);

  public override bool ContainsExactAlias(IAlias alias);

  public override IEnumerable<User> UserSet { get; }

  public override IEnumerable<User> DirectOccupants { get; }

  public override void AddOccupant(User user, LocString reason);

  public override void RemoveOccupant(User user, LocString reason);

  public override void Clear();

  public override LocString OccupantString { get; }

  public override void Initialize();

  protected override bool SyncUp();

  public override LocString Description();

  public override void Destroyed();

  public LocString GetSubmitButtonName();

  public override bool RecurringTransfersIsActive();

  public Result Valid(Type parentType, Type rootType);

  bool IRPCAuthChecks.IsRPCAuthorized(
    IWorldObserver observer,
    AccessType requiredAccess,
    object[] args);
}
