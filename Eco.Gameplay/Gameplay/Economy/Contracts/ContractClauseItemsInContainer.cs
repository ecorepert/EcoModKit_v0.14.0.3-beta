// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.Contracts.ContractClauseItemsInContainer
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
[LocDescription("Defines a container that must contain a set of objects. Both you and the contractor must have access rights on the selected container.\n\nYou can automatically give the contractor access rights to the container for the term of the contract with an additional Permissions contract clause.")]
public class ContractClauseItemsInContainer : ContractClause, IItemPickerClause
{
  [Serialized]
  [SyncToView(null, true)]
  public SearchAndSelectInventory Items { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public PickerTracker Container { get; set; }

  [SyncToView(null, true)]
  [AutoRPC]
  public string Contents { get; }

  public override LocString Name { get; }

  public override LocString Describe { get; }

  public override IEnumerable<Picker> Pickers { get; }

  public override void Initialize(User contractor, User client);

  public override void TryJoin(GameActionPack pack, User contractor, User client);

  public override Result CanSucceed(User contractor, User client);

  public override Result Valid(User contractor, User client);

  public override bool ShouldOverrideAuth(GameAction action);

  public override bool ActionPerformed(GameAction action);
}
