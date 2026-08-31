// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.Contracts.ContractClauseTransport
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
using Eco.Shared.Serialization;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Economy.Contracts;

[Serialized]
[LocDescription("Transport all materials from container A to container B.\n\nThe contractor will be granted authorization rights to remove items from container A and add them container to B.")]
public class ContractClauseTransport : ContractClause, IOpenHandler
{
  [SyncToView(null, true)]
  [Serialized]
  public PickerTracker MoveSource { get; set; }

  [SyncToView(null, true)]
  [Serialized]
  public PickerTracker MoveDestination { get; set; }

  [SyncToView(null, true)]
  public string Contents { get; }

  public override LocString Name { get; }

  public override LocString Describe { get; }

  public override IEnumerable<Picker> Pickers { get; }

  public override void Initialize(User contractor, User client);

  public override Result Valid(User contractor, User client);

  public override Result CanSucceed(User contractor, User client);

  public override void TryJoin(GameActionPack pack, User contractor, User client);

  public override bool ShouldOverrideAuth(GameAction action);

  public override bool ActionPerformed(GameAction action);

  public void OnOpen(User user);
}
