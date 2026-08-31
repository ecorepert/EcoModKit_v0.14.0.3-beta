// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.WeightComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;

#nullable disable
namespace Eco.Gameplay.Items;

/// <summary>Used to track the total weight of an inventory.</summary>
public class WeightComponent : InventoryComponent
{
  /// <summary>Represents the max weight this inventory can support.</summary>
  [SyncToView(null, true)]
  public int MaxWeight { get; }

  /// <summary>Represents the true modified weight of this inventory.</summary>
  [SyncToView(null, true)]
  public int Weight { get; }

  public WeightComponent(int maxWeight);

  public void SetMaxWeight(int maxWeight);

  public override void Initialize(Inventory inventory);

  public override void ApplyChange(Item item, int quantityDelta);

  public override void EndChangeSetModification(bool successful);
}
