// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Objects.WorldObjectComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Aliases;
using Eco.Gameplay.Interactions.Interactors;
using Eco.Gameplay.Items;
using Eco.Gameplay.Players;
using Eco.Gameplay.Property;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Gameplay.Systems.TextLinks;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using PropertyChanged;
using System.ComponentModel;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Gameplay.Objects;

/// <summary>Base class for all world object components. Icon attribute should be applied on a particular descendant, do not put it here.</summary>
[Serialized]
[IconGroup("WorldObjectComponent")]
[DerivedMustDefineIcon]
public abstract class WorldObjectComponent : 
  IController,
  IViewController,
  IHasUniversalID,
  ILinkable,
  IOwned,
  IHasSerializableID,
  IRPCAuthChecks,
  INotifyPropertyChanged,
  IThreadSafeSubscriptions,
  ISubscriptions<ThreadSafeSubscriptions>,
  ISubscriptions,
  IHasInteractions
{
  [SyncToView(SyncFlags.CyclicRef)]
  public 
  #nullable disable
  WorldObject Parent { get; internal set; }

  [SyncToView(null, true)]
  [Serialized]
  public string Name { get; internal set; }

  [SyncToView(null, true)]
  public virtual string IconName { get; }

  [SyncToView(null, true)]
  public bool ForceActiveTab { get; internal set; }

  [SyncToView(null, true)]
  public bool HiddenTab { get; internal set; }

  [SyncToView(null, true)]
  public bool DefaultSelectedTab { get; internal set; }

  [SyncToView(null, true)]
  public virtual string ComponentPrefabName { get; }

  [SyncToView(null, true)]
  public virtual LocString ComponentTabName { get; }

  /// <summary>Flag representing whether or not this component is functioning.  World object enabled state is true if all components are enabled.</summary>
  public virtual bool Enabled { get; }

  public bool IsDestroyed { get; }

  public virtual WorldObjectComponentClientAvailability Availability { get; }

  public virtual bool ShouldRequestEverything { get; }

  [SyncToView(null, true)]
  public virtual IAlias Owners { get; }

  public virtual bool IsRPCAuthorized(
    IWorldObserver observer,
    AccessType requiredAccess,
    object[] args);

  [SyncToView(null, true)]
  public string CopyPasteGroupName { get; }

  [RPC(AccessType.FullAccess)]
  public Task PasteComponentFrom(Player player, int sourceComponentId);

  public event PropertyChangedEventHandler PropertyChanged;

  [DoNotNotify]
  public ref int ControllerID { get; }

  /// <summary>Called to initialize the <see cref="T:Eco.Gameplay.Objects.WorldObjectComponent" /> instance. Components that need a tab also should define HasIcon for themselves, so record a warning if check is failed.</summary>
  public virtual void Initialize();

  public virtual void PostInitialize();

  public virtual void OnCreate();

  /// <summary>Called to destroy the <see cref="T:Eco.Gameplay.Objects.WorldObjectComponent" /> instance.</summary>
  public virtual void Destroy();

  public virtual void Tick();

  public virtual void LateTick();

  public virtual InventoryMoveResult TryPickup(
    Player player,
    InventoryChangeSet invChanges,
    Inventory targetInventory,
    bool force);

  public virtual void OnPickup(Player player);

  /// <summary> Called once the object's move action has been confirmed, but before the actual movement takes place (so the position will be the one before the movement). </summary>
  /// <remarks> Use this to clean up anything that needs to be cleaned up (e.g.: leftover blocks of stockpile). </remarks>
  public virtual void OnBeforeObjectMoved();

  /// <summary> Called once the object's move action has been confirmed and the position has been updated. </summary>
  /// <remarks> Use this to re-initialize anything that needs it (e.g.: leftover blocks of stockpile). </remarks>
  public virtual void OnAfterObjectMoved();

  /// <summary>Called when a component gets added later after initialization.</summary>
  public virtual void OnComponentAddedPostInit(WorldObjectComponent c);

  /// <summary>Called on the surviving component when a duplicate base-type sibling is removed from the object, so it can absorb persisted state.</summary>
  internal virtual void AbsorbSuperseded(WorldObjectComponent superseded);

  public void OnLinkClicked(TooltipOrigin origin, TooltipClickContext clickContext, User user);

  public LocString UILinkContent();

  Deed IOwned.Deed { get; }

  public ref ThreadSafeSubscriptions Subscriptions { get; }
}
