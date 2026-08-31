// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Math.Vector3Utils
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Numerics;
using System.Runtime.CompilerServices;

#nullable disable
namespace Eco.Shared.Math;

/// <summary>Helper methods for System.Numerics.Vector3. Server now remaps System.Numerics.Vector3 to UnityEngine.Vector3 using Fody. More information in the Eco.Fody project Fody.md</summary>
public static class Vector3Utils
{
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static float Magnitude(Vector3 vector);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static float SqrMagnitude(Vector3 vector);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static float Dot(Vector3 a, Vector3 b);

  public static float Angle(Vector3 from, Vector3 to);
}
