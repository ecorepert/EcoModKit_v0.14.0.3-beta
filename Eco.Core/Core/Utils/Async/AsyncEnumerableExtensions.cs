// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.Async.AsyncEnumerableExtensions
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System;
using System.Collections.Generic;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Core.Utils.Async;

public static class AsyncEnumerableExtensions
{
  /// <summary> Returns max value for task results. </summary>
  public static 
  #nullable disable
  Task<T> MaxAsync<T>(this IEnumerable<Task<T>> tasks, T minValue) where T : IComparable<T>;

  /// <summary> Adapts <see cref="T:System.Collections.Generic.IEnumerable`1" /> to <see cref="T:System.Collections.Generic.IAsyncEnumerable`1" />. </summary>
  public static IAsyncEnumerable<T> ToAsyncEnumerable<T>(this IEnumerable<T> enumerable);

  /// <summary> Makes <see cref="T:System.Collections.Generic.IAsyncEnumerable`1" /> from array of <see cref="T:System.Threading.Tasks.Task" />. </summary>
  public static IAsyncEnumerable<T> ToAsyncEnumerable<T>(this Task<T>[] tasks);

  /// <summary> Resolves <see cref="T:System.Collections.Generic.IAsyncEnumerable`1" /> to <see cref="T:System.Collections.Generic.List`1" />. </summary>
  public static Task<List<T>> ToList<T>(this IAsyncEnumerable<T> asyncEnumerable);
}
