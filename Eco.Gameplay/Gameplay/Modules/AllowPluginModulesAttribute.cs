// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Modules.AllowPluginModulesAttribute
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Items;
using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Modules;

public class AllowPluginModulesAttribute : ItemAttribute
{
  public string[]? Tags { get; set; }

  public Type[]? ItemTypes { get; set; }

  /// <summary>Slot-tag names this table exposes (see <see cref="T:Eco.Gameplay.Modules.ModuleSlotRegistry" />). Null exposes the four core slots; an empty array exposes none.</summary>
  public string[]? Slots { get; set; }

  /// <summary> Returns <see cref="P:Eco.Gameplay.Modules.AllowPluginModulesAttribute.Tags" /> and <see cref="P:Eco.Gameplay.Modules.AllowPluginModulesAttribute.ItemTypes" /> combined into single enumerable. </summary>
  /// <returns> <c>null</c> if both <see cref="P:Eco.Gameplay.Modules.AllowPluginModulesAttribute.Tags" /> and <see cref="P:Eco.Gameplay.Modules.AllowPluginModulesAttribute.ItemTypes" /> is null, concatenation of items and tags otherwise. </returns>
  public IEnumerable<ItemRepresentation>? GetStackables();

  /// <summary>Concrete item types the allow-list represents: <see cref="P:Eco.Gameplay.Modules.AllowPluginModulesAttribute.ItemTypes" /> plus every member type of each listed tag. Null when no list is declared.</summary>
  public IEnumerable<Type>? AllowedItemTypes();
}
