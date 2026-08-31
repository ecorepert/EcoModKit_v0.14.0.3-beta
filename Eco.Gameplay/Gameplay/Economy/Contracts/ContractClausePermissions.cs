// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.Contracts.ContractClausePermissions
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Utils;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Players;
using Eco.Gameplay.Utils;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Economy.Contracts;

[Serialized]
[LocDescription("This clause will grant the contractor authorization to the selected object or property. Authorization can be granted temporarily for the length of the contract, or it can be given permanently. This permission can be given at either the beginning or end of the contract.\n\nIf you need a player to deliver something in a private container, or build on private land, you'll need to set their permissions with this clause to ensure they have access. Players accepting a contract should always ensure that they will receive the needed permissions to perform it.")]
public class ContractClausePermissions : ContractClause, IDisposable
{
  protected static readonly LocString PickerDescription;

  [Serialized]
  [SyncToView(null, true)]
  [AutoRPC]
  public bool PropertyRights { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public Picker Position { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  [AutoRPC]
  public bool Permanent { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  [AutoRPC]
  public bool Beginning { get; set; }

  [Notify]
  public override IEnumerable<Picker> Pickers { get; }

  public override LocString Name { get; }

  public override LocString Describe { get; }

  public override void Initialize(User contractor, User client);

  public override Result Valid(User contractor, User client);

  public override void TryJoin(GameActionPack pack, User contractor, User client);

  public override void TrySucceed(GameActionPack pack, User contractor, User client, bool forced);

  public override void TryFail(GameActionPack pack, User contractor, User client);

  protected LocString SetAuth(User user, bool set);

  ~ContractClausePermissions();

  public void Dispose();

  protected virtual void Dispose(bool disposing);
}
