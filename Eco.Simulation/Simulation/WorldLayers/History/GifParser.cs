// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.WorldLayers.History.GifParser
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Shared.Math;
using System;
using System.Collections.Generic;
using System.IO;

#nullable enable
namespace Eco.Simulation.WorldLayers.History;

public class GifParser
{
  public static 
  #nullable disable
  List<uint> ExtractFrameTimeComments(Stream stream);

  public static Vector2i GetDimensions(Stream stream);

  public static byte[] GetGlobalColorTable(Stream stream);

  public static void Parse(Stream stream, Func<byte, BinaryReader, bool> extensionParser);

  public static void ParseBlock(BinaryReader reader, Func<byte, BinaryReader, bool> extensionParser);

  public static void ParseExt(byte type, BinaryReader reader);

  public static void ParseHeader(BinaryReader reader);

  public static byte[] ReadSubBlock(BinaryReader reader);

  public static void SkipSubBlock(BinaryReader reader);
}
