// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Serialization.BSONValueType
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

#nullable disable
namespace Eco.Shared.Serialization;

/// <summary>Value type of <see cref="T:Eco.Shared.Serialization.BSONValue" />. <see cref="T:Eco.Shared.Serialization.BSONValue" /> may be used to store different value types and with that enum they may be distinguished.</summary>
public enum BSONValueType : byte
{
  Null = 0,
  Double = 1,
  Float = 2,
  String = 3,
  Array = 4,
  Binary = 5,
  Compressed = 6,
  UShortArray = 7,
  Boolean = 8,
  UTCDateTime = 9,
  Byte = 10, // 0x0A
  Int32 = 11, // 0x0B
  Int64 = 12, // 0x0C
  Color = 13, // 0x0D
  Vector3 = 14, // 0x0E
  Vector2 = 15, // 0x0F
  Vector3i = 16, // 0x10
  Vector2i = 17, // 0x11
  Quaternion = 18, // 0x12
  Guid = 19, // 0x13
  LocString = 20, // 0x14
  Object = 21, // 0x15
  View = 22, // 0x16
  ViewRef = 23, // 0x17
  ViewTypeId = 24, // 0x18
  Cached = 25, // 0x19
  IntArray = 26, // 0x1A
  ViewUpdate = 27, // 0x1B
  ValueWithStatsRecording = 28, // 0x1C
  BlobRef = 29, // 0x1D
  CacheRef = 30, // 0x1E
  ClientCached = 31, // 0x1F
  UInt64 = 32, // 0x20
  Recycling = 255, // 0xFF
}
