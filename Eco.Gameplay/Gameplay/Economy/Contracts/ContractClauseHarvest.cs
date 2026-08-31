// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.Contracts.ContractClauseHarvest
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Utils;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Items.SearchAndSelect;
using Eco.Gameplay.Players;
using Eco.Gameplay.Property;
using Eco.Gameplay.Utils;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Simulation.Types;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Economy.Contracts;

[Serialized]
[LocDescription("All plants yielding the given types of resources must be harvested from this property, and placed into the specified container.\n\nThe contractor will temporarily be given rights to harvest on the specified property.\n\nNote: You can split property into seperate deeds for more control.")]
public class ContractClauseHarvest : ContractClausePropertyBase, IDeedRelated, IItemPickerClause
{
  [Serialized]
  [SyncToView(null, true)]
  public 
  #nullable disable
  SearchAndSelectInventory Items { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public PickerTracker Container { get; }

  [Serialized]
  [SyncToView(null, true)]
  public string OnProperty { get; }

  public override LocString Name { get; }

  public override LocString Describe { get; }

  protected override string PropertyDescription { get; }

  public override IEnumerable<Picker> Pickers { get; }

  public Deed GetDeed { get; }

  public void RecalculateDeedRelatedData();

  public override void Initialize(User contractor, User client);

  public IEnumerable<Species> GetCropSpecies();

  [RPC]
  public void RecalculateHarvest(Player player = null);

  public override void TryJoin(GameActionPack pack, User contractor, User client);

  public override Result CanJoin(User contractor, User client);

  public override Result Valid(User contractor, User client);

  public override Result CanSucceed(User contractor, User client);

  public override bool ShouldOverrideAuth(GameAction action);

  public override bool ActionPerformed(GameAction action);
}
