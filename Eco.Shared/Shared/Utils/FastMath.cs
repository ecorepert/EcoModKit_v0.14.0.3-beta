// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.FastMath
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

#nullable disable
namespace Eco.Shared.Utils;

/// <summary>
/// Fast but not so precise math, it uses approximation for expensive functions (like pow). It may vary in 5-10% of original value, but it may be OK for some scenarios.
/// </summary>
public static class FastMath
{
  /// <summary>
  /// Calculates fast and dirty power of value. In worst cases it may have error up-to 25% (for big power value), but usually within 5%-12%.
  /// It is faster than regular pow in 23 times for Java (didn't test for C#).
  /// More details here https://martin.ankerl.com/2007/10/04/optimized-pow-approximation-for-java-and-c-c/.
  /// </summary>
  /// <param name="value"></param>
  /// <param name="pow"></param>
  /// <returns></returns>
  public static double FastAndDirtyPow(double value, double pow);
}
