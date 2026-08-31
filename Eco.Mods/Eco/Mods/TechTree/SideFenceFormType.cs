// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.SideFenceFormType
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Gameplay.Blocks;
using Eco.Shared.Localization;
using Eco.World.Blocks.Features;
using Eco.World.Color;
using Eco.World.Water;
using System;

#nullable disable
namespace Eco.Mods.TechTree;

/// <summary>
/// <para>Server side definition for the "SideFence" form type. </para>
/// <para>More information about FormType objects can be found at https://docs.play.eco/api/server/eco.gameplay/Eco.Gameplay.Blocks.FormType.html</para>
/// </summary>
/// <remarks>
/// This is an auto-generated class. Don't modify it! All your changes will be wiped with next update! Use Mods* partial methods instead for customization.
/// If you wish to modify this class, please create a new partial class or follow the instructions in the "UserCode" folder to override the entire file.
/// </remarks>
public class SideFenceFormType : 
  FormType,
  IWaterLoggedBlock,
  IExtraBlockData,
  IColoredBlock,
  IColorBlockData
{
  /// <summary>Basic name of the block form type.</summary>
  public override string Name { get; }

  /// <summary>The plural localization name for the block form type.</summary>
  public override LocString DisplayName { get; }

  /// <summary>The tooltip description for the block form type.</summary>
  public override LocString DisplayDescription { get; }

  /// <summary>The block FormGroup this form type belongs to</summary>
  public override Type GroupType { get; }

  /// <summary>Defines the sort order used by this block form type</summary>
  public override int SortOrder { get; }

  /// <summary>Defines the minimum hammer tier for this block form type</summary>
  public override int MinTier { get; }
}
