// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.SpawnedClaimsComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Utils;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Settlements;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using System.ComponentModel;

#nullable enable
namespace Eco.Gameplay.Components;

/// <summary>Component that spawns claim stakes and claim papers based on the size of a settlement. These can then be distributed to citizens to allow them to claim more land from their claim stakes.</summary>
[Serialized]
[Priority(-100)]
[LocDisplayName("Spawned Claims")]
[CreateComponentTabLoc("Spawned Claims", false)]
[HasIcon(null)]
[LocDescription("As more citizens join a Settlement, more claim papers and stakes will be spawned here.  These can be used to claim more land.")]
public class SpawnedClaimsComponent : 
  WorldObjectComponent,
  INotifyPropertyChanged,
  IInventoryWorldObjectComponent,
  IPermanentDestroyHandler
{
  [Serialized]
  [SyncToView(null, true)]
  public 
  #nullable disable
  Inventory ClaimsInventory { get; set; }

  [SyncToView(null, true)]
  public LocString PropertyCrisisDescription { get; set; }

  [SyncToView(null, true)]
  public LocString Description { get; set; }

  public Settlement Settlement { get; }

  public override void Initialize();

  public override void Tick();

  void IPermanentDestroyHandler.OnPermanentDestroy();

  public override WorldObjectComponentClientAvailability Availability { get; }

  Inventory IInventoryWorldObjectComponent.Inventory { get; }
}
