// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.Storage.SelectionStorageComponent
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

/// <summary> Generic selection storage </summary>
[Serialized]
[CreateComponentTabLoc("Storage", false)]
[HasIcon("StorageComponent")]
[RequireComponent(typeof (GroundPolluterReportComponent), null)]
public class SelectionStorageComponent : InteractableStorage
{
  [Serialized]
  public Inventory Storage { get; }

  public override Inventory Inventory { get; }

  /// <summary>Need to be called when create object(in its Initialize) with this component</summary>
  public void CreateInventory(
    int numSlots,
    int maxWeight,
    params InventoryRestriction[] restrictions);
}
