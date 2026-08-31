// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.WorldLayers.History.LZWEncoder
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using System.IO;

#nullable disable
namespace Eco.Simulation.WorldLayers.History;

public class LZWEncoder
{
  public LZWEncoder(byte[] data, int codeBits, int dataSize);

  public static void Encode(byte[] data, int codeBits, Stream output, int dataSize);

  public void Encode(Stream os);
}
