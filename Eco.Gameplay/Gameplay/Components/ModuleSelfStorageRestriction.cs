// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.ModuleSelfStorageRestriction
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Items;
using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.Components;

/// <summary>Refuses storing a module item inside an inventory that the module itself provides. The item leaving its slot uninstalls the module's
/// components on the next tick, so letting it into its own storage would destroy that storage, and the item, moments later.</summary>
public class ModuleSelfStorageRestriction : InventoryRestriction
{
  public ModuleSelfStorageRestriction(Item moduleItem);

  public override LocString Message { get; }

  public override int Priority { get; }

  public override RestrictionDescriptor Describe();

  public override int MaxAccepted(Item item);
}
