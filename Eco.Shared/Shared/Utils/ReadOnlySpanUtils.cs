// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.ReadOnlySpanUtils
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;

#nullable disable
namespace Eco.Shared.Utils;

/// <summary>
/// Static extension methods and utilities for the .ENT
/// <see cref="T:System.ReadOnlySpan`1" /> object.
/// </summary>
public static class ReadOnlySpanUtils
{
  /// <summary>
  /// Converts the values of one <see cref="T:System.ReadOnlySpan`1" /> to another typed <see cref="T:System.ReadOnlySpan`1" />
  /// using a conversion method.
  /// </summary>
  /// <typeparam name="TInput">Original input type.</typeparam>
  /// <typeparam name="TOutput">Final output type.</typeparam>
  /// <param name="input">Input span to be converted/</param>
  /// <param name="func">Conversion method</param>
  /// <returns>Converted <see cref="T:System.ReadOnlySpan`1" /></returns>
  public static ReadOnlySpan<TOutput> Convert<TInput, TOutput>(
    ReadOnlySpan<TInput> input,
    Func<TInput, TOutput> func)
    where TInput : new();
}
