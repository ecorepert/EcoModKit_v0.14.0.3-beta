// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.Contracts.ContractClauseNested
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Players;
using Eco.Gameplay.Utils;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Economy.Contracts;

/// <summary> Contract clause that can host other contract clauses. </summary>
[Serialized]
[LocDescription("This clause allows you to define a set of sub-clauses. You can define how many of the sub-classes must be satisfied for this clause to succeed: All, Any, or None.\n\nThis clause is useful for making complex requirements with multiple options for success.")]
public class ContractClauseNested : 
  ContractClause,
  IClauseList,
  IHasClientControlledContainers,
  IController,
  IViewController,
  IHasUniversalID
{
  [Serialized]
  [SyncToView(null, true)]
  [AutoRPC]
  public NestingType Nesting { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public 
  #nullable disable
  ControllerList<ContractClause> Clauses { get; set; }

  public override LocString Name { get; }

  public override LocString Describe { get; }

  public override IEnumerable<Picker> Pickers { get; }

  public override void Initialize(User contractor, User client);

  public override void TryPostJob(GameActionPack pack, User client);

  public override void TryJoin(GameActionPack pack, User contractor, User client);

  public override void TryFail(GameActionPack pack, User contractor, User client);

  public override Result Valid(User contractor, User client);

  public override bool ActionPerformed(GameAction action);

  public override Result CanSucceed(User contractor, User client);

  public override bool ShouldOverrideAuth(GameAction context);

  public override void OnDisabled();
}
