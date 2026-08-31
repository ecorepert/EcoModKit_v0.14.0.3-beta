// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.Binary.BinaryReaderExtensions
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.Collections.Generic;
using System.IO;

#nullable disable
namespace Eco.Shared.Utils.Binary;

public static class BinaryReaderExtensions
{
  /// <summary>Decodes integer encoded using <see cref="M:Eco.Shared.Utils.Binary.BinaryWriterExtensions.EncodeVariableLength(System.IO.BinaryWriter,System.Int32)" />.</summary>
  public static int DecodeIntVariableLength(this BinaryReader reader);

  /// <summary>Decodes integer encoded using <see cref="M:Eco.Shared.Utils.Binary.BinaryWriterExtensions.EncodeVariableLength(System.IO.BinaryWriter,System.UInt32)" />.</summary>
  public static uint DecodeUIntVariableLength(this BinaryReader reader);

  /// <summary>Decodes integer encoded using <see cref="M:Eco.Shared.Utils.Binary.BinaryWriterExtensions.EncodeVariableLength(System.IO.BinaryWriter,System.Int64)" />.</summary>
  public static long DecodeLongVariableLength(this BinaryReader reader);

  /// <summary>Decodes integer encoded using <see cref="M:Eco.Shared.Utils.Binary.BinaryWriterExtensions.EncodeVariableLength(System.IO.BinaryWriter,System.UInt64)" />.</summary>
  public static ulong DecodeULongVariableLength(this BinaryReader reader);

  /// <summary>Reads a string key,value Dictionary from a BinaryReader</summary>
  public static Dictionary<string, string> ReadDictionary(this BinaryReader reader);
}
