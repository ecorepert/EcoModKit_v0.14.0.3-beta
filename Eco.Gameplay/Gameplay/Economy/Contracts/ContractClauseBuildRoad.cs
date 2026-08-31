// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.Contracts.ContractClauseBuildRoad
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
[LocDescription("Defines a road that must be built between points A and B, defined by placing a ConstructionPostItem at each position. The width of the road must be the defined minimum throughout, and it must be made entirely of the listed material.")]
public class ContractClauseBuildRoad : ContractClause
{
  [Serialized]
  [SyncToView(null, true)]
  public SearchAndSelectItem SelectedItem { get; }

  [Serialized]
  [SyncToView(null, true)]
  public PickerObject From { get; }

  [Serialized]
  [SyncToView(null, true)]
  public PickerObject To { get; }

  [Serialized]
  [SyncToView(null, true)]
  [AutoRPC]
  public int Width { get; set; }

  public override LocString Name { get; }

  public override LocString Describe { get; }

  public override IEnumerable<Picker> Pickers { get; }

  public override Result Valid(User contractor, User client);

  public override bool ShouldOverrideAuth(GameAction action);

  public override Result CanSucceed(User contractor, User client);
}
