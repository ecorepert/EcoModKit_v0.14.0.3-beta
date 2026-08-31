// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Serialization.BSONArray
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Utils;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;

#nullable enable
namespace Eco.Shared.Serialization;

/// <summary>
/// Array of <see cref="T:Eco.Shared.Serialization.BSONValue" /> items. Used in binary serialization while data transfer data between client and server.
/// It implements List like behavior based on shared array pool instead of backing List for better memory utilization.
/// If we use a List then it will never drop in Capacity, eventually all lists in BSONArray will grow to match bigger capacity needed for often used arrays.
/// I.e. if we transfer BSON array with size 100 once per second and use 100 BSONArray objects then:
/// - with lists every time when BSONArray created (actually rented from pool) it may be a different BSONArray
/// and it will be filled with 100 items even if all other BSON arrays we use need just 2-10 items. Now we have 100x100 = 10 000 capacity allocated and never released.
/// - with array pools it will use same array from shared pool every time when BSONArray need to accept 100 items (assuming we don't have two BSON arrays of that size in parallel).
/// All other arrays not exceed 10 items so we have just 100 + 99x10 = 1 090 capacity allocated instead of 10 000.
/// </summary>
public sealed class BSONArray : 
  BSONValue<BSONArray>,
  IList<BSONValue?>,
  ICollection<BSONValue?>,
  IEnumerable<BSONValue?>,
  IEnumerable
{
  public static BSONArray New { get; }

  public static BSONArray FromEnumerable(IEnumerable<BSONValue?> values);

  public static BSONArray SerializeFromEnumerable<T>(IEnumerable<T> values);

  public static BSONArray FromEnumerable(IEnumerable<int> values);

  public static BSONArray FromEnumerable(IEnumerable<long> values);

  public static BSONArray FromEnumerable(IEnumerable<byte> values);

  public static BSONArray FromEnumerable(IEnumerable<double> values);

  public static BSONArray FromEnumerable(IEnumerable<float> values);

  public static BSONArray FromEnumerable(IEnumerable<Color> values);

  public static BSONArray FromEnumerable(IEnumerable<Vector3> values);

  public static BSONArray FromEnumerable(IEnumerable<Vector3i> values);

  public static BSONArray FromEnumerable(IEnumerable<Vector2i> values);

  public static BSONArray FromEnumerable(IEnumerable<Eco.Shared.Math.Quaternion> values);

  public static BSONArray FromEnumerable(IEnumerable<Guid> values);

  public static BSONArray FromEnumerable(IEnumerable<LocString> values);

  public static BSONArray FromEnumerable(IEnumerable<string> values);

  public static BSONArray FromEnumerable(IEnumerable<bool> values);

  public static BSONArray FromEnumerable(IEnumerable<DateTime> values);

  public override BSONArray ArrayValue { get; }

  public ReadOnlySpan<BSONValue?> AsSpan();

  protected override bool TryPerformRecycle();

  public int IndexOf(BSONValue? item);

  public void Insert(int index, BSONValue? item);

  public void RemoveAt(int index);

  public BSONValue? this[int index] { get; set; }

  public bool Remove(BSONValue? item);

  public int Count { get; }

  public bool IsReadOnly { get; }

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public void Add(BSONValue? item);

  public void Clear();

  /// <summary>Clears <see cref="T:Eco.Shared.Serialization.BSONArray" /> without recycling it's items. May be useful when array copied to another BSONArray to avoid recycling items twice.</summary>
  public void ClearNoRecycle();

  public bool Contains(BSONValue? item);

  public void CopyTo(BSONValue?[] array, int arrayIndex);

  /// <summary>Adds new items form <paramref name="span" />.</summary>
  public void AddSpan(ReadOnlySpan<BSONValue?> span);

  public void AddRange(IEnumerable<BSONValue?> items);

  protected internal override string ToStringIndented(int indentLevel, HashSet<BSONValue> visited);

  public Vector2i[] ToArrayVector2i();

  public ArraySegment<BSONValue?>.Enumerator GetEnumerator();

  IEnumerator<BSONValue?> IEnumerable<BSONValue?>.GetEnumerator();

  IEnumerator IEnumerable.GetEnumerator();
}
