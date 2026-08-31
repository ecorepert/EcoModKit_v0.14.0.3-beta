// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Serialization.BSONValue
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Utils;
using System;
using System.Collections.Generic;
using System.Numerics;
using System.Runtime.CompilerServices;

#nullable enable
namespace Eco.Shared.Serialization;

/// <summary>Base class for <see cref="T:Eco.Shared.Serialization.BSONSimpleValue" />, <see cref="T:Eco.Shared.Serialization.BSONArray" /> and <see cref="T:Eco.Shared.Serialization.BSONObject" />.</summary>
public abstract class BSONValue : IEquatable<BSONValue?>
{
  public BSONValueType ValueType { get; }

  public virtual double DoubleValue { get; }

  public virtual float FloatValue { get; }

  public virtual Vector3 Vector3Value { get; }

  public virtual Eco.Shared.Math.Vector2 Vector2Value { get; }

  public virtual Vector3i Vector3iValue { get; }

  public virtual Vector2i Vector2iValue { get; }

  public virtual Vector3i? Vector3iValueNullable { get; }

  public virtual Eco.Shared.Math.Quaternion QuaternionValue { get; }

  public virtual string? StringValue { get; }

  public virtual bool BoolValue { get; }

  public virtual DateTime DateTimeValue { get; }

  public virtual byte ByteValue { get; }

  public virtual int Int32Value { get; }

  public virtual long Int64Value { get; }

  public virtual ulong UInt64Value { get; }

  public virtual Guid GuidValue { get; }

  public virtual Color ColorValue { get; }

  public virtual BSONArray ArrayValue { get; }

  public virtual BSONObject? ObjectValue { get; }

  public virtual LocString LocStringValue { get; }

  public virtual int ViewID { get; }

  public virtual int BlobID { get; }

  public virtual int ViewTypeID { get; }

  public bool IsNull { get; }

  /// <summary>Returns array of byte values. When possible use <see cref="P:Eco.Shared.Serialization.BSONValue.ByteSpanValue" /> instead to reduce allocations with pooling. When array accessed then we can't control references on it anymore and can't return it back to pool.</summary>
  public virtual byte[] BinaryValue { get; }

  /// <summary>Returns byte <see cref="T:System.ReadOnlySpan`1" />, should always be preferred over <see cref="P:Eco.Shared.Serialization.BSONValue.BinaryValue" /> because latter disables pooling for the value.</summary>
  public virtual ReadOnlySpan<byte> ByteSpanValue { get; }

  /// <summary>Returns array of ushort values. When possible use <see cref="P:Eco.Shared.Serialization.BSONValue.UShortSpanValue" /> instead to reduce allocations with pooling. When array accessed then we can't control references on it anymore and can't return it back to pool.</summary>
  public virtual ushort[] UShortArrayValue { get; }

  /// <summary>Returns ushort <see cref="T:System.ReadOnlySpan`1" />, should always be preferred over <see cref="P:Eco.Shared.Serialization.BSONValue.UShortArrayValue" /> because latter disables pooling for the value.</summary>
  public virtual ReadOnlySpan<ushort> UShortSpanValue { get; }

  /// <summary>Returns array of int values. When possible use <see cref="P:Eco.Shared.Serialization.BSONValue.IntSpanValue" /> instead to reduce allocations with pooling. When array accessed then we can't control references on it anymore and can't return it back to pool.</summary>
  public virtual int[] IntArrayValue { get; }

  /// <summary>Returns int <see cref="T:System.ReadOnlySpan`1" />, should always be preferred over <see cref="P:Eco.Shared.Serialization.BSONValue.IntArrayValue" /> because latter disables pooling for the value.</summary>
  public virtual ReadOnlySpan<int> IntSpanValue { get; }

  public List<T?> ListValue<T>();

  public static implicit operator BSONValue(double v);

  public static implicit operator BSONValue(float v);

  public static implicit operator BSONValue(Color v);

  public static implicit operator BSONValue(Vector3 v);

  public static implicit operator BSONValue(Eco.Shared.Math.Vector2 v);

  public static implicit operator BSONValue(Vector3i v);

  public static implicit operator BSONValue(Vector2i v);

  public static implicit operator BSONValue(Eco.Shared.Math.Quaternion v);

  public static implicit operator BSONValue(Guid v);

  public static implicit operator BSONValue(byte v);

  public static implicit operator BSONValue(int v);

  public static implicit operator BSONValue(long v);

  public static implicit operator BSONValue(byte[] v);

  public static implicit operator BSONValue(ushort[] v);

  public static implicit operator BSONValue(DateTime v);

  public static implicit operator BSONValue(string v);

  public static implicit operator BSONValue(bool v);

  public static implicit operator BSONValue(LocString v);

  public static implicit operator double(BSONValue? v);

  public static implicit operator float(BSONValue? v);

  public static implicit operator Color(BSONValue? v);

  public static implicit operator Vector3(BSONValue? v);

  public static implicit operator Eco.Shared.Math.Vector2(BSONValue? v);

  public static implicit operator Vector3i(BSONValue? v);

  public static implicit operator Vector2i(BSONValue? v);

  public static implicit operator Eco.Shared.Math.Quaternion(BSONValue? v);

  public static implicit operator Guid(BSONValue? v);

  public static implicit operator int(BSONValue? v);

  public static implicit operator long(BSONValue? v);

  public static implicit operator DateTime(BSONValue? v);

  public static implicit operator string?(BSONValue? v);

  public static implicit operator bool(BSONValue? v);

  public static implicit operator LocString(BSONValue? v);

  public static implicit operator Vector3i?(BSONValue? v);

  protected static BSONValue NewBSONValue(BSONValueType valueType);

  /// <summary>Creates new <see cref="F:Eco.Shared.Serialization.BSONValueType.ViewRef" /> value.</summary>
  public static BSONValue NewViewRef(int viewId);

  public static BSONValue NewBlobRef(int blobId);

  public static BSONValue NewCachedDataRef(string hash);

  /// <summary>Creates new <see cref="F:Eco.Shared.Serialization.BSONValueType.ViewTypeId" /> value.</summary>
  public static BSONValue NewTypeId(int viewTypeId);

  public static BSONValue NewBSONValue(double v);

  public static BSONValue NewBSONValue(float v);

  public static BSONValue NewBSONValue(Color v);

  public static BSONValue NewBSONValue(Vector3 v);

  public static BSONValue NewBSONValue(Eco.Shared.Math.Vector2 v);

  public static BSONValue NewBSONValue(Vector3i v);

  public static BSONValue NewBSONValue(Vector2i v);

  public static BSONValue NewBSONValue(Eco.Shared.Math.Quaternion v);

  public static BSONValue NewBSONValue(Guid v);

  public static BSONValue NewBSONValue(LocString v);

  public static BSONValue NewBSONValue(string v);

  public static BSONValue NewBSONValue(byte[] v, bool compressed = false, bool saveInCache = false);

  public static BSONValue NewBSONValue(ushort[] v);

  public static BSONValue NewBsonValue(int[] v);

  /// <summary>Makes new <see cref="T:Eco.Shared.Serialization.BSONValue" /> from <paramref name="values" /> using pooled array and saving GC allocations.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static BSONValue NewBsonValue(ICollection<ushort> values);

  /// <summary>Makes new <see cref="T:Eco.Shared.Serialization.BSONValue" /> from <paramref name="values" /> using pooled array and saving GC allocations.</summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static BSONValue NewBsonValue(ICollection<int> values);

  public static BSONValue NewBSONValue(bool v);

  public static BSONValue NewBSONValue(DateTime v);

  public static BSONValue NewBSONValue(int v);

  public static BSONValue NewBSONValue(long v);

  public static BSONValue NewBSONValue(ulong v);

  public static BSONValue NewBSONValue(byte v);

  public abstract void Recycle();

  public T Cast<T>() where T : IBsonDeserializable, new();

  public bool Equals(BSONValue? other);

  public override string? ToString();

  public string? DebugToString();

  protected internal virtual string? ToStringIndented(int indentLevel, HashSet<BSONValue> visited);
}
