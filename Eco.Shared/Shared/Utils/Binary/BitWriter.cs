// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.Binary.BitWriter
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.IO;
using System.Net;

#nullable disable
namespace Eco.Shared.Utils.Binary;

/// <summary>
/// This class provides functionally to write bit-wide values, tracking bitOffset (in opposite to byte-wide values for regular MemoryStream).
/// </summary>
public static class BitWriter
{
  public static void Write(MemoryStream stream, bool value, ref int bitOffset);

  public static void Write(MemoryStream stream, IPEndPoint value, ref int bitOffset);

  public static void Write(MemoryStream stream, byte value, ref int bitOffset);

  public static void Write(MemoryStream stream, ushort value, ref int bitOffset);

  public static void Write(
    MemoryStream stream,
    byte[] value,
    int offset,
    int length,
    ref int bitOffset);
}
