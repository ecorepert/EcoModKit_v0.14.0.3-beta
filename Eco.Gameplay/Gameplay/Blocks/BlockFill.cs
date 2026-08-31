// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Blocks.BlockFill
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Gameplay.Items;
using Eco.Shared.SharedTypes;

#nullable disable
namespace Eco.Gameplay.Blocks;

[IconGroup("Block Fills")]
[ForceCreateViewAllDerived]
public abstract class BlockFill : IconItem
{
  public override string IconName { get; set; }

  [SyncToView(null, true)]
  public virtual int HammerTier { get; }

  [SyncToView(null, true)]
  public virtual SelectionMode SelectionMode { get; }
}
