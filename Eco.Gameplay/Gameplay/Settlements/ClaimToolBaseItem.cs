// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Settlements.ClaimToolBaseItem
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Interactions.Interactors;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Gameplay.Property;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.SharedTypes;
using Eco.Shared.View;

#nullable enable
namespace Eco.Gameplay.Settlements;

/// <summary>
/// The ClaimToolBaseItem serves as a representation of the 'Claim Tool' object.
/// It contains the actions performed to expand, or remove plots from selected deed/property.
///  </summary>
[LocDisplayName("Claim Tool")]
[LocDescription("Allows adding or removing plots from any deeds you own.")]
[Serialized]
public abstract class ClaimToolBaseItem : 
  ToolItem,
  IThreadSafeSubscriptions,
  ISubscriptions<ThreadSafeSubscriptions>,
  ISubscriptions,
  IInteractor,
  IHasInteractions,
  IController,
  IViewController,
  IHasUniversalID
{
  /// <summary>If this is set, allow it to claim without papers.</summary>
  public bool UnlimitedClaiming;

  public override ItemHandOrigin HandOrigin { get; }

  [Serialized]
  [SyncToView(null, true)]
  public 
  #nullable disable
  Deed Deed { get; set; }

  public override bool Decays { get; }

  [Interaction(InteractionTrigger.RightClick, null, InteractionModifier.None, null, 10f, 0.0f, ClientPredictedBlockAction.None, 0, true, TriBool.None, null, AccessType.FullAccess, InteractionFlags.BlocksOtherInteraction | InteractionFlags.SendsInteractImmediatelyButStillAnimates, null, false, new string[] {})]
  public bool Claim(Player player, InteractionTriggerInfo triggerInfo, InteractionTarget target);

  [Interaction(InteractionTrigger.LeftClick, null, InteractionModifier.None, null, 10f, 0.0f, ClientPredictedBlockAction.None, 0, true, TriBool.None, null, AccessType.FullAccess, InteractionFlags.BlocksOtherInteraction | InteractionFlags.SendsInteractImmediatelyButStillAnimates, null, false, new string[] {})]
  public bool Unclaim(Player player, InteractionTriggerInfo triggerInfo, InteractionTarget target);

  public override void OnSelected(Player player);

  public override void OnDeselected(Player player);

  /// <summary>Allow changing assigned deed when right-clicked.</summary>
  public override string OnUsed(Player player, ItemStack itemStack);

  public ref ThreadSafeSubscriptions Subscriptions { get; }
}
