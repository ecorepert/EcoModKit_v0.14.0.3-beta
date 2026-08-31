// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Serialization.SimpleBSON
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;
using System.IO;

#nullable enable
namespace Eco.Shared.Serialization;

public static class SimpleBSON
{
  public static Action<BSONValue, double, int>? RecordEncoding { get; set; }

  /// <summary>Adds stats recording to <paramref name="value" />. Returns another <see cref="T:Eco.Shared.Serialization.BSONValue" /> object which wraps <paramref name="value" /> with stats recording loogic.</summary>
  public static BSONValue WithStatsRecording(this BSONValue value);

  public static BSONObject Load(MemoryStream stream);

  public static byte[] Dump(BSONObject obj);

  public static byte[] DumpValue(BSONValue obj);

  public static void DumpTo(MemoryStream ms, BSONObject obj);

  /// <summary> Dumps BSON array to memory stream. </summary>
  public static void DumpTo(MemoryStream ms, BSONArray array);

  public static BSONValue FromByteSpan(Span<byte> span);

  public static void EncodeString(MemoryStream stream, string? v);
}
