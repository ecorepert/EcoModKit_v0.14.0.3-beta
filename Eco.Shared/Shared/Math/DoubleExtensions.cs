// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Math.DoubleExtensions
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

#nullable disable
namespace Eco.Shared.Math;

public static class DoubleExtensions
{
  /// <summary>Tries to convert <paramref name="value" /> to <see cref="T:System.Int64" />. It will fail if the value out of long value range, NaN or infinity.</summary>
  public static bool TryConvertToLong(this double value, out long longValue);
}
