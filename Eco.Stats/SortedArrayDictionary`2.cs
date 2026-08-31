// Decompiled with JetBrains decompiler
// Type: Eco.Stats.SortedArrayDictionary`2
// Assembly: Eco.Stats, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: D39D8B25-455D-45BA-A4CB-7B41EC57568B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Stats.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Stats.xml

#nullable disable
namespace Eco.Stats;

/// <summary>
/// Highly optimized dictionary-like data structure with sorted keys. Allows effectively find first element lesser or equal than key with <see cref="M:Eco.Stats.SortedArrayDictionary`2.TryGetLesserOrEqualThan(`0,`1@)" />
/// and may be extended for iterating all elements in sorted order or to get elements greater than specific key.
/// Initially was used for LiteDb custom transactions implementations, but now may be used for other means.
/// </summary>
internal class SortedArrayDictionary<TKey, TValue>
{
  public int Size { get; }

  public SortedArrayDictionary();

  public SortedArrayDictionary(int capacity);

  public bool TryGetLesserOrEqualThan(TKey key, out TValue value);

  public TKey[] GetKeys();

  public TValue this[TKey key] { get; set; }

  public void Remove(TKey key);

  public bool TryRemove(TKey key, out TValue value);

  public bool TryRemove(TKey key, TValue value);

  public void Clear();
}
