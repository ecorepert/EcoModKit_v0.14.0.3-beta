// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.CoreEnumerableExtensions
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System.Collections.Generic;

#nullable disable
namespace Eco.Core.Utils;

/// <summary>Extensions for <see cref="T:System.Collections.Generic.IEnumerable`1" /> which aware about Eco.Core collections.</summary>
public static class CoreEnumerableExtensions
{
  public static IReadOnlySet<T> EmptySet<T>();

  /// <summary>
  /// Returns snapshot of <paramref name="enumerable" /> using optimized representation if possible.
  /// It assumes that non thread safe collections (<see cref="T:System.Collections.Generic.List`1" />, <see cref="T:System.Collections.Generic.HashSet`1" /> and <see cref="T:System.Collections.Generic.Queue`1" />) not modified from another threads and so returns as is.
  /// For <see cref="T:Eco.Core.Utils.ThreadSafeList`1" />, <see cref="T:Eco.Core.Utils.ThreadSafeHashSet`1" /> and <see cref="T:Eco.Core.Utils.ThreadSafeQueue`1" /> it uses <c>Snapshot</c> property.
  /// With snapshot it guaranteed that you won't have multiple enumeration what ensures stable result and performance for complex LINQ chains.
  /// It also ensures you won't have collection modified from another threads to avoid inconsistent results.
  /// </summary>
  public static IEnumerable<T> AsSnapshot<T>(this IEnumerable<T> enumerable);

  private static class EmptySetHolder<T>
  {
    public static readonly IReadOnlySet<T> Instance;
  }
}
