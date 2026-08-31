// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Garbage.CatalystSpec
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using System;
using System.Runtime.CompilerServices;

#nullable disable
namespace Eco.Gameplay.Garbage;

/// <summary>Catalyst configuration attached to a <see cref="T:Eco.Gameplay.Garbage.GarbageMaterial" />: the item consumed, how many input units one catalyst item processes, and how many inventory slots the catalyst gets.</summary>
public readonly struct CatalystSpec : IEquatable<CatalystSpec>
{
  /// <summary>Catalyst configuration attached to a <see cref="T:Eco.Gameplay.Garbage.GarbageMaterial" />: the item consumed, how many input units one catalyst item processes, and how many inventory slots the catalyst gets.</summary>
  public CatalystSpec(Type ItemType, float UnitsPerCatalyst, int SlotCount);

  public Type ItemType { get; init; }

  public float UnitsPerCatalyst { get; init; }

  public int SlotCount { get; init; }

  [CompilerGenerated]
  public override string ToString();

  [CompilerGenerated]
  public static bool operator !=(CatalystSpec left, CatalystSpec right);

  [CompilerGenerated]
  public static bool operator ==(CatalystSpec left, CatalystSpec right);

  [CompilerGenerated]
  public override int GetHashCode();

  [CompilerGenerated]
  public override bool Equals(object obj);

  [CompilerGenerated]
  public bool Equals(CatalystSpec other);

  [CompilerGenerated]
  public void Deconstruct(out Type ItemType, out float UnitsPerCatalyst, out int SlotCount);
}
