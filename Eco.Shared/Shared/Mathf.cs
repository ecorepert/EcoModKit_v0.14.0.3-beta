// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Mathf
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Runtime.CompilerServices;

#nullable disable
namespace Eco.Shared;

public static class Mathf
{
  public const int AcceptedFractionalDigitsCount = 2;
  public const int AcceptedFractionalDigitsModifier = 100;
  public const float Rad2Deg = 57.2957764f;

  public static float PI { get; }

  public static int Min(int x, int y);

  public static int Max(int x, int y);

  public static float Min(float x, float y);

  public static float Max(float x, float y);

  public static int Min(params int[] list);

  public static int Max(params int[] list);

  public static float Min(params float[] list);

  public static float Max(params float[] list);

  public static float DegToRad(float d);

  public static float RadToDeg(float r);

  /// <summary> Rounds value so it will be multiple of some value. Sample: 11, 5 =&gt; 10 </summary>
  public static int RoundToMultiple(float value, int multiple);

  /// <summary>
  /// Rounds half up. I.e. -0.5 -&gt; 0; 0.5 -&gt; 1; 1.5 -&gt; 2.
  /// We should prefer this way of rounding for coordinates,
  /// because for voxel we always subtracting 0.5 (i.e. voxel with position [0,0,0] will have [-0.5,-0.5,-0.5] coordinates).
  /// </summary>
  /// <param name="value">value to round.</param>
  /// <returns>rounded value, tie rounded to closest greater int number.</returns>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static float RoundPositively(float value);

  /// <summary>
  /// Rounds half up. I.e. -0.5 -&gt; 0; 0.5 -&gt; 1; 1.5 -&gt; 2.
  /// We should prefer this way of rounding for coordinates,
  /// because for voxel we always subtracting 0.5 (i.e. voxel with position [0,0,0] will have [-0.5,-0.5,-0.5] coordinates).
  /// </summary>
  /// <param name="value">value to round.</param>
  /// <returns>rounded value, tie rounded to closest greater int number.</returns>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static int RoundPositivelyInt(float value);

  public static bool IsRound(float value);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static float Clamp01(this float val);

  public static float ClampNeg1to1(this float val);

  public static double Clamp01(this double val);

  public static int Clamp(this int val, int min, int max);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static float Clamp(this float val, float min, float max);

  public static double Clamp(this double val, double min, double max);

  /// <summary> Clamps to max value. Same as Clamp(current, float.MinValue, max). </summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static float ClampTop(this float current, float max);

  /// <summary> Calculates percentage [0; 1] of <paramref name="total" /> for specified <paramref name="value" />. </summary>
  /// <sample> percentage of <c>5</c> for <c>100</c> is <c>0.05</c>. </sample>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static float PercentageOf(this float value, float total);

  /// <summary> Calculates complement of the percentage [0; 1] of the <paramref name="value" /> for the <paramref name="total" /> (1 - percentage). </summary>
  /// <sample> percentage of <c>5</c> for <c>100</c> is <c>0.05</c>; complement of the percentage of <c>5</c> for <c>100</c> is <c>0.95</c>. </sample>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static float PercentageComplementOf(this float value, float total);

  public static float Sq(float r);

  public static float Abs(float x);

  public static bool Equals(float a, float b);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static float Lerp(float from, float to, float percent);

  public static float LerpRange(this float percent, float from, float to);

  /// <summary> Calculates the exact visible amount for the economy by removing extra fractional digits. </summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static float RoundToAcceptedDigits(float a);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static int FloorToInt(float a);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static int CeilingToInt(float num);

  /// <summary>
  /// Performs <see cref="M:System.Math.Ceiling(System.Double)" /> for <paramref name="num" /> with specified <paramref name="epsilon" /> and converts value to int.
  /// If previous integer value is within <paramref name="epsilon" /> of <paramref name="num" /> then it will use previous value instead.
  /// <paramref name="num" /> should be &gt;= 0 and <paramref name="epsilon" /> should be &gt; 0 and &lt;=0.5. Otherwise you will get undetermined result.
  /// </summary>
  /// <sample>
  /// <code>CeilingToInt(0.01f, 0.001f) // 1</code>
  /// <code>CeilingToInt(0.001f, 0.001f) // 0</code>
  /// </sample>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static int CeilingToInt(float num, float epsilon);

  /// <summary>
  /// Performs <see cref="M:System.Math.Floor(System.Double)" /> for <paramref name="num" /> with specified <paramref name="epsilon" /> and converts value to int.
  /// If next integer value is within <paramref name="epsilon" /> of <paramref name="num" /> then it will use next value instead.
  /// <paramref name="num" /> should be &gt;= 0 and <paramref name="epsilon" /> should be &gt; 0 and &lt;= 0.5. Otherwise you will get undetermined result.
  /// </summary>
  /// <sample>
  /// <code>FloorToInt(0.99f, 0.001f) // 0</code>
  /// <code>FloorToInt(0.999f, 0.001f) // 1</code>
  /// </sample>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static int FloorToInt(float num, float epsilon);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static bool IsZero(this float f);

  public static float AddCapped(ref this float val, float toAdd, float max);

  public static float AddCapped(this float val, float toAdd, float max);

  public static float SubtractCappedRef(ref this float val, float toSub, float min);

  public static float SubtractCapped(this float val, float toSub, float min);

  public static float CapTop(this float val, float max);

  public static float CapBottom(this float val, float min);

  public static int CapTop(this int val, int max);

  public static int CapBottom(this int val, int min);
}
