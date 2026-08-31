// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Settlements.SettlementFoundationObject
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.PropertyHandling;
using Eco.Core.Systems;
using Eco.Gameplay.Civics.Objects;
using Eco.Gameplay.Components;
using Eco.Gameplay.Components.Auth;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Placement;
using Eco.Gameplay.Property;
using Eco.Gameplay.Settlements.Components;
using Eco.Shared.Items;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using System.ComponentModel;
using System.Numerics;

#nullable disable
namespace Eco.Gameplay.Settlements;

/// <summary>Base class for objects that define a new settlement.</summary>
[Serialized]
[RequireComponent(typeof (PropertyAuthComponent), null)]
[RequireComponent(typeof (SettlementFoundationComponent), null)]
[RequireComponent(typeof (StatusComponent), null)]
[RequireComponent(typeof (PlotsComponent), null)]
[RequireComponent(typeof (NameDataTrackerComponent), null)]
[RequireComponent(typeof (AuthDataTrackerComponent), null)]
[RelatedFeature("UseSettlementSystem", true)]
[RequireOwnedRoom]
[MayHaveComponent(typeof (SpawnedClaimsComponent), null)]
[RequireComponent(typeof (BorderControlComponent), null)]
public abstract class SettlementFoundationObject : 
  CivicObject,
  IClaimStakeObject,
  INotifyPropertyChanged,
  IObjectMovementLimitedByConstantDistance,
  IController,
  IViewController,
  IHasUniversalID
{
  public bool AutoAddCurrentSettlementsAsChildAndParent;

  public abstract SettlementType SettlementType { get; }

  [Serialized]
  [SyncToView(null, true)]
  [WatchSubMember("Name", "RenameFoundation", SubPropWatcherFlag.None)]
  public Settlement Settlement { get; set; }

  public bool IgnoreSettlementTypeOnClaimPapers { get; set; }

  public override int SlotCount { get; }

  protected override bool InitializeCivicsComponents { get; }

  [SyncToView(null, true)]
  [DependsOnSubMember("Settlement", "FoundingPosition")]
  public Vector3 ConstantPositionToTrack { get; }

  [SyncToView(null, true)]
  public int MaxDistanceFromSpecifiedPosition { get; }

  [SyncToView(null, true)]
  [DependsOnSubMember("Settlement", "Founded")]
  public bool MovementLimiterEnabled { get; }

  [SyncToView(null, true)]
  public bool IgnoreHeightMovement { get; }

  protected override void OnCreatePreInitialize();

  protected override void OnCreatePostInitialize();

  protected override void Initialize();

  protected override void PostInitialize();

  protected override void OnDestroy();
}
