// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.PlacementItemObject
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Gameplay.Components;
using Eco.Gameplay.Components.Auth;
using Eco.Gameplay.Housing;
using Eco.Gameplay.Interactions.Interactors;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Objects.Internal;
using Eco.Gameplay.Players;
using Eco.Shared.Items;
using Eco.Shared.Serialization;
using Eco.Shared.SharedTypes;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Mods.TechTree;

/// <summary>A placed item, like surface. Basically a world object wrapper for an item, which queries for the item's tool mesh on the client and spawns that.</summary>
[Serialized]
[Tag("Usable")]
[RequireComponent(typeof (ForSaleComponent), null)]
[RequireComponent(typeof (PropertyAuthComponent), null)]
[MayHaveComponent(typeof (HousingComponent), null)]
public class PlacementItemObject : WorldObject, IHasInteractions, IHasControlPopupNotes
{
  [SyncToView(null, true)]
  public virtual 
  #nullable disable
  string IconName { get; }

  protected override void Initialize();

  [Interaction(InteractionTrigger.LeftClick, null, InteractionModifier.None, null, 0.0f, 0.0f, ClientPredictedBlockAction.Harvest, 0, false, TriBool.False, null, AccessType.FullAccess, (InteractionFlags) 0, null, false, new string[] {}, Priority = 2f, MinCaloriesRequired = 0.0f, Flags = InteractionFlags.SurfacePlacedSpecialHierarchyAuth)]
  public Task<bool> Take(Player player, InteractionTriggerInfo trigger, InteractionTarget target);

  /// <summary> Happens after TakingItem was transferred to player inventory </summary>
  protected virtual void OnAfterTake();

  /// <summary> Happens before TakingItem was transferred to player inventory </summary>
  protected virtual void OnBeforeTake();

  /// <summary> Happens right after this world object was placed </summary>
  public virtual void OnPostPlace();

  public override float Priority { get; }

  public string Notes();
}
