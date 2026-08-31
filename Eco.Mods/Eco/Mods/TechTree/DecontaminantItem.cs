// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.DecontaminantItem
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Interactions.Interactors;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Shared.Items;
using Eco.Shared.SharedTypes;
using Eco.Shared.View;
using Eco.World.Blocks;

#nullable disable
namespace Eco.Mods.TechTree;

[System.ComponentModel.Category("Hidden")]
[Eco.Gameplay.Items.MaxStackSize(50)]
public abstract class DecontaminantItem : 
  Item,
  IInteractor,
  IHasInteractions,
  IController,
  IViewController,
  IHasUniversalID
{
  public abstract GroundPollutionType TargetType { get; }

  public abstract float Potency { get; }

  [Interaction(InteractionTrigger.LeftClick, null, InteractionModifier.None, null, 5f, 0.0f, ClientPredictedBlockAction.None, 0, false, TriBool.None, null, AccessType.FullAccess, (InteractionFlags) 0, null, false, new string[] {"Samplable", "Clearable", "Garbage", "Constructed"})]
  public bool ApplyDecontaminant(
    Player player,
    InteractionTriggerInfo triggerInfo,
    InteractionTarget target);
}
