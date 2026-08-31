// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.BlockHarvestItem
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

#nullable disable
namespace Eco.Mods.TechTree;

/// <summary>Wrapper for tools like sickle and scythe, contains same code.</summary>
public abstract class BlockHarvestItem : 
  ToolItem,
  IInteractor,
  IHasInteractions,
  IController,
  IViewController,
  IHasUniversalID
{
  [Interaction(InteractionTrigger.LeftClick, null, InteractionModifier.None, null, 0.0f, 0.0f, ClientPredictedBlockAction.None, 0, true, TriBool.None, null, AccessType.FullAccess, (InteractionFlags) 0, null, false, new string[] {"Reapable"})]
  public bool Reap(Player player, InteractionTriggerInfo triggerInfo, InteractionTarget target);
}
