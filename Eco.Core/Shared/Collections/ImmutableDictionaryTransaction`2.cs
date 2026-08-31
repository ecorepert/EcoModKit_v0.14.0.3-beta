// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Collections.ImmutableDictionaryTransaction`2
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using System.Collections.Generic;
using System.Collections.Immutable;

#nullable disable
namespace Eco.Shared.Collections;

/// <summary>
/// It is a class for transaction for <see cref="T:System.Collections.Immutable.ImmutableDictionary`2" />. It isn't immutable by itself. It is also not thread-safe and can be used from one thread.
/// It provides more effective way to make multiple modifications for <see cref="T:System.Collections.Immutable.ImmutableDictionary`2" /> in transaction with tracking for all changes.
/// It behaves dictionary-like and implements most common dictionary methods.
/// You should use this class if you want to make multiple modifications to <see cref="T:Eco.Core.Utils.ThreadSafeDictionary`2" />, but don't wanna to make them visible
/// until all of them completed. You should ensure no other modifications done in <see cref="T:Eco.Core.Utils.ThreadSafeDictionary`2" /> until transaction complete, because they may be overwritten.
/// Then you can create/re-use <see cref="T:Eco.Shared.Collections.ImmutableDictionaryTransaction`2" /> and <see cref="M:Eco.Shared.Collections.ImmutableDictionaryTransaction`2.Start(System.Collections.Immutable.ImmutableDictionary{`0,`1})" /> it for <see cref="P:Eco.Core.Utils.ThreadSafeDictionary`2.Snapshot" />.
/// When you done you can <see cref="M:Eco.Shared.Collections.ImmutableDictionaryTransaction`2.Commit" /> it and get new <see cref="T:System.Collections.Immutable.ImmutableDictionary`2" /> with all modifications applied and then <see cref="M:Eco.Core.Utils.ThreadSafeDictionary`2.Set(System.Collections.Immutable.ImmutableDictionary{`0,`1})" /> it back.
/// It may be extended if required to expose all modifications done in transaction for processing.
/// </summary>
public class ImmutableDictionaryTransaction<TKey, TValue>
{
  public bool ContainsKey(TKey key);

  public void Add(TKey key, TValue value);

  public bool Remove(TKey key);

  public void RemoveRange(IEnumerable<TKey> keys);

  public bool TryGetValue(TKey key, out TValue value);

  public TValue this[TKey key] { get; set; }

  /// <summary>Starts new transaction for <paramref name="initial" />. Be sure you <see cref="M:Eco.Shared.Collections.ImmutableDictionaryTransaction`2.Commit" /> previous transaction, before this call, because state may not be clear!</summary>
  public void Start(ImmutableDictionary<TKey, TValue> initial);

  /// <summary>Finishes transaction, clears transaction state and returns new <see cref="T:System.Collections.Immutable.ImmutableDictionary`2" /> with all transaction changes applied.</summary>
  public ImmutableDictionary<TKey, TValue> Commit();
}
