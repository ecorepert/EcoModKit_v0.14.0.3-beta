// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.ControllerList`1
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.Controller;
using Eco.Shared.Networking;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;
using System.Runtime.CompilerServices;

#nullable disable
namespace Eco.Core.Utils;

/// <summary>A thread-safe list of items, which automatically handles changed calls when mutating the list. Initialize must be called before use.</summary>
public class ControllerList<T> : 
  ThreadSafeList<T>,
  IClientControlledList,
  IClientControlledContainer,
  ITrackedControllerEnumerable,
  ITrackedEnumerable,
  IEnumerable
{
  public TrackingCallbacks Callbacks { get; }

  public IController Parent { get; }

  public string PropertyName { get; }

  public Type Type { get; }

  protected ControllerList();

  public ControllerList(IController parent, [ControllerPropertyName(null)] string propertyName);

  public ControllerList(IController parent, [ControllerPropertyName(null)] string propertyName, IEnumerable<T> contents);

  /// <summary>Add and use the callbacks if they exist.</summary>
  public (object Entry, bool Success) TryAdd(INetObject obj);

  public override void Add(T item);

  public override void AddRange(IEnumerable<T> items);

  /// <summary>Remove the indexed element atomically and return it (and call callbacks on it)</summary>
  public override T RemoveAtAndReturn(int index);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  object IClientControlledList.GetAt(int index);

  public override void Clear();

  public override void Insert(int index, T item);

  public override void Set(IEnumerable<T> entries);

  public bool Set(INetObject caller, IEnumerable<T> entries);

  public override bool Remove(T item);

  public override bool RemoveRange(IEnumerable<T> items);

  public override void RemoveAll(Predicate<T> match, out ImmutableList<T> removed);

  public override int RemoveAll(Predicate<T> predicate);

  public override bool RemoveFirst(Predicate<T> matcher);

  public override void AddOrReplace(T item, Predicate<T> matcher);

  public override ImmutableList<T> GetAndClear();

  public override void Sort();

  public override void Sort(Comparison<T> comparison);

  public override void Sort(IComparer<T> comparer);

  public override void Sort(int index, int count, IComparer<T> comparer);

  public override void Move(int index, int newIndex);

  public override void SetAt(int index, T obj);

  public override T GetOrCreate(Predicate<T> test, Func<T> create);

  public override T this[int i] { get; set; }

  void IClientControlledList.SetAt(INetObject caller, int index, object obj);

  bool IClientControlledContainer.Add(INetObject caller, object obj);

  bool IClientControlledContainer.Set(INetObject caller, IEnumerable<object> entries);

  void IClientControlledList.Move(INetObject caller, int iEntry, int newIndex);

  void IClientControlledList.RemoveAt(INetObject caller, int iEntry);

  bool IClientControlledContainer.Remove(INetObject caller, object obj);

  public Action<INetObject, object> Destroy();

  public object Valid();
}
