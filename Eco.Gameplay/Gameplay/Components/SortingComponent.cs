// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.SortingComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Utils;
using Eco.Gameplay.Components.Storage;
using Eco.Gameplay.Garbage;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using System;

#nullable disable
namespace Eco.Gameplay.Components;

/// <summary>Sorts <see cref="T:Eco.Gameplay.Blocks.FractionalBlockItem" /> input into categorized output items driven by an array of <see cref="T:Eco.Gameplay.Garbage.GarbageMaterial" /> targets.
/// Each target carries its own <see cref="P:Eco.Gameplay.Garbage.GarbageMaterial.OutputItemType" /> and optional <see cref="P:Eco.Gameplay.Garbage.GarbageMaterial.Catalyst" />. A key <c>K</c> routes to the target
/// whose type equals <c>K</c> or whose type matches <c>GarbageMaterial.Get(K).Category</c>.</summary>
[Serialized]
[RequireComponent(typeof (StatusComponent), null)]
[RequireComponent(typeof (SharedLinkComponent), null)]
[RequireComponent(typeof (InOutLinkedInventoriesComponent), null)]
[RequireComponent(typeof (OnOffComponent), null)]
[RequireComponent(typeof (MustBeOwnedComponent), null)]
[Priority(-100)]
[CreateComponentTabLoc("Sorting", true)]
[HasIcon("SortingComponent")]
public class SortingComponent : 
  WorldObjectComponent,
  IOperatingWorldObjectComponent,
  IPersistentData,
  IPickupConfirmationComponent
{
  public bool Operating { get; }

  public object PersistentData { get; set; }

  public override WorldObjectComponentClientAvailability Availability { get; }

  /// <summary>Configures the component with input type, processing parameters, and target materials. Must be called from PostInitialize.</summary>
  public void Initialize(
    Type inputType,
    float processRate,
    float efficiency,
    GarbageMaterial[] targets);

  public override void Initialize();

  public override void Destroy();

  public override void Tick();

  [RPC(AccessType.FullAccess)]
  public void SetLineEnabled(Player player, int groupIndex, bool enabled);

  public LocString GetComponentPickupConfirmation();
}
