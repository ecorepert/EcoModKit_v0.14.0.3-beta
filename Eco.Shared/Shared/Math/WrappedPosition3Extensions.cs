// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Math.WrappedPosition3Extensions
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Numerics;
using System.Runtime.CompilerServices;

#nullable disable
namespace Eco.Shared.Math;

/// <summary> Extension methods for <see cref="T:Eco.Shared.Math.WrappedPosition3" />. </summary>
public static class WrappedPosition3Extensions
{
  /// <summary> Calculates wrapped difference between <paramref name="a" /> and <paramref name="b" />. </summary>
  public static Vector3 WrappedDifference(this WrappedPosition3 a, WrappedPosition3 b);

  /// <summary> Returns <see cref="T:Eco.Shared.Math.Vector2" /> for <see cref="P:Eco.Shared.Math.WrappedPosition3.X" /> and <see cref="P:Eco.Shared.Math.WrappedPosition3.Z" /> coordinates. </summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static Vector2 XZ(this WrappedPosition3 worldPos);
}
