// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.RepairBountyComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.PropertyHandling;
using Eco.Core.Utils;
using Eco.Gameplay.Economy;
using Eco.Gameplay.Interactions.Interactors;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.EnvVars;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.SharedTypes;
using System;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Gameplay.Components;

/// <summary>A component that allows purchase + pickup of a world object.</summary>
[Serialized]
[HasIcon(null)]
[CreateComponentTabLoc("Parts", true)]
[LocDescription("Allows setting a bounty for repairs made to this object.")]
[Priority(100)]
public class RepairBountyComponent : 
  WorldObjectComponent,
  IHasEnvVars,
  IPersistentData,
  ICopyPasteComponent
{
  [SyncToView(null, true)]
  [Autogen]
  [UITypeName("StringTitle")]
  public LocString Title { get; set; }

  [Eco.Shared.Networking.Eco(AccessType.FullAccess)]
  [VisibilityParam("HasOwner")]
  public bool OfferRepairBounty { get; set; }

  [Eco.Shared.Networking.Eco(AccessType.FullAccess)]
  [VisibilityParam("OfferRepairBounty")]
  [LocDescription("Defines the price that will be paid if all parts are fully broken to be totally replaced. If parts are partially broken, a prorated amount will be charged based on how percentage broken (ie, repairing 50% broken pays out 50% of this price)")]
  public float Price { get; set; }

  [Eco.Shared.Networking.Eco(AccessType.FullAccess)]
  [VisibilityParam("OfferRepairBounty")]
  public 
  #nullable disable
  Currency Currency { get; set; }

  [Eco.Shared.Networking.Eco(AccessType.FullAccess)]
  [VisibilityParam("OfferRepairBounty")]
  public BankAccount OwnerAccount { get; set; }

  [Eco.Shared.Networking.Eco(AccessType.FullAccess)]
  [VisibilityParam("OfferRepairBounty")]
  [Range(0.0f, 100f)]
  [LocDescription("Must be 0-100. Defines what the durability level of parts must drop below before you will pay for a replacement.")]
  public float AllowRepairWhenDurabilityDropsToPercentOrBelow { get; set; }

  [Eco.Shared.Networking.Eco(AccessType.FullAccess)]
  [VisibilityParam("OfferRepairBounty")]
  [Range(0.0f, 100f)]
  [LocDescription("Must be 0-100. When items are repaired, their max durability (called 'Integrity') drops. This limits what item's you'll accept as a replacement, based on their integrity.")]
  public float ItemsMustHaveIntegrityAtOrAbovePercent { get; set; }

  [SyncToView(null, true)]
  public bool HasOwner();

  /// <summary>Can only buy it if its for sale, has valid props, and user isnt already an owner (unless force enabled)</summary>
  [SyncToView(null, true)]
  [Notify]
  [EnvVar]
  [DependsOnSubMember("Parent", "AdminForceEnabled")]
  [DependsOnSubMember("Parent", "Owners")]
  [DependsOnMember("OfferRepairBounty")]
  [DependsOnMember("Currency")]
  [DependsOnMember("OwnerAccount")]
  public bool ShowRepairBounty(User user = null);

  [Interaction(InteractionTrigger.RightClick, "Replace Parts for %RepairPriceString%", InteractionModifier.Ctrl, new string[] {"ShowRepairBounty"}, 0.0f, 10f, ClientPredictedBlockAction.None, 0, false, TriBool.None, null, AccessType.None, (InteractionFlags) 0, null, false, new string[] {})]
  public void RepairInteraction(
    Player player,
    InteractionTriggerInfo trigger,
    InteractionTarget target);

  [EnvVar]
  [DependsOnMember("Price")]
  [DependsOnMember("Currency")]
  public string RepairPriceString { get; }

  [Serialized]
  public RepairBountyData SaleData { get; set; }

  public object PersistentData { get; set; }

  public override void OnCreate();

  public override void Initialize();

  public Type CopyPasteGroup { get; }

  public LocString OverwriteWarning { get; }

  public Result CopyFrom(WorldObjectComponent source, Player player);

  public override void Destroy();

  public float RepairDurability { get; }

  [RPC]
  public Task ReplaceParts(User user);

  /// <summary>Calculates the prorated price based on how broken the thing is.</summary>
  public float ProratedPrice();
}
