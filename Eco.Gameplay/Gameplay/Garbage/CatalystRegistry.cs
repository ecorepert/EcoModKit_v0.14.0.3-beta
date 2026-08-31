// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Garbage.CatalystRegistry
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Garbage;

/// <summary>Reverse index of <see cref="T:Eco.Gameplay.Garbage.ICatalystUser" />: which world objects consume a given catalyst item. Tags every catalyst item with
/// <see cref="F:Eco.Gameplay.Garbage.CatalystRegistry.CatalystTag" />, so tooltips and item filters can recognize a catalyst without knowing about the machines that use it.</summary>
public static class CatalystRegistry
{
  public const string CatalystTag = "Catalyst";

  /// <summary>World object types consuming <paramref name="catalystItemType" />, ordered by type name. Empty when the item is not a catalyst.</summary>
  public static IEnumerable<Type> UsersOf(Type catalystItemType);

  /// <summary>Builds the index from every <see cref="T:Eco.Gameplay.Garbage.ICatalystUser" />. Must run after <see cref="T:Eco.Gameplay.Items.Item" />, <see cref="T:Eco.Gameplay.Items.TagManager" /> and
  /// <see cref="T:Eco.Gameplay.Garbage.GarbageMaterial" /> initialization, since sorters resolve their catalysts off the material registry.</summary>
  public static void Initialize();
}
