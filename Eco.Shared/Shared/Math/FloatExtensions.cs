// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Math.FloatExtensions
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Runtime.CompilerServices;

#nullable disable
namespace Eco.Shared.Math;

public static class FloatExtensions
{
  /// <summary> Returns <paramref name="value" /> sing with specified <paramref name="tolerance" />. If absolute <paramref name="value" /> less than <paramref name="tolerance" /> then sign will be assumed to <c>0</c>. </summary>
  public static int Sign(this float value, float tolerance = 0.05f);

  /// <summary>Converts a 0-1 fraction into the whole-number percent the UI displays, so comparisons match the value players are shown.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static float ToDisplayedPercent(this float fraction);

  /// <summary>
  /// Wraps value to a range starting with 0 and ending with wrapTo.
  /// It ensures value in this range and if value is negative it will start from end of range.
  /// 
  /// For wrapped range we means a some range starting with 0 and ended with concrete end value. I.e. [0, 100)
  /// When value wrapped it should be enclosed in this range:
  ///  - reduce it to length of this range with "modulo" operation.
  ///  - if it negative then it should be aligned at the end of range
  ///  Some examples for range [0, 100):
  ///    250     -&gt;   250 % 100 = 50   | -                -&gt; 50
  ///    -175    -&gt;   -175 % 100 = -75 | 100 - 75 = 25    -&gt; 25.
  /// </summary>
  /// <param name="value">Value to wrap.</param>
  /// <param name="wrapTo">Ending value of range.</param>
  /// <returns>Value wrapped to range.</returns>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static float Wrap(this float value, float wrapTo);

  /// <summary>
  /// Replaces <paramref name="value" /> with <paramref name="candidate" /> if it is less than <paramref name="value" />.
  /// Shorthand for
  /// <code>
  /// var candidate = someFunc();
  /// if (candidate &lt; value)
  /// {
  ///    value = candidate;
  ///    doSomethingElse();
  /// }
  /// </code>
  /// may be shortened to
  /// <code>
  /// if (value.SetWhenLess(someFunc())) doSomethingElse();
  /// </code>
  /// </summary>
  /// <returns><c>true</c> if value was set.</returns>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static bool SetWhenLess(ref this float value, float candidate);
}
