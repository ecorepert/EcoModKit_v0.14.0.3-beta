// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Garbage.GarbageMaterial
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.World.Blocks;
using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Garbage;

/// <summary>Type-safe, polymorphic replacement for the previous string-based garbage material keys. Each subclass represents one
/// material that can flow through the recycling chain (shredder → sorters). A material carries its own output item, optional
/// catalyst requirement, optional parent category (for Lv1 aggregation), and what it degrades into when lost to inefficiency.
/// Discovered via <see cref="T:Eco.Shared.Utils.ReflectionUtils" /> at startup; mods add new materials by simply subclassing.</summary>
public abstract class GarbageMaterial
{
  /// <summary>Stable name — the class's simple type name, used for display and diagnostics.</summary>
  public 
  #nullable disable
  string Name { get; }

  /// <summary>Pure or aggregated item produced when a sorter targets this material. null = routes to the sorter's remainder.</summary>
  public virtual Type OutputItemType { get; }

  /// <summary>Catalyst required by a sorter when processing this material. null = no catalyst, accepted freely.</summary>
  public virtual CatalystSpec? Catalyst { get; }

  /// <summary>Parent category that Lv1 sorters aggregate this material into (e.g. IronScrap.Category = typeof(MetalScrap)). null = no further aggregation.</summary>
  public virtual Type Category { get; }

  /// <summary>What this material becomes when lost to shredder/sorter inefficiency. <c>null</c> means "no specific degraded form" — call sites
  /// fall back to a generic remainder (typically <c>Trash</c> resolved by name). Each concrete material declares this explicitly in <c>Eco.Mods</c>.</summary>
  public virtual Type DegradedForm { get; }

  /// <summary>Which buffer pollution layer this material feeds while it is still part of an unsorted mix. <see cref="F:Eco.World.Blocks.GroundPollutionType.None" /> = biodegradable/inert, no pollution.
  /// Only ever read through a mix's composition: sorting a material out is what removes its pollution, so a sorted output pollutes only if its own block declares
  /// <see cref="T:Eco.World.Blocks.PolluteGround" /> (the residuals do, nothing else does).</summary>
  public virtual GroundPollutionType PollutionType { get; }

  /// <summary>Pollution contributed per unit of this material within a mix, weighted by its fraction. Same scale as the block-level <see cref="P:Eco.World.Blocks.PolluteGround.Amount" />.</summary>
  public virtual float PollutionPerUnit { get; }

  /// <summary>True for the single aggregator that collects all residual/degraded mass. Sorters route every degraded/terminal key into this one
  /// target and the UI renders it as the lone "Residuals" zone instead of a per-line entry.</summary>
  public virtual bool IsResidualSink { get; }

  /// <summary>True for the residual sink and everything that aggregates into it (pollutants, compost, trash). Residuals are inefficiency
  /// byproducts, not a sortable input, so the garbage block builder ignores them when deciding which block type a mix produces.
  /// Resolved structurally (the sink, or a material whose category is the sink) so no concrete residual type needs to be referenced here.</summary>
  public bool IsResidual { get; }

  /// <summary>True when a sorter should render this target in the compact "Residuals" zone rather than as a full sorting line. The residual sink always does;
  /// a terminal leftover can opt in (e.g. Garbage on the Residuals Sorter, shown as a byproduct rather than something you sort for). Purely visual — it does
  /// not change how the target's mass is routed or which block it emits.</summary>
  public virtual bool ShowAsResidualRow { get; }

  /// <summary>All discovered concrete materials.</summary>
  public static IEnumerable<GarbageMaterial> All { get; }

  /// <summary>Returns the singleton instance for <paramref name="type" />, or null if not a known material.</summary>
  public static GarbageMaterial Get(Type type);

  /// <summary>The material whose sorted output is <paramref name="itemType" /> — the reverse of <see cref="P:Eco.Gameplay.Garbage.GarbageMaterial.OutputItemType" />. Answers "what is this
  /// garbage item made of" for tooltips and the ecopedia. Null when the item isn't any material's output (the generic mixed garbage block).</summary>
  public static GarbageMaterial GetByOutputItem(Type itemType);

  /// <summary>The materials that aggregate into <paramref name="material" /> (null = the top-level families, which aggregate into nothing).</summary>
  public static IEnumerable<GarbageMaterial> MembersOf(GarbageMaterial material);

  /// <summary>Generic helper for the common call site <c>GarbageMaterial.Get&lt;IronScrap&gt;()</c>.</summary>
  public static T Get<T>() where T : GarbageMaterial;

  /// <summary>Resolves a material Type by its simple class name. Useful for cross-assembly code in <c>Eco.Gameplay</c> that can't reference concrete materials
  /// from <c>Eco.Mods</c> directly. Returns null if no material with this name exists.</summary>
  public static Type GetTypeByName(string name);

  /// <summary>Discovers all concrete <see cref="T:Eco.Gameplay.Garbage.GarbageMaterial" /> subclasses across loaded assemblies and instantiates one singleton per type.
  /// Must run after <see cref="T:Eco.Gameplay.Items.Item" /> initialization so materials that look up items by name via <see cref="M:Eco.Gameplay.Items.Item.GetType(System.String)" /> resolve correctly.</summary>
  public static void Initialize();
}
