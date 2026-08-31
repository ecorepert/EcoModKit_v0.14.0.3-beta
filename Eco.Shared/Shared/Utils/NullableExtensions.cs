// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.NullableExtensions
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Runtime.CompilerServices;

#nullable disable
namespace Eco.Shared.Utils;

/// <summary> Extension methods for <see cref="T:System.Nullable`1" /> </summary>
public static class NullableExtensions
{
  /// <summary>
  /// Checks if <paramref name="nullable" /> has value and returns it as <paramref name="value" /> if it has.
  /// Returns result of this check.
  /// It is thread-safe as it makes a copy of <see cref="T:System.Nullable`1" /> struct.
  /// </summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static bool TryGetValue<T>(this T? nullable, out T value) where T : struct;
}
