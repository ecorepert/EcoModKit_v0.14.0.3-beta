// Decompiled with JetBrains decompiler
// Type: Eco.World.Blocks.NextRamp
// Assembly: Eco.World, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B2A8792E-938E-4BB5-B27F-EF3390C48946
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.xml

using System;

#nullable enable
namespace Eco.World.Blocks;

/// <summary>
/// Add this attribute to ramps, so when it's placed in line, it will auto choose next block form. Sample -&gt; Asphalt ramp 1 -&gt; Asphalt ramp 2 -&gt; Asphalt ramp 3 -&gt; Asphalt ramp 4 -&gt; Asphalt ramp 1.
/// Usually you want to add 1 offset at the end of loop: Asphalt ramp 4-&gt;1 YOffset = 1
/// </summary>
public sealed class NextRamp : BlockAttribute
{
  /// <summary>Next block to use</summary>
  public Type Next { get; }

  /// <summary>How far away it should be displaced at y coordinate. Usually 0 for 1-4 ramps, and 1 at the end of cycle: 4 to 1.</summary>
  public int YOffset { get; }

  public NextRamp(Type nextRamp, int yOffset);
}
