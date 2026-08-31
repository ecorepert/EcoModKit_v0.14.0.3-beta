// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.Contracts.ContractClauseRemoval
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Utils;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Players;
using Eco.Gameplay.Property;
using Eco.Gameplay.Utils;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Economy.Contracts;

[Serialized]
[LocDescription("Remove all tree stumps and debris from the property under the given marker.\n\nThe contractor will be temporarily rights to remove debris and stumps on the specified property.\n\nNote: You can split property into seperate deeds for more control.")]
public class ContractClauseRemoval : ContractClause, IDeedRelated
{
  [SyncToView(null, true)]
  [Serialized]
  public PickerProperty Property { get; set; }

  [SyncToView(null, true)]
  [Serialized]
  public string Contents { get; set; }

  public override LocString Name { get; }

  public override LocString Describe { get; }

  public override IEnumerable<Picker> Pickers { get; }

  public Deed GetDeed { get; }

  public void RecalculateDeedRelatedData();

  [RPC]
  public void RecalculateLandscape(Player player);

  public override Result Valid(User contractor, User client);

  public override Result CanSucceed(User contractor, User client);

  public override bool ShouldOverrideAuth(GameAction action);
}
