// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.MathUtil
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Items;
using Eco.Shared.Math;
using Eco.Shared.Voxel;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;

#nullable disable
namespace Eco.Shared.Utils;

public static class MathUtil
{
  public static bool CloseEnough(this float l, float other, float fudgeFactor = 1.401298E-45f);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static void Swap<T>(ref T x, ref T y);

  /// <summary>Unlike a regular division, this will round *down*, instead of towards zero (IE, negative numbers round up when there is a remainder)</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static int DivideAndFloor(this int val, int divisor);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static Vector2i DivideAndFloor(this Vector2i val, int divisor);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static Vector3i DivideAndFloor(this Vector3i val, int divisor);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static bool IsReal(this Eco.Shared.Math.Vector2 value);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static bool IsReal(this Vector3 value);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static bool IsReal(this double value);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static bool IsReal(this float value);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static bool NotReal(this double value);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static bool NotReal(this float value);

  public static double StdDev(this IEnumerable<double> values);

  public static T Clip<T>(T val, T min, T max) where T : IComparable;

  public static double MapValue(
    double val,
    double sourceMin,
    double sourceMax,
    double targetMin,
    double targetMax,
    bool clamp);

  public static float MapValue(
    float val,
    float sourceMin,
    float sourceMax,
    float targetMin,
    float targetMax,
    bool clamp);

  public static float MapValuePow(
    float val,
    float sourceMin,
    float sourceMax,
    float targetMin,
    float targetMax,
    bool clamp,
    float pow = 2f);

  public static float MapValueSin(
    float val,
    float sourceMin,
    float sourceMax,
    float targetMin,
    float targetMax,
    bool clamp);

  public static float Square(float a);

  public static float Lerp(float a, float b, float t, bool clamp = false);

  public static double Lerp(double a, double b, float t, bool clamp = false);

  public static double Lerp(double a, double b, double t);

  public static float GetPercentThrough(float val, float min, float max, bool clamp);

  public static double GetPercentThrough(double val, double min, double max, bool clamp);

  public static float GetPercentThrough(long val, long min, long max, bool clamp);

  public static float Interpolate(float percent, float min, float max, bool clamp = true);

  /// <summary>Sum source with delta to approach target, without passing it, and respecting absolute value.</summary>
  public static float LerpToTarget(this float source, float target, float delta);

  /// <summary> Find a normalized (-1 : 1) angle between two directions. Cuts angle higher than max angle </summary>
  public static float NormalizeAngleDeg(
    Vector3 originalDirection,
    Vector3 targetDirection,
    float maxAngle = 45f);

  /// <summary>
  /// Determine whether the point is in the center of a block
  /// </summary>
  /// <param name="size">Size of a block</param>
  /// <param name="normal">Normal vector of a hit point</param>
  /// <param name="scaledHit">Position of a hit point scaled to a size</param>
  /// <param name="centerSize">Size of center on a block (default is 65% of a half)</param>
  /// <param name="thinSize">Size of thin block</param>
  public static bool IsInCenter(
    Vector3 size,
    Vector3 normal,
    Vector3 scaledHit,
    Vector3 centerSize = default (Vector3),
    float thinSize = 0.4f);

  /// <summary> Returns a max possible angle between two vectors </summary>
  public static float ClampDirectionAngleDeg(
    Eco.Shared.Math.Vector2 originDirection,
    Eco.Shared.Math.Vector2 targetDir,
    float angleInRad = 0.78f);

  /// <summary> Function is finding new target and opposite directions in a curved way (lerping each step) </summary>
  public static void ClampDirectionToOffsetDeg(
    out Eco.Shared.Math.Vector2 targetDir,
    out Eco.Shared.Math.Vector2 oppositeDir,
    Eco.Shared.Math.Vector2 originDirection,
    Eco.Shared.Math.Vector2 originalTargetDir,
    Eco.Shared.Math.Vector2 originalOppositeDir,
    int dirSign,
    float minAngleDeg,
    float maxAngleDeg,
    int tries,
    int tryCount);

  public static float ChangeAngleRange180(this float angle);

  public static Vector3 ChangeAngleRange180(this Vector3 angles);

  public static float NormalizeAngle0to360(float angle);

  public static bool InFront(Vector3 a, Vector3 facing, Vector3 b);

  public static bool IsPointInBox(Eco.Shared.Math.Vector2 point, Eco.Shared.Math.Vector2 boxCenter, float side);

  public static bool IsCircleInBox(
    Eco.Shared.Math.Vector2 circleCenter,
    float circleRadius,
    Eco.Shared.Math.Vector2 boxCenter,
    float side);

  /// <summary>Ceiling that (3,15) return 15. (-3, 15) will return 0.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static int CeilToNearestMultiple(this int val, int multiple);

  /// <summary>Floor that (3, 15) return 0. (-3, 15) return -15</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static int FloorToNearestMultiple(this int val, int multiple);

  /// <summary>Applies <see cref="M:Eco.Shared.Utils.MathUtil.CeilToNearestMultiple(System.Int32,System.Int32)" /> to each <see cref="T:Eco.Shared.Math.Vector2i" /> component.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static Vector2i CeilToNearestMultiple(this Vector2i val, int multiple);

  /// <summary>Applies <see cref="M:Eco.Shared.Utils.MathUtil.FloorToNearestMultiple(System.Int32,System.Int32)" /> to each <see cref="T:Eco.Shared.Math.Vector2i" /> component.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static Vector2i FloorToNearestMultiple(this Vector2i val, int multiple);

  public static int Truncate(float val);

  public static double Fract(double v);

  public static float TruncatePastTenths(this float val);

  public static float TruncatePastHundreths(this float val);

  public static float TruncatePastThousandths(this float val);

  public static float TruncatePastTenThousandths(this float val);

  public static T Clamp<T>(this T current, T min, T max) where T : IComparable<T>;

  public static int Compare(bool a, bool b, Func<int> subCompare = null);

  public static int Compare(int a, int b, Func<int> subCompare = null);

  public static float DiminishingReturn(float dimReturn, float val);

  public static float DiminishingReturnExtra(float dimReturn, float val, float range);

  public static int Compare(float a, float b, Func<int> subCompare = null);

  public static float ApproachValue(float val, float target, float halflife);

  public static float CapAfterPercent(
    float val,
    float cap,
    float startCappingAtPercent = 0.5f,
    float halflifeAtPercent = 0.5f);

  public static float Approach(float current, float target, float amount);

  /// <summary>
  /// Calculates average value between <paramref name="x" /> nad <paramref name="y" /> using value weights.
  /// Formula is following: <c>(x * xWeight + y * yWeight) / (xWeight + yWeight)</c>.
  /// </summary>
  public static float WeightedAverage(float x, float xWeight, float y, float yWeight);

  public static bool IsFurtherFromOrigin(float val, float range);

  public static int CustomHash(params int[] vals);

  public static int Max(params int[] values);

  public static int Min(params int[] values);

  public static List<List<Vector2i>> SplitPositionsByContiniusIslands(
    IEnumerable<Vector2i> existedPos,
    Vector2i? wrapVector = null);

  /// <summary>Remove the given number of plots from position that wont break contiguity, counted from the starting pos, and return them.</summary>
  public static IEnumerable<PlotPos> RemovePlotsAndKeepContiguous(
    HashSet<PlotPos> positions,
    int numberOfPosToRemove,
    PlotPos startingPos);

  public static float GetAnalysisValue(this AnalysisValue analysis, IEnumerable<float> values);

  /// <summary>Combine calculate average total from 2 source value of Vector3i</summary>
  public static Vector3i TotalAverageVector3i(
    Vector3i firstV,
    int countFirst,
    Vector3i secondV,
    int countSecond);

  public static float NextSignificantValue(float val);

  public static int RoundDownToMultiple(this int val, int nearest);

  public static int RoundDownToMultiple(this float val, int nearest);

  public static float RoundToNearestMultiple(this float value, float multiple);
}
