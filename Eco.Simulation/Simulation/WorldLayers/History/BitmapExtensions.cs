// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.WorldLayers.History.BitmapExtensions
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using System.Drawing;
using System.IO;

#nullable disable
namespace Eco.Simulation.WorldLayers.History;

public static class BitmapExtensions
{
  public static void CopyTo(this Bitmap bmp, byte[] output);

  public static void LoadFrom(this Bitmap bmp, byte[] input);

  public static Bitmap GetFinalBitmap(this Image img);

  public static void CopyTo(this Stream input, string fileName);

  public static byte[] ToArray(this Stream input);
}
