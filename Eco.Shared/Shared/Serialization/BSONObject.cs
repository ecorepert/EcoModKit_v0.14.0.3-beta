// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Serialization.BSONObject
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Localization;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.IO;

#nullable enable
namespace Eco.Shared.Serialization;

[BsonManualSerialize]
public class BSONObject : 
  BSONValue<BSONObject>,
  IEnumerable<KeyValuePair<string, BSONValue?>>,
  IEnumerable
{
  public static BSONObject New { get; }

  public static BSONObject NewView { get; }

  public static BSONObject NewViewUpdate { get; }

  public override BSONObject ObjectValue { get; }

  public override int ViewID { get; }

  public void IncrementRef();

  /// <summary>
  /// Every time when you create a ref for shared BSONObject you have to increment ref.
  /// In this case it will be recycled only when last ref will be recycled.
  /// </summary>
  /// <returns><c>true</c> if ref was increased, <c>false</c> if ref can't be increased because of all existing refs was already recycled and this object is invalid.</returns>
  public bool TryIncrementRef();

  protected override bool TryPerformRecycle();

  public BSONValue? this[string key] { get; set; }

  public int Count { get; }

  public BSONValue? GetOrDefault(string key);

  public bool TryGetValue(string key, [NotNullWhen(true)] out BSONValue? value);

  /// <summary> Returns value for <paramref name="key" /> converted to <see cref="T:System.Boolean" />. </summary>
  public bool TryGetBoolValue(string key, out bool value);

  /// <summary> Returns value for <paramref name="key" /> converted to <see cref="T:System.String" />. </summary>
  public bool TryGetStringValue(string key, out string? value);

  /// <summary> Returns value for <paramref name="key" /> converted to <see cref="T:Eco.Shared.Localization.LocString" />. </summary>
  public bool TryGetLocStringValue(string key, out LocString value);

  /// <summary> Returns value for <paramref name="key" /> converted to <see cref="T:System.Guid" />. </summary>
  public bool TryGetGuidValue(string key, out Guid value);

  /// <summary> Returns value for <paramref name="key" /> converted to <see cref="T:System.Int32" />. </summary>
  public bool TryGetInt32Value(string key, out int value);

  /// <summary> Returns value for <paramref name="key" /> converted to <see cref="T:System.Int64" />. </summary>
  public bool TryGetInt64Value(string key, out long value);

  /// <summary> Returns value for <paramref name="key" /> converted to <see cref="T:System.Single" />. </summary>
  public bool TryGetFloatValue(string key, out float value);

  /// <summary> Returns value for <paramref name="key" /> converted to <see cref="T:System.Double" />. </summary>
  public bool TryGetDoubleValue(string key, out double value);

  /// <summary> Returns value for <paramref name="key" /> converted to <see cref="T:Eco.Shared.Serialization.BSONArray" />. </summary>
  public bool TryGetArrayValue(string key, [NotNullWhen(true)] out BSONArray? value);

  /// <summary> Returns value for <paramref name="key" /> converted to <see cref="T:System.Collections.Generic.List`1" />. </summary>
  public bool TryGetArrayValueAsList<T>(string key, [NotNullWhen(true)] out List<T?>? value) where T : IBsonDeserializable, new();

  /// <summary> Returns value for <paramref name="key" /> converted to <see cref="T:System.Collections.Generic.List`1" />. </summary>
  public bool TryGetInt32ArrayValueAsList(string key, [NotNullWhen(true)] out List<int>? value);

  public bool ContainsKey(string key);

  public void Add(string key, BSONValue value);

  public void Encode(MemoryStream stream);

  protected internal override string ToStringIndented(int indentLevel, HashSet<BSONValue> visited);

  public Dictionary<string, BSONValue?>.Enumerator GetEnumerator();

  IEnumerator<KeyValuePair<string, BSONValue?>> IEnumerable<KeyValuePair<string, BSONValue?>>.GetEnumerator();

  IEnumerator IEnumerable.GetEnumerator();
}
