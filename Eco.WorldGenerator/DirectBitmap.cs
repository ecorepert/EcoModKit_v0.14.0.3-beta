// Decompiled with JetBrains decompiler
// Type: Eco.WorldGenerator.DirectBitmap
// Assembly: Eco.WorldGenerator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A724B74F-8AA3-4D77-9B84-B427AB13CB8B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WorldGenerator.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WorldGenerator.xml

using System;
using System.Drawing;

#nullable disable
namespace Eco.WorldGenerator;

public sealed class DirectBitmap : IDisposable
{
  public Bitmap Bitmap { get; }

  public int[] Bits { get; }

  public bool Disposed { get; }

  public int Height { get; }

  public int Width { get; }

  public static implicit operator Bitmap(DirectBitmap dbm);

  public DirectBitmap(DirectBitmap source);

  public DirectBitmap(int width, int height);

  public void SetPixel(int x, int y, Color color);

  public Color GetPixel(int x, int y);

  public byte GetR(int x, int y);

  public byte GetG(int x, int y);

  public byte GetB(int x, int y);

  public void Dispose();
}
