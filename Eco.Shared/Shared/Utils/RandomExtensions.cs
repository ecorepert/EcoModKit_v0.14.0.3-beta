// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.RandomExtensions
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Math;

#nullable disable
namespace Eco.Shared.Utils;

public static class RandomExtensions
{
  public static bool Chance(this System.Random random, double chance);

  public static double Range(this System.Random random, double x, double y);

  public static double Range(this System.Random randomizer, Eco.Shared.Math.Range range);

  public static bool CoinToss(this System.Random random);

  /// <summary> Returns new <see cref="T:Eco.Shared.Math.Vector2i" /> with <c>x</c> greater or equal to <c>0</c> and less than <c>max.x</c>. Same for <c>y</c>. </summary>
  public static Vector2i Random(this System.Random random, Vector2i max);

  /// <summary> Shuffles <paramref name="array" /> elements in-place in random order using <paramref name="random" /> generator. </summary>
  public static void Shuffle<T>(this System.Random random, T[] array);
}
