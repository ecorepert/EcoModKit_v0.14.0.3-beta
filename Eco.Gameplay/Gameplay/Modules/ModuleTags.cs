// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Modules.ModuleTags
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Items;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Modules;

/// <summary>Tag names and runtime <see cref="T:Eco.Gameplay.Items.Tag" /> accessors for the four plugin-module slot tags. Items declare one of these via <c>[Tag(ModuleTags.Basic)]</c> to be installable in the corresponding slot.</summary>
public static class ModuleTags
{
  public const string Basic = "BasicModule";
  public const string Advanced = "AdvancedModule";
  public const string Modern = "ModernModule";
  public const string Specialty = "SpecialtyModule";

  public static Tag BasicTag { get; }

  public static Tag AdvancedTag { get; }

  public static Tag ModernTag { get; }

  public static Tag SpecialtyTag { get; }

  /// <summary>All registered slot-tag names in canonical slot order. Identity by name avoids dependency on <see cref="T:Eco.Gameplay.Items.TagManager" /> registrar init order.</summary>
  public static IEnumerable<string> AllInSlotOrder();

  /// <summary>Star cost to install a module of the given slot (from the slot's registered definition). Unrecognised tag name returns 0.</summary>
  public static int StarCostFor(string slotTagName);

  /// <summary>Star cost to install the given module: the item's own <see cref="P:Eco.Gameplay.Modules.PluginModule.StarCostOverride" /> when set (0 makes it free),
  /// else the cost of the slot its first slot tag refers to. 0 if the module carries no recognised slot tag.</summary>
  public static int StarCostFor(Item module);
}
