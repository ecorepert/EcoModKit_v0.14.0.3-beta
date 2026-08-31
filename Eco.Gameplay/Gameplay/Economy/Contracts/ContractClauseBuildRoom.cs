// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.Contracts.ContractClauseBuildRoom
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
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Economy.Contracts;

[Serialized]
[LocDescription("Defines a position where a room must be built, with a minimum volume and made of at least the listed materials.\nThe position is marked by a {Item.Get(ConstructionPostItem).UILink()}, and you must place one on the location you want the room built.")]
public class ContractClauseBuildRoom : ContractClause
{
  [Serialized]
  [SyncToView(null, true)]
  public PickerObject Position { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  [AutoRPC]
  public int Volume { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  [AutoRPC]
  public float Tier { get; set; }

  public override LocString Name { get; }

  public override LocString Describe { get; }

  public override IEnumerable<Picker> Pickers { get; }

  public override Result Valid(User contractor, User client);

  public override Result CanSucceed(User contractor, User client);

  public override bool ShouldOverrideAuth(GameAction action);
}
