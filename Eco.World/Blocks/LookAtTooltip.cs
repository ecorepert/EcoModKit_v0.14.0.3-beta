// Decompiled with JetBrains decompiler
// Type: Eco.World.Blocks.LookAtTooltip
// Assembly: Eco.World, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B2A8792E-938E-4BB5-B27F-EF3390C48946
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.xml

using System;

#nullable enable
namespace Eco.World.Blocks;

/// <summary>Look at tooltip for a block (in case if you need to override or don't have creating item).</summary>
public sealed class LookAtTooltip : BlockAttribute
{
  public readonly string Text;
  public string? IconName;
  public Type? IconItemType;

  public LookAtTooltip(string tooltip);
}
