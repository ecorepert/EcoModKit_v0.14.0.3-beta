// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.LinkComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using ConcurrentCollections;
using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Aliases;
using Eco.Gameplay.Components.Storage;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable enable
namespace Eco.Gameplay.Components;

/// <summary> This component manages connections to other world objects within a given radius </summary>
/// <remarks> This assumes the world object is stationary </remarks>
/// <inheritdoc />
[Serialized]
[LocDescription("Access the inventory of this object and any inventories in range.")]
[Priority(2147483647 /*0x7FFFFFFF*/)]
[CreateComponentTabLoc("Storage", false)]
[HasIcon("StorageComponent")]
[Ecopedia(null, "Storage Component", false, true, null)]
public class LinkComponent : WorldObjectComponent
{
  public static float MaxConnectRadius;

  public static float ConnectionRadiusModifier { get; set; }

  public static float DefaultConnectionRadius { get; set; }

  public 
  #nullable disable
  ConcurrentHashSet<LinkComponent> LinkedObjects { get; }

  public override WorldObjectComponentClientAvailability Availability { get; }

  /// <summary>Radius measurement used to connect to other objects as defined in the object's definition.</summary>
  public float BaseConnectionRadius { get; }

  /// <summary>Radius measurement used to connect to other objects with applied modifiers. Based on the <see cref="P:Eco.Gameplay.Components.LinkComponent.BaseConnectionRadius" />.</summary>
  public float ObjectConnectionRadius { get; }

  /// <summary>Keeps this object out of every other object's linked storage list, its owner included. Internal wiring components set it once;
  /// players toggle it from the storage panel to stop a container cluttering the benches around it.</summary>
  [Serialized]
  [Eco.Shared.Networking.Eco(true, RequiredAccess = AccessType.FullAccess)]
  public bool Hidden { get; set; }

  public ThreadSafeAction<StorageComponent> OnLinked { get; }

  public ThreadSafeAction<StorageComponent> OnDelinked { get; }

  public ThreadSafeAction OnInventoryContentsChanged { get; }

  public ThreadSafeAction LinkedInventoryChangeEvent { get; }

  [Eco.Shared.Networking.Eco(true, RequiredAccess = AccessType.FullAccess)]
  public bool AutoLink { get; set; }

  [SyncToView(null, true)]
  protected Dictionary<StorageComponent, LinkComponent.LinkSettings> LinkedComponents(Player player);

  [SyncToView(null, true)]
  public override string IconName { get; }

  /// <summary> This alias will be used to get settings instead of provided one.
  /// For demo see how shared link component overrides this value and returns parent's owner. </summary>
  protected virtual IAlias LinkSettingsAlias(IAlias alias);

  /// <summary>True when this viewer's link edits land in the property-wide settings shared by every full-access user, false when they are personal.</summary>
  protected virtual bool SharesSettingsFor(IAlias alias);

  [SyncToView(null, true)]
  public bool SharedSettings(Player player);

  public LinkComponent();

  public LinkComponent(float connectRadius);

  public void Initialize(float connectRadius);

  public override void Initialize();

  internal void PruneSettings();

  /// <summary>Re-keys settings entries stored about <paramref name="previousId" /> to <paramref name="newId" />. Used when a movable
  /// object is placed again under a fresh id, so the link settings other storages kept about it keep applying.</summary>
  internal void MigrateSettingsKeys(Guid previousId, Guid newId);

  internal override void AbsorbSuperseded(WorldObjectComponent superseded);

  public void SetConnectRadius(float value);

  public InventoryCollection GetSortedLinkedInventoriesAndUser(Player player);

  public InventoryCollection GetSortedLinkedInventories(IAlias alias);

  /// <summary>
  /// Get Sorted linked storages which are able to take/put items. NOTE: will not omit
  /// storages with disabled link settings.</summary>
  /// <param name="alias"></param>
  /// <param name="source">is able to take items</param>
  /// <param name="target">is able to put items</param>
  /// <returns>list of storages</returns>
  public IEnumerable<StorageComponent> GetSortedLinkedComponents(
    IAlias alias,
    bool source,
    bool target);

  public IEnumerable<StorageComponent> GetSortedLinkedEnabledStorages(IAlias alias);

  public IEnumerable<StorageComponent> GetEnabledLinkedStorages(IAlias alias);

  public List<StorageComponent> GetLinkedStorages<T>(IAlias alias) where T : WorldObjectComponent;

  public IEnumerable<(StorageComponent Storage, LinkComponent.LinkSettings Settings)> GetLinkedStoragesWithSettings(
    IAlias alias);

  public IEnumerable<LinkComponent> GetAuthorizedLinkedObjects(IAlias alias);

  public IEnumerable<ItemStack> GetAllLinkedStacks(IAlias alias, bool source, bool target);

  protected virtual void Relink();

  public override void OnAfterObjectMoved();

  public override void Destroy();

  public LinkComponent.LinkSettings GetLinkSettings(IAlias alias, StorageComponent comp);

  public LinkComponent.LinkSettings GetLinkSettings(
    IAlias alias,
    WorldObject linkedObj,
    Type compType);

  /// <summary>
  /// Gets <see cref="T:Eco.Gameplay.Components.LinkComponent.LinkSettings" /> which <see langword="this" /> should use when linking to <see cref="T:Eco.Gameplay.Components.Storage.StorageComponent" /> of type <paramref name="compType" />
  /// attached to <paramref name="linkedObj" />
  /// </summary>
  /// <param name="alias"></param>
  /// <param name="linkedObj"><see cref="T:Eco.Gameplay.Objects.WorldObject" /> that <see langword="this" /> wants to link to</param>
  /// <param name="compType"><see cref="T:System.Type" /> of <see cref="T:Eco.Gameplay.Components.Storage.StorageComponent" /> attached to <paramref name="linkedObj" /> for which <see cref="T:Eco.Gameplay.Components.LinkComponent.LinkSettings" /> will be returned</param>
  protected virtual LinkComponent.LinkSettings NewDefaultLinkSettings(
    IAlias alias,
    WorldObject linkedObj,
    Type compType);

  [RPC(AccessType.None)]
  protected void SetObjectPriority(Player player, StorageComponent comp, int priority);

  public void SetObjectPriority(User user, StorageComponent comp, int priority);

  [RPC(AccessType.None)]
  protected void SetObjectExpanded(Player player, StorageComponent comp, bool expanded);

  public void SetObjectExpanded(User user, StorageComponent comp, bool expanded);

  public void SetObjectEnabled(User user, StorageComponent comp, bool enable);

  [RPC(AccessType.ConsumerAccess)]
  public void SetObjectInput(Player player, StorageComponent comp, bool input);

  [RPC(AccessType.ConsumerAccess)]
  public void SetAllObjectsInput(Player player, bool input);

  public void SetObjectInput(User user, StorageComponent comp, bool input, bool userModified = false);

  [RPC(AccessType.ConsumerAccess)]
  public void SetObjectOutput(Player player, StorageComponent comp, bool output);

  [RPC(AccessType.ConsumerAccess)]
  public void SetAllObjectsOutput(Player player, bool output);

  public void SetObjectOutput(User user, StorageComponent comp, bool output, bool userModified = false);

  [RPC]
  public void ConsolidateLinkedInventory(User user);

  [Serialized]
  [UsesReferenceInHashCode]
  protected class SettingsKey
  {
    [Serialized]
    public IAlias Alias { get; }

    [Serialized]
    public WorldObjectHandle Object { get; }

    [Serialized]
    public Type ComponentType { get; }

    public SettingsKey();

    public SettingsKey(IAlias user, WorldObjectHandle obj, Type componentType);

    public override bool Equals(object obj);

    public override int GetHashCode();
  }

  [Serialized]
  public class LinkSettings : IController, IViewController, IHasUniversalID, INotifyPropertyChanged
  {
    public event PropertyChangedEventHandler PropertyChanged;

    [Serialized]
    [SyncToView(null, true)]
    public int Priority { get; set; }

    [Serialized]
    [SyncToView(null, true)]
    public bool Expanded { get; set; }

    [Serialized]
    [SyncToView(null, true)]
    public bool Input { get; set; }

    [Serialized]
    [SyncToView(null, true)]
    public bool Output { get; set; }

    [Serialized]
    [SyncToView(null, true)]
    public bool UserModified { get; set; }

    public bool Enabled { get; }

    public bool MatchesDefaultValues(LinkComponent.LinkSettings d);

    public ref int ControllerID { get; }
  }
}
