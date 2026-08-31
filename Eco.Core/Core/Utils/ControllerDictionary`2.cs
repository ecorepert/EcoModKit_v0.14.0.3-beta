// Decompiled with JetBrains decompiler
// Type: Eco.Core.Utils.ControllerDictionary`2
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.Controller;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Immutable;

#nullable disable
namespace Eco.Core.Utils;

public class ControllerDictionary<TKey, TValue> : 
  ThreadSafeDictionary<TKey, TValue>,
  ITrackedControllerEnumerable,
  ITrackedEnumerable,
  IEnumerable
{
  public TrackingCallbacks Callbacks { get; }

  public IController Parent { get; }

  public string PropertyName { get; }

  public override TValue this[TKey key] { set; }

  public ControllerDictionary(IController parent, [ControllerPropertyName(null)] string propertyName);

  public void Initialize(IController parent, [ControllerPropertyName(null)] string propertyName);

  /// <summary>Calls 'OnAdd' callback regardless of whether the item already existed or not.</summary>
  public override void Add(TKey key, TValue value);

  public override void AddRange(IEnumerable<KeyValuePair<TKey, TValue>> pairs);

  public override bool TryAdd(TKey key, TValue value);

  public override bool Remove(TKey key);

  public override ImmutableDictionary<TKey, TValue> RemoveRange(IEnumerable<TKey> keys);

  public override void SetItem(TKey key, TValue value);

  public override void SetItems(IEnumerable<KeyValuePair<TKey, TValue>> items);

  public override void Clear();

  public override bool TryRemove(TKey key, out TValue value);

  public override bool TryRemove(KeyValuePair<TKey, TValue> pair);

  public override void Set(ImmutableDictionary<TKey, TValue> val);

  public override void Set(Dictionary<TKey, TValue> val);

  public override IReadOnlyDictionary<TKey, TValue> GetSnapshotAndClear();

  public override TValue GetOrAdd(TKey key, TValue value);

  public override TValue GetOrAdd(TKey key, Func<TKey, TValue> createFunc);

  public override TValue AddOrUpdate(
    TKey key,
    TValue addValue,
    Func<TKey, TValue, TValue> updateValueFactory);

  public override TValue AddOrUpdate(
    TKey key,
    Func<TValue> createFunc,
    Func<TValue, TValue> updateFunc);
}
