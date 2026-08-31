// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.DisposableUtils
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;
using System.Collections;
using System.Collections.Generic;

#nullable disable
namespace Eco.Shared.Utils;

public static class DisposableUtils
{
  public static void DisposeAll<T>(this IEnumerable<T> disposables) where T : IDisposable;

  public static DisposableUtils.DisposableAction FromAction(Action a);

  public static DisposableUtils.DisposableActionEnumerator<T> FromEnumerator<T>(
    IEnumerator<T> enumerator,
    Action a);

  public static DisposableUtils.DisposableActionEnumerable<T> FromEnumerable<T>(
    IEnumerable<T> enumerable,
    Action a);

  public static DisposableUtils.DisposableActionEnumerator<T> FromEnumerator<T>(
    IEnumerator<T> enumerator,
    IDisposable chained);

  public static DisposableUtils.DisposableActionEnumerable<T> FromEnumerable<T>(
    IEnumerable<T> enumerable,
    IDisposable chained);

  public static DisposableUtils.DisposableActionEnumerable<T> FromEnumerable<T>(
    IEnumerable<T> enumerable,
    DisposableUtils.DisposableAction chained);

  /// Provides an enumerator which will execute an action when it is disposed (such as after a foreach loop)
  public struct DisposableActionEnumerator<T> : IDisposable, IEnumerator<T>, IEnumerator
  {
    private readonly IEnumerator<T> enumerator;
    private DisposableUtils.DisposableAction disposableAction;

    public DisposableActionEnumerator(IEnumerator<T> enumerator, Action onDispose);

    public T Current { get; }

    object IEnumerator.Current { get; }

    public bool MoveNext();

    public void Reset();

    public void Dispose();
  }

  public class DisposableActionEnumerable<T> : IEnumerable<T>, IEnumerable
  {
    public DisposableActionEnumerable(IEnumerable<T> enumerable, Action a);

    public DisposableUtils.DisposableActionEnumerator<T> GetEnumerator();

    IEnumerator<T> IEnumerable<T>.GetEnumerator();

    IEnumerator IEnumerable.GetEnumerator();
  }

  public struct DisposableAction : IDisposable
  {
    private readonly Action action;
    private bool isDisposed;

    public DisposableAction(Action onDispose);

    public void Dispose();
  }
}
