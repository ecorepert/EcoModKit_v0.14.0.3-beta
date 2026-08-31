// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.Binary.ByteArrayHelper
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System.IO;
using System.Numerics;

#nullable disable
namespace Eco.Shared.Utils.Binary;

public static class ByteArrayHelper
{
  public static string ConvertToHex(byte[] data);

  public static void Write(this BinaryWriter writer, Vector3 v);

  public static void Write(this BinaryWriter writer, Eco.Shared.Math.Vector2 v);
}
