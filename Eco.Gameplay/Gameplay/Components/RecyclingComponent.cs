// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.RecyclingComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Core.Utils;
using Eco.Gameplay.Components.Storage;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;
using Eco.Shared.View;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Components;

/// <summary>Recycles items from the sibling <see cref="T:Eco.Gameplay.Components.Storage.PublicStorageComponent" /> at a constant rate, emitting garbage blocks via
/// <see cref="T:Eco.Gameplay.Garbage.GarbageBlockBuilder" />. The lost fraction is routed to each source material's <see cref="P:Eco.Gameplay.Garbage.GarbageMaterial.DegradedForm" />.</summary>
[Serialized]
[RequireComponent(typeof (StatusComponent), null)]
[RequireComponent(typeof (RecyclingLinkComponent), "Recycling")]
[RequireComponent(typeof (InOutLinkedInventoriesComponent), null)]
[RequireComponent(typeof (OnOffComponent), null)]
[RequireComponent(typeof (MustBeOwnedComponent), null)]
[RequireComponent(typeof (PublicStorageComponent), null)]
[Priority(100)]
[Ecopedia(null, "Recycler Item", false, true, null)]
[CreateComponentTabLoc("Recycling", false)]
[HasIcon("RecyclingComponent")]
public class RecyclingComponent : 
  WorldObjectComponent,
  IOperatingWorldObjectComponent,
  IPersistentData,
  IPickupConfirmationComponent,
  IItemConsumingComponent
{
  public IEnumerable<Inventory> ConsumedInventories { get; }

  public override WorldObjectComponentClientAvailability Availability { get; }

  public bool Operating { get; }

  [Serialized]
  public object PersistentData { get; set; }

  [SyncToView(null, true)]
  public Inventory InputInventory { get; }

  [SyncToView(null, true)]
  public Item CurrentItem { get; }

  [SyncToView(null, true)]
  public Item OutputItem { get; }

  [SyncToView(null, true)]
  public float ProcessRate { get; }

  [SyncToView(null, true)]
  public float Efficiency { get; }

  [SyncToView(null, true)]
  public LocString RecyclableItems { get; }

  [SyncToView(SyncFlags.MustRequest)]
  public ImmutableCountdown CurrentItemTime { get; }

  [SyncToView(SyncFlags.MustRequest)]
  public ImmutableCountdown OutputBlockTime { get; }

  [SyncToView(SyncFlags.MustRequest)]
  public LocString OutputContents { get; }

  [SyncToView(null, true)]
  public override string IconName { get; }

  /// <summary>Configures processing parameters. Call from the WorldObject's PostInitialize.</summary>
  public void Initialize(float processRate = 0.1f, float efficiency = 0.75f);

  public override void Initialize();

  public override void PostInitialize();

  public override void Destroy();

  public override void Tick();

  public Result CanPickup();
}
