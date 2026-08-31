// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Math.WrappedWorldPosition3
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Numerics;
using System.Runtime.CompilerServices;

#nullable disable
namespace Eco.Shared.Math;

/// <summary> Represents wrapped world position which doesn't require any further conversions. It prevents multiple checks everywhere for position to be actually wrapped or multiple conversions for same data, this is limited in y if you need y to not limited to the block bounds use <see cref="T:Eco.Shared.Math.WrappedPosition3" /> instead. </summary>
public readonly struct WrappedWorldPosition3
{
  public readonly float X;
  public readonly float Y;
  public readonly float Z;

  /// <summary> Makes new <see cref="T:Eco.Shared.Math.WrappedWorldPosition3" /> from unwrapped <paramref name="x" />, <paramref name="y" /> and <paramref name="z" />. </summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static WrappedWorldPosition3 Create(float x, float y, float z);

  public static implicit operator WrappedWorldPosition3(Vector3 pos);

  public static implicit operator WrappedWorldPosition3(WrappedPosition3i pos);

  public static explicit operator WrappedWorldPosition3(Vector3i pos);

  public static explicit operator WrappedWorldPosition3(WrappedPosition3 pos);

  public static explicit operator Vector3(WrappedWorldPosition3 pos);

  public bool Equals(WrappedWorldPosition3 other);

  public override bool Equals(object obj);

  public static bool operator ==(WrappedWorldPosition3 left, WrappedWorldPosition3 right);

  public static bool operator !=(WrappedWorldPosition3 left, WrappedWorldPosition3 right);

  public override int GetHashCode();

  public override string ToString();
}
