// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.PermanentModuleRestriction
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.Items;

/// <summary>Blocks pickup from a plugin-module slot inventory. Modules are permanent once installed and same-slot conflicts are rejected outright (no upgrade chain). The only removal paths are the <c>/admin clearmodules</c> command and destroying the workbench.</summary>
public class PermanentModuleRestriction : InventoryRestriction
{
  public override LocString Message { get; }

  public override int Priority { get; }

  public override RestrictionDescriptor Describe();

  public override int MaxPickup(RestrictionCheckData checkData, Item item, int totalMoved);
}
