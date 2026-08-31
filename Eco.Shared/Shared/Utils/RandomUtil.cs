// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.RandomUtil
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Math;
using System.Numerics;
using System.Runtime.CompilerServices;

#nullable disable
namespace Eco.Shared.Utils;

public static class RandomUtil
{
  public static System.Random Global { get; }

  public static float Range(Eco.Shared.Math.Vector2 vec);

  public static float Range(float x, float y);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static float Range(this System.Random random, float x, float y);

  public static double Range(double x, double y);

  public static int Next(int maxValue);

  public static int Range(int x, int y);

  public static bool CoinToss();

  public static float Value { get; }

  public static int IntValue { get; }

  public static Eco.Shared.Math.Vector2 InsideUnitCircle { get; }

  /// <summary>Returns true or false based on random chance.</summary>
  /// <param name="p">Value in range [0,1] determining chance of true being returned, where 0 means no chance and 1 means true will always be returned.</param>
  public static bool Chance(float p);

  public static Vector2i Vec2i(int p);

  public static Vector3 Vec3 { get; }

  public static Eco.Shared.Math.Vector2 Vec2 { get; }

  public static Vector3i Range(Vector3i min, Vector3i max);

  public static Vector2i Random(this Vector2i pos);

  /// <summary> Shortcut for <see cref="M:Eco.Shared.Utils.RandomExtensions.Shuffle``1(System.Random,``0[])" /> with <see cref="P:Eco.Shared.Utils.RandomUtil.Global" /> randomizer. </summary>
  public static void Shuffle<T>(T[] array);

  /// <summary>Return an array of random bytes of the given length</summary>
  public static byte[] RandomBytes(int len);
}
