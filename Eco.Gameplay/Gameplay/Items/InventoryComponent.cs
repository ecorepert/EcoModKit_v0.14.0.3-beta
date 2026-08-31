// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.InventoryComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Shared.View;

#nullable disable
namespace Eco.Gameplay.Items;

/// <summary>
/// Inventory components track an attribute of an inventory, such as weight
/// restrictions may use components to handle valid item destinations
/// </summary>
public abstract class InventoryComponent : IController, IViewController, IHasUniversalID
{
  public ref int ControllerID { get; }

  public abstract void Initialize(Inventory inventory);

  public abstract void ApplyChange(Item item, int quantityDelta);

  public abstract void EndChangeSetModification(bool successful);
}
