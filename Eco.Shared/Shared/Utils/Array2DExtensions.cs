// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.Array2DExtensions
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Math;
using System.Collections.Generic;

#nullable enable
namespace Eco.Shared.Utils;

public static class Array2DExtensions
{
  public static 
  #nullable disable
  IEnumerable<(Vector2i Pos, T Value)> AllVals<T>(this Array2D<T> vals);

  /// <summary>Special function for float array2ds, normalize them so all values add up to 1.</summary>
  /// <param name="array"></param>
  public static void Normalize(this Array2D<float> array);

  /// <summary>Perform a simple blur. Kernel must be odd and &gt;= 3. Returns the blurred array.</summary>
  public static Array2D<T> GeneratedBlurredArray<T>(
    this Array2D<T> array,
    int kernelDim,
    Array2DExtensions.BlendFunc<T> doBlend);

  /// <summary>Multiplies 'input' by 'mult' and stores it in 'output'.</summary>
  public delegate void BlendFunc<T1>(ref T1 input, ref T1 output, float mult);
}
