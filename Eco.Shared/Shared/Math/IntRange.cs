// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Math.IntRange
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Runtime.CompilerServices;

#nullable disable
namespace Eco.Shared.Math;

/// <summary>
/// Range bounded by int numbers. Alternative to <see cref="T:System.Range" /> without at end indexes support.
/// With <see cref="T:System.Range" /> you have to know length of sequence for ^1 like indices and so can't calculate <see cref="P:Eco.Shared.Math.IntRange.Length" /> of range.
/// </summary>
public readonly struct IntRange
{
  public readonly int Start;
  public readonly int End;

  /// <summary> Length of the range. </summary>
  public int Length { get; }

  public IntRange(int start, int end);

  /// <summary> Makes new <see cref="T:Eco.Shared.Math.IntRange" /> right after the <paramref name="range" /> with specified <paramref name="length" />. </summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static IntRange After(IntRange range, int length);

  /// <summary> Makes <see cref="T:Eco.Shared.Math.IntRange" /> from <paramref name="offset" /> and <paramref name="length" /> instead of two indexes. </summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static IntRange FromOffsetAndLength(int offset, int length);

  /// <summary> Implicitly converts to System.Range for array accessors etc. </summary>
  public static implicit operator System.Range(IntRange range);
}
