// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Blocks.FormType
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Gameplay.Items;
using System;

#nullable disable
namespace Eco.Gameplay.Blocks;

[IconGroup("Block Forms")]
public abstract class FormType : IconItem
{
  /// <summary> Icon name used by the client to look up the icon in Eco.scene. </summary>
  public override string IconName { get; set; }

  /// <summary> The FormGroup-derived type that defines the group this form belongs to. </summary>
  public virtual Type GroupType { get; }

  /// <summary> Minimum tier of hammer needed to use this form. </summary>
  public virtual int MinTier { get; }

  /// <summary> Form group used for grouping in the UI. </summary>
  [SyncToView(null, true)]
  public virtual FormGroup Group { get; }

  /// <summary>This form fills only the lower part of its voxel, leaving the space above open (e.g. thin floor bottoms), so placement may seat objects in the same cell.</summary>
  [SyncToView(null, true)]
  public virtual bool IsBottomHalfFill { get; }

  /// <summary>This form fills only the upper part of its voxel, leaving the space below open (e.g. roof fills), so placement may hang objects in the same cell.</summary>
  [SyncToView(null, true)]
  public virtual bool IsTopHalfFill { get; }

  /// <summary>This form fills only one side face of its voxel, leaving the rest open (e.g. edge walls), so placement may attach objects within the same cell.</summary>
  [SyncToView(null, true)]
  public virtual bool IsSideFill { get; }

  /// <summary>True when the form fills only part of its voxel, leaving room for placed objects to share the cell.</summary>
  public bool IsPartialFill { get; }
}
