// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.CompressedArrayUtils
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Math;
using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

#nullable disable
namespace Eco.Shared.Utils;

public static class CompressedArrayUtils
{
  public static bool UseParallel;
  public static ParallelOptions ParallelOptions;

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static byte[] ToBytes<T>(this Array2D<T> array);

  public static void WriteBytesTo<T>(this Array2D<T> array, MemoryStream ms);

  public static Array2D<T> TransformInPlace<T>(this Array2D<T> array, Func<Vector2i, T, T> calc);

  public static Array2D<T> Transform<T>(this Array2D<T> array, Func<Vector2i, T, T> calc) where T : struct;

  public static Array2D<T> Set2D<T>(this Array2D<T> array, Func<Vector2i, T> calc);

  public static Array2D<T> Make2DArray<T>(Vector2i size, Func<Vector2i, T> func);
}
