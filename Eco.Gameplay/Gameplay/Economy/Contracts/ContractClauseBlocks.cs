// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.Contracts.ContractClauseBlocks
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Utils;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Items.SearchAndSelect;
using Eco.Gameplay.Players;
using Eco.Gameplay.Utils;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Economy.Contracts;

[Serialized]
[LocDescription("Defines a set of blocks that must exist, or not exist on a property. This can be used for all kinds of things:\n - Removing unwanted plants\n - Removing pollution\n - Planting fields (planted blocks must exist)\n - Removing structures or obstacles.\n\nIf {Text.Info(Surface)} is checked, only surface blocks will be examined. Otherwise, blocks to a depth of {Text.Info(5)} below the highest block will be examined.")]
public class ContractClauseBlocks : ContractClause, IItemPickerClause
{
  [Serialized]
  [SyncToView(null, true)]
  public SearchAndSelectInventory Items { get; }

  [Serialized]
  [SyncToView(null, true)]
  public PickerProperty Property { get; }

  [Serialized]
  [SyncToView(null, true)]
  [AutoRPC]
  public bool Surface { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  [AutoRPC]
  public bool GreaterThan { get; set; }

  public override IEnumerable<Picker> Pickers { get; }

  public override LocString Name { get; }

  public override LocString Describe { get; }

  public override Result Valid(User contractor, User client);

  public override void TryJoin(GameActionPack pack, User contractor, User client);

  public override bool ShouldOverrideAuth(GameAction action);

  public override Result CanSucceed(User contractor, User client);
}
