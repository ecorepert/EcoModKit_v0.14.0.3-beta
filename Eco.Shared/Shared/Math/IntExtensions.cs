// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Math.IntExtensions
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

#nullable disable
namespace Eco.Shared.Math;

public static class IntExtensions
{
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
  public static int Wrap(this int value, int wrapTo);

  /// <summary>Wrapped alternative of <c>value++</c>. Increments <paramref name="value" /> (which should already be wrapped in <paramref name="wrapTo" /> space) and returns value before increment.</summary>
  /// <sample><code><![CDATA[
  /// (value = 9).PostfixIncrementWrapped(10); // value = 0, returns 9
  /// (value = 9).PostfixIncrementWrapped(20); // value = 10, returns 9
  /// (value = 10).PostfixIncrementWrapped(10); // invalid, result undefined, but in current implementation value = 11
  /// (value = -1).PostfixIncrementWrapped(10); // invalid, result undefined, but in current implementation value = 0
  /// ]]></code></sample>
  /// <returns></returns>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static int PostfixIncrementWrapped(ref this int value, int wrapTo);

  /// <summary>
  /// Checks if value is in a range which enclosed in wrapped range. <see cref="M:Eco.Shared.Math.IntExtensions.Wrap(System.Int32,System.Int32)" />
  /// 
  /// It means that "wrappedStart" and "wrappedEnd" values defines a range [wrappedStart, wrappedEnd),
  /// but this range itself is wrapped to [0, wrappedTo).
  /// 
  /// So it may create situation when we have initial values: "start" = 80, "end" = 150,
  /// but after wrapping to [0, 100) they become: "wrappedStart" = 80 and "wrappedEnd" = 50.
  /// 
  /// And in this case we have "wrappedStart" &gt; "wrappedEnd", because of wrapping. It may be represented as:
  /// <para>
  /// xxxxxxx*********************xxxxxxx.
  /// </para>
  /// where "x" belongs to wrappedStart to wrappedEnd range.
  /// 
  /// And for this kind of range we have to make special check where "value" contained in [min, max) range when
  /// it either contained in [wrappedStart, wrappedTo) or [0, wrappedEnd).
  /// 
  /// If min &lt;= max, then standard check will be used.
  /// </summary>
  /// <param name="value">value to check if it contains in range.</param>
  /// <param name="wrappedStart">start range value (wrapped).</param>
  /// <param name="wrappedEnd">end range value (open, wrapped).</param>
  /// <param name="wrappedTo">end of wrapping range.</param>
  /// <returns>True if value contained in wrappedStart to wrappedEnd range, False otherwise.</returns>
  /// <seealso cref="M:Eco.Shared.Math.IntExtensions.Wrap(System.Int32,System.Int32)" />
  public static bool InWrappedRange(
    this int value,
    int wrappedStart,
    int wrappedEnd,
    int wrappedTo);

  /// <summary>
  /// Creates enumerator which enumerates all values contained in range defined by "wrappedStart" and "wrappedEnd". <see cref="M:Eco.Shared.Math.IntExtensions.Wrap(System.Int32,System.Int32)" />
  /// These values enclosed in wrapping range [0, wrappedTo), so it may create situation where "wrappedStart"
  /// greater than "wrappedEnd" because of overlapping start or end bound.
  /// 
  /// I.e. for wrapping range [0, 100): [-50, 10) =&gt; [50, 10), [50, 120) =&gt; [50, 20)
  /// 
  /// In this case we have to iterate over two ranges: [wrappedStart, wrappedTo) and [0, wrappedEnd).
  /// If wrappedStart less or equal to wrappedEnd then we go to standard iteration over [wrappedStart, wrappedEnd).
  /// </summary>
  public readonly struct IterationInRange
  {
    private readonly int wrappedStart;
    private readonly int wrappedEnd;
    private readonly int wrappedTo;

    public IterationInRange(int wrappedStart, int wrappedEnd, int wrappedTo);

    public IntExtensions.IterationInRange.Enumerator GetEnumerator();

    /// <summary> This struct is allocation free and allows to iterate through wrapped range. By example to go in range 0-10 from 7 to 3. It will return 7, 8, 9, 0, 1, 2 </summary>
    public struct Enumerator : IEnumerator<int>, IEnumerator, IDisposable
    {
      private int position;
      private int wrappedStart;
      private int wrappedTo;
      private int wrappedEnd;
      private int steps;

      public bool MoveNext();

      public int Current { get; }

      void IEnumerator.Reset();

      object IEnumerator.Current { get; }

      public void Dispose();
    }
  }
}
