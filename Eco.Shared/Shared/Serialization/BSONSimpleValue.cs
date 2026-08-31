// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Serialization.BSONSimpleValue
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Utils;
using System;
using System.Diagnostics;
using System.Numerics;
using System.Runtime.InteropServices;

#nullable enable
namespace Eco.Shared.Serialization;

/// <summary>Represents simple value (like float, double, int, string etc).</summary>
public class BSONSimpleValue : BSONValue<BSONSimpleValue>
{
  public static BSONSimpleValue New();

  public static BSONSimpleValue New(BSONValueType valueType);

  /// <summary>Releases all resources (nullify refs for GC and return pooled objects).</summary>
  protected override bool TryPerformRecycle();

  public override double DoubleValue { get; }

  public override float FloatValue { get; }

  public override byte ByteValue { get; }

  public override int Int32Value { get; }

  public override long Int64Value { get; }

  public override ulong UInt64Value { get; }

  public override BSONObject? ObjectValue { get; }

  public override LocString LocStringValue { get; }

  public override Color ColorValue { get; }

  public override Vector3 Vector3Value { get; }

  public override Eco.Shared.Math.Vector2 Vector2Value { get; }

  public override Vector3i? Vector3iValueNullable { get; }

  public override Vector3i Vector3iValue { get; }

  public override Vector2i Vector2iValue { get; }

  public override Eco.Shared.Math.Quaternion QuaternionValue { get; }

  public override Guid GuidValue { get; }

  [DebuggerBrowsable(DebuggerBrowsableState.Never)]
  public override byte[] BinaryValue { get; }

  public override ReadOnlySpan<byte> ByteSpanValue { get; }

  [DebuggerBrowsable(DebuggerBrowsableState.Never)]
  public override ushort[] UShortArrayValue { get; }

  public override ReadOnlySpan<ushort> UShortSpanValue { get; }

  [DebuggerBrowsable(DebuggerBrowsableState.Never)]
  public override int[] IntArrayValue { get; }

  public override ReadOnlySpan<int> IntSpanValue { get; }

  public override DateTime DateTimeValue { get; }

  public override string? StringValue { get; }

  public override bool BoolValue { get; }

  public override int ViewID { get; }

  public override int BlobID { get; }

  public override int ViewTypeID { get; }

  public struct BlittableDateTime
  {
    private long ticks;

    public DateTime Value { get; set; }

    public static implicit operator BSONSimpleValue.BlittableDateTime(DateTime value);

    public static implicit operator DateTime(BSONSimpleValue.BlittableDateTime value);
  }

  internal struct ArrayInfo
  {
    public int size;
    public bool pooled;
  }

  [StructLayout(LayoutKind.Explicit)]
  internal struct Union
  {
    [FieldOffset(0)]
    public float floatValue;
    [FieldOffset(0)]
    public double doubleValue;
    [FieldOffset(0)]
    public bool boolValue;
    [FieldOffset(0)]
    public BSONSimpleValue.BlittableDateTime dateTimeValue;
    [FieldOffset(0)]
    public int intValue;
    [FieldOffset(0)]
    public long longValue;
    [FieldOffset(0)]
    public ulong ulongValue;
    [FieldOffset(0)]
    public Vector3 vector3Value;
    [FieldOffset(0)]
    public Eco.Shared.Math.Vector2 vector2Value;
    [FieldOffset(0)]
    public Vector3i vector3iValue;
    [FieldOffset(0)]
    public Vector2i vector2iValue;
    [FieldOffset(0)]
    public Eco.Shared.Math.Quaternion quaternionValue;
    [FieldOffset(0)]
    public Guid guidValue;
    [FieldOffset(0)]
    public byte byteValue;
    [FieldOffset(0)]
    public Color colorValue;
    [FieldOffset(0)]
    public BSONSimpleValue.ArrayInfo arrayInfo;
  }
}
