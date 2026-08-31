// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.SoilSamplerItem
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

[Serialized]
[LocDisplayName("Soil Sampler")]
[LocDescription("Beaker and measuring tools for detecting the factors influencing plants in the environment.")]
[System.ComponentModel.Category("Tools")]
[Tag("Tool")]
[Tag("CanBeOnSurface", Unset = true)]
[Ecopedia("Items", "Tools", true, true, null)]
[Eco.Gameplay.Items.Weight(1000)]
public class SoilSamplerItem : 
  ToolItem,
  IInteractor,
  IHasInteractions,
  IController,
  IViewController,
  IHasUniversalID
{
  public override bool Decays { get; }

  public override bool CanBeHeld { get; }

  public override IDynamicValue SkilledRepairCost { get; }

  [Interaction(InteractionTrigger.LeftClick, null, InteractionModifier.None, null, 0.0f, 0.0f, ClientPredictedBlockAction.None, 0, false, TriBool.None, null, AccessType.FullAccess, (InteractionFlags) 0, null, false, new string[] {"Samplable", "Clearable", "Choppable", "Garbage", "Constructed"}, DisallowedEnvVars = new string[] {"felled"})]
  public bool SampleSoil(
    Player player,
    InteractionTriggerInfo triggerInfo,
    InteractionTarget target);
}
