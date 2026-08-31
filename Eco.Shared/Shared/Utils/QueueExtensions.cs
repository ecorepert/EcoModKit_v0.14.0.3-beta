// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.QueueExtensions
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Collections.Generic;

#nullable enable
namespace Eco.Shared.Utils;

public static class QueueExtensions
{
  /// <summary>Deque a given number of elements into a list.</summary>
  public static List<T> DequeueIntoList<T>(this Queue<T> queue, int count);

  public static void AddRange<T>(this Queue<T> queue, IEnumerable<T> enu);

  /// <summary>
  /// Optimized non-alloc version of <see cref="M:Eco.Shared.Utils.QueueExtensions.AddRange``1(System.Collections.Generic.Queue{``0},System.Collections.Generic.IEnumerable{``0})" />.
  /// Because <see cref="M:System.Collections.Generic.List`1.GetEnumerator" /> returns struct <see cref="T:System.Collections.Generic.List`1.Enumerator" />, but <see cref="M:System.Collections.Generic.IEnumerable`1.GetEnumerator" /> returns <see cref="T:System.Collections.Generic.IEnumerator`1" /> as boxed version of <see cref="T:System.Collections.Generic.List`1.Enumerator" />.
  /// </summary>
  /// <param name="queue">destination queue.</param>
  /// <param name="list">list to add.</param>
  /// <typeparam name="T">item type.</typeparam>
  public static void AddRange<T>(this Queue<T> queue, List<T> list);
}
