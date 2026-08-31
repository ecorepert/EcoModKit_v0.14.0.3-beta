// Decompiled with JetBrains decompiler
// Type: Eco.WorldGenerator.Utils.BitmapExtensions
// Assembly: Eco.WorldGenerator, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: A724B74F-8AA3-4D77-9B84-B427AB13CB8B
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WorldGenerator.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.WorldGenerator.xml

using System.Drawing;

#nullable disable
namespace Eco.WorldGenerator.Utils;

public static class BitmapExtensions
{
  /// <summary>Returns a new instance of <paramref name="bitmap" /> and flips using the <paramref name="rotateFlipType" />.</summary>
  public static Bitmap FlipHorizontal(this Bitmap bitmap, RotateFlipType rotateFlipType);
}
