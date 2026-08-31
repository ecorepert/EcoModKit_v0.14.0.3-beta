// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.TorchItem
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
using Eco.Shared.Serialization;
using Eco.Shared.SharedTypes;
using Eco.Shared.View;

#nullable disable
namespace Eco.Mods.TechTree;

/// <summary>
/// <para>Server side item definition for the "Torch" item.</para>
/// <para>More information about ToolItem objects can be found at https://docs.play.eco/api/server/eco.gameplay/Eco.Gameplay.Items.ToolItem.html</para>
/// </summary>
/// <remarks>
/// This is an auto-generated class. Don't modify it! All your changes will be wiped with next update! Use Mods* partial methods instead for customization.
/// If you wish to modify this class, please create a new partial class or follow the instructions in the "UserCode" folder to override the entire file.
/// </remarks>
[Serialized]
[LocDisplayName("Torch")]
[Eco.Gameplay.Items.Weight(500)]
[Eco.Gameplay.Items.Fuel(8000f)]
[Tag("Fuel")]
[Ecopedia("Items", "Tools", true, true, null)]
[SalvageCost(new object[] {typeof (WoodScrap), 0.1f})]
[Tag("Torch")]
[LocDescription("A little bit of light to help beat back the night.")]
public class TorchItem : 
  ToolItem,
  IInteractor,
  IHasInteractions,
  IController,
  IViewController,
  IHasUniversalID
{
  public override IDynamicValue SkilledRepairCost { get; }

  [Interaction(InteractionTrigger.LeftClick, null, InteractionModifier.None, null, 0.0f, 0.0f, ClientPredictedBlockAction.None, 0, true, TriBool.True, null, AccessType.FullAccess, (InteractionFlags) 0, null, false, new string[] {}, Flags = InteractionFlags.NoTargetRequired)]
  public void TorchInteraction(
    Player player,
    InteractionTriggerInfo trigger,
    InteractionTarget target);
}
