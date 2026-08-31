// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.TradeAction
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using LiteDB;

#nullable disable
namespace Eco.Gameplay.GameActions;

[Eco.Shared.Networking.Eco(true, Serialized = false)]
public abstract class TradeAction : 
  ItemInteractAction,
  IWorldObjectGameAction,
  IController,
  IViewController,
  IHasUniversalID
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Number of items in the transaction")]
  public float NumberOfItems { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Was the good bought or sold by the initiating player?")]
  public BoughtOrSold BoughtOrSold { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The owner of the shop where the trade occurred.")]
  public User ShopOwner { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The buying player.")]
  public User Buyer { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The selling player.")]
  public User Seller { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The tag traded, if this was a tag-based trade.")]
  public Tag TagUsed { get; set; }

  [BsonIgnore]
  [CanAutoAssign]
  public WorldObject WorldObject { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  [LocDescription("The object targeted.")]
  public Item WorldObjectItem { get; }

  public bool OverrideHierarchyActionsToConsumer { get; }
}
