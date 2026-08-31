// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.InterlockedUtils
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Diagnostics;
using System.Runtime.CompilerServices;

#nullable enable
namespace Eco.Shared.Utils;

public static class InterlockedUtils
{
  public static float Add(ref float value, float delta);

  public static float UpdateMax(ref float maxValue, float value);

  public static int UpdateMax(ref int maxValue, int value);

  /// <summary>
  /// Tries to subtract value from location. It only happen if location won't become negative (value &lt;= location).
  /// </summary>
  /// <param name="location">location to modify.</param>
  /// <param name="value">value to subtract.</param>
  /// <returns>true - if location &gt;= value, location -= value; false - otherwise, location won't be modified.</returns>
  public static bool TrySubNonNegative(ref int location, int value);

  /// <summary>
  /// Atomic operation to subtract `value` from `location`, or if value &gt; location then subtract location (make it 0). It returns actual subtracted value.
  /// Basic formula: value &gt; location ? location = 0, return old_location_value : location -= value, return value.
  /// </summary>
  /// <param name="location">location to change.</param>
  /// <param name="value">value to subtract.</param>
  /// <returns>subtracted value: min(location, value).</returns>
  public static int SubMinNonNegative(ref int location, int value);

  /// <summary>
  /// Atomic operation to subtract `value` from `location`, or if value &gt; location then subtract location (make it 0). It returns actual subtracted value.
  /// Basic formula: value &gt; location ? location = 0, return old_location_value : location -= value, return value.
  /// </summary>
  /// <param name="location">location to change.</param>
  /// <param name="value">value to subtract.</param>
  /// <returns>subtracted value: min(location, value).</returns>
  public static float SubMinNonNegative(ref float location, float value);

  /// <summary>Checks if <typeparamref name="T" /> can be used in <see cref="T:System.Threading.Interlocked" /> exchange operations.</summary>
  [Conditional("DEBUG")]
  [Conditional("DEBUG_ASSERTS")]
  public static void AssertTypeCompatible<T>();

  /// <summary>Exchange <typeparamref name="T" /> using appropriate <see cref="T:System.Threading.Interlocked" /> exchange method if possible.</summary>
  /// <exception cref="T:System.NotSupportedException"> if type not supported.</exception>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static T Exchange<T>(ref T location, T value);
}
