// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Garbage.WasteRetentionAttribute
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using System;

#nullable disable
namespace Eco.Gameplay.Garbage;

/// <summary>Multiplier applied to ground-polluting items stored inside this WorldObject when computing per-claim buffer pollution targets.
/// Lower values = better containment. Untagged WorldObjects use the default 1.0, the same as a raw block dumped in the world.
/// Reference scale: basic garbage storage 0.1 (-90%), advanced 0.05 (-95%), sealed 0.01 (-99%).</summary>
[AttributeUsage(AttributeTargets.Class, Inherited = true)]
public sealed class WasteRetentionAttribute : Attribute
{
  public float Ratio { get; }

  public WasteRetentionAttribute(float ratio);
}
