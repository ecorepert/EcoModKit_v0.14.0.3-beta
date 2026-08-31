// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.FishingPoleItem
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Core.Systems;
using Eco.Gameplay.DynamicValues;
using Eco.Gameplay.Interactions.Interactors;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.SharedTypes;
using Eco.Shared.View;
using System.Numerics;

#nullable disable
namespace Eco.Mods.TechTree;

[Serialized]
[LocDisplayName("Fishing Pole")]
[LocDescription("A wooden pole attached to a line and hook. Used to catch fish from rivers and the ocean.")]
[Eco.Gameplay.Items.Weight(1000)]
[SalvageCost(new object[] {typeof (WoodScrap), 1f})]
[Ecopedia("Items", "Tools", true, true, null)]
public class FishingPoleItem : 
  ToolItem,
  IInteractor,
  IHasInteractions,
  IController,
  IViewController,
  IHasUniversalID
{
  public override bool CanBeUsedWithEmotes { get; }

  public override IDynamicValue SkilledRepairCost { get; }

  public LureEntity Lure { get; }

  public override IDynamicValue CaloriesBurn { get; }

  /// <summary> Creates the LureEntity from a Client-command, assigning its controller, position, and the force to apply at spawn. </summary>
  [RPC]
  public int CastLure(Player player, Vector3 position, Vector3 castForce);

  [Interaction(InteractionTrigger.LeftClick, null, InteractionModifier.None, null, 0.0f, 0.0f, ClientPredictedBlockAction.None, 0, true, TriBool.False, null, AccessType.ConsumerAccess, (InteractionFlags) 0, null, false, new string[] {}, Flags = InteractionFlags.NoTargetRequired)]
  public void CastInteraction(
    Player player,
    InteractionTriggerInfo trigger,
    InteractionTarget target);
}
