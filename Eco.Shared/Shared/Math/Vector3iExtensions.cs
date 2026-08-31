// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Math.Vector3iExtensions
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Runtime.CompilerServices;

#nullable disable
namespace Eco.Shared.Math;

/// <summary>Extension methods for <see cref="T:Eco.Shared.Math.Vector3i" />.</summary>
public static class Vector3iExtensions
{
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static Vector3i WithX(this Vector3i v, int x);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static Vector3i WithY(this Vector3i v, int y);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static Vector3i WithZ(this Vector3i v, int z);
}
