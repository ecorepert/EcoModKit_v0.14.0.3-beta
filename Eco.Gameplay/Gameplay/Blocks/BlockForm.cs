// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Blocks.BlockForm
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Shared.Localization;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Blocks;

[NoIcon]
public class BlockForm : IconItem
{
  public override string IconName { get; set; }

  public virtual Type MaterialType { get; }

  /// <summary> Material ID of material that form is made from. </summary>
  [SyncToView(null, true)]
  public int MaterialId { get; internal set; }

  [SyncToView(null, true)]
  public FormType FormType { get; set; }

  public override string Name { get; }

  public override LocString DisplayName { get; }

  public override LocString DisplayDescription { get; }

  /// <summary> Rotational variants, first being default. They are suppose to go in order: 0 - not rotated, 1 - rotation for 90° and so on. </summary>
  public Type[] BlockTypes { get; internal set; }

  /// <summary> Used in case of consecutive blocks, like ramps. TODO: change to ushort? after adding support of nullables to view system. Now -1 represents null </summary>
  [SyncToView(null, true)]
  public int Next { get; internal set; }

  [SyncToView(null, true)]
  public int Previous { get; internal set; }

  [SyncToView(null, true)]
  public IEnumerable<ushort> BlockTypeIDs { get; }

  [SyncToView(null, true)]
  public int NextYOffset { get; set; }

  [SyncToView(null, true)]
  public int PreviousYOffset { get; set; }
}
