// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.Storage.PublicStorageComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Components.Storage;

[Serialized]
[CreateComponentTabLoc("Storage", false)]
[HasIcon("StorageComponent")]
[RequireComponent(typeof (GroundPolluterReportComponent), null)]
public class PublicStorageComponent : InteractableStorage
{
  public override WorldObjectComponentClientAvailability Availability { get; }

  [Serialized]
  public Inventory Storage { get; }

  public override Inventory Inventory { get; }

  public PublicStorageComponent();

  public PublicStorageComponent(int numSlots);

  public PublicStorageComponent(int numSlots, int maxWeight);

  /// <summary> Some specialized objects (like refrigerator) are designed to preserve food for a certain amount (shelf life and time remaining increase by this multiplier) </summary>
  public float ShelfLifeMultiplier { get; set; }

  public override void Initialize();

  public void Initialize(int numSlots, int maxWeight, params InventoryRestriction[] restrictions);

  public void Initialize(int numSlots);
}
