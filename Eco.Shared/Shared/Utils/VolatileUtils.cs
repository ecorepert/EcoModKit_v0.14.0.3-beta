// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.VolatileUtils
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Diagnostics;
using System.Runtime.CompilerServices;

#nullable enable
namespace Eco.Shared.Utils;

/// <summary>
/// Utility methods extending standard functionality of <see cref="T:System.Threading.Volatile" /> class (https://learn.microsoft.com/en-us/dotnet/api/system.threading.volatile).
/// Read more about volatile and why it needed at https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/keywords/volatile.
/// </summary>
public static class VolatileUtils
{
  /// <summary>Checks if <typeparamref name="T" /> can be used in <see cref="T:Eco.Shared.Utils.VolatileUtils" /> generic methods.</summary>
  [Conditional("DEBUG")]
  [Conditional("DEBUG_ASSERTS")]
  public static void AssertTypeCompatability<T>();

  /// <summary>Exchange <typeparamref name="T" /> using appropriate <see cref="T:System.Threading.Volatile" /> write method if possible.</summary>
  /// <exception cref="T:System.NotSupportedException"> if type not supported.</exception>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static void Write<T>(ref T location, T value);

  /// <summary>Exchange <typeparamref name="T" /> using appropriate <see cref="T:System.Threading.Volatile" /> read method if possible.</summary>
  /// <exception cref="T:System.NotSupportedException"> if type not supported.</exception>
  [SkipLocalsInit]
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static T? Read<T>(ref T? location);
}
