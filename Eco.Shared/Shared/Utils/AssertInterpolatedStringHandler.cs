// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.AssertInterpolatedStringHandler
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

#nullable enable
namespace Eco.Shared.Utils;

/// <summary>Provides an interpolated string handler for <see cref="M:Eco.Shared.Utils.DebugUtils.Assert(System.Boolean,Eco.Shared.Utils.AssertInterpolatedStringHandler@)" /> that only performs formatting if the assert fails. Based on <see cref="T:System.Diagnostics.Debug.AssertInterpolatedStringHandler" />.</summary>
[EditorBrowsable(EditorBrowsableState.Never)]
[InterpolatedStringHandler]
public struct AssertInterpolatedStringHandler
{
  private StringBuilder? stringBuilder;
  /// <summary>The handler we use to perform the formatting.</summary>
  private StringBuilder.AppendInterpolatedStringHandler stringBuilderHandler;

  /// <summary>Creates an instance of the handler..</summary>
  /// <param name="literalLength">The number of constant characters outside of interpolation expressions in the interpolated string.</param>
  /// <param name="formattedCount">The number of interpolation expressions in the interpolated string.</param>
  /// <param name="condition">The condition Boolean passed to the <see cref="T:System.Diagnostics.Debug" /> method.</param>
  /// <param name="shouldAppend">A value indicating whether formatting should proceed.</param>
  /// <remarks>This is intended to be called only by compiler-generated code. Arguments are not validated as they'd otherwise be for members intended to be used directly.</remarks>
  public AssertInterpolatedStringHandler(
    int literalLength,
    int formattedCount,
    bool condition,
    out bool shouldAppend);

  /// <summary>Writes the specified string to the handler.</summary>
  /// <param name="value">The string to write.</param>
  public void AppendLiteral(string value);

  /// <summary>Writes the specified value to the handler.</summary>
  /// <param name="value">The value to write.</param>
  public void AppendFormatted<T>(T value);

  /// <summary>Writes the specified value to the handler.</summary>
  /// <param name="value">The value to write.</param>
  /// <param name="format">The format string.</param>
  public void AppendFormatted<T>(T value, string? format);

  /// <summary>Writes the specified value to the handler.</summary>
  /// <param name="value">The value to write.</param>
  /// <param name="alignment">Minimum number of characters that should be written for this value.  If the value is negative, it indicates left-aligned and the required minimum is the absolute value.</param>
  public void AppendFormatted<T>(T value, int alignment);

  /// <summary>Writes the specified value to the handler.</summary>
  /// <param name="value">The value to write.</param>
  /// <param name="format">The format string.</param>
  /// <param name="alignment">Minimum number of characters that should be written for this value.  If the value is negative, it indicates left-aligned and the required minimum is the absolute value.</param>
  public void AppendFormatted<T>(T value, int alignment, string? format);

  /// <summary>Writes the specified character span to the handler.</summary>
  /// <param name="value">The span to write.</param>
  public void AppendFormatted(ReadOnlySpan<char> value);

  /// <summary>Writes the specified string of chars to the handler.</summary>
  /// <param name="value">The span to write.</param>
  /// <param name="alignment">Minimum number of characters that should be written for this value.  If the value is negative, it indicates left-aligned and the required minimum is the absolute value.</param>
  /// <param name="format">The format string.</param>
  public void AppendFormatted(ReadOnlySpan<char> value, int alignment = 0, string? format = null);

  /// <summary>Writes the specified value to the handler.</summary>
  /// <param name="value">The value to write.</param>
  public void AppendFormatted(string? value);

  /// <summary>Writes the specified value to the handler.</summary>
  /// <param name="value">The value to write.</param>
  /// <param name="alignment">Minimum number of characters that should be written for this value.  If the value is negative, it indicates left-aligned and the required minimum is the absolute value.</param>
  /// <param name="format">The format string.</param>
  public void AppendFormatted(string? value, int alignment = 0, string? format = null);

  /// <summary>Writes the specified value to the handler.</summary>
  /// <param name="value">The value to write.</param>
  /// <param name="alignment">Minimum number of characters that should be written for this value.  If the value is negative, it indicates left-aligned and the required minimum is the absolute value.</param>
  /// <param name="format">The format string.</param>
  public void AppendFormatted(object? value, int alignment = 0, string? format = null);
}
