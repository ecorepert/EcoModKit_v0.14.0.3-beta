// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.NewTooltip.TooltipLibraryFiles.GarbageTooltipLibrary
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Blocks;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using System;

#nullable disable
namespace Eco.Gameplay.Systems.NewTooltip.TooltipLibraryFiles;

/// <summary>Tooltip parts for the garbage chain. They live here rather than in <see cref="T:Eco.Gameplay.Systems.NewTooltip.TooltipLibraryFiles.BlocksTooltipLibrary" /> because they read the
/// <see cref="T:Eco.Gameplay.Garbage.GarbageMaterial" /> registry: a fractional block is a block whose composition is made of garbage materials, so the garbage system
/// knows about blocks and not the other way round.</summary>
[TooltipLibrary]
public static class GarbageTooltipLibrary
{
  public static void Initialize();

  /// <summary>What this particular block is made of.</summary>
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 60, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString FractionalTooltip(this FractionalBlockItem fractional);

  /// <summary>What the block type <em>can</em> be made of. Only shown on the template (recipes, ecopedia, tech tree) — an actual block carries a
  /// composition and shows that instead, so the two never appear together.</summary>
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 61, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString FractionalPossibleContentsTooltip(this FractionalBlockItem fractional);
}
