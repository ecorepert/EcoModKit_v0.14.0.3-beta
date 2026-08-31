// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Math.AxisExtensions
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

#nullable disable
namespace Eco.Shared.Math;

public static class AxisExtensions
{
  public static DirectionAxis[] AllAxis;

  public static bool HasSideDirection(this DirectionAxisFlags flags);

  public static HorzDir Opposite(this HorzDir dir);

  public static (HorzDir Dir1, HorzDir Dir2) DiagonalComponents(this HorzDir dir);

  public static (DirectionAxis Negative, DirectionAxis Positive) GetAxisDirections(this Axis axis);

  public static DirectionAxis[] GetArrayOfAxis(this DirectionAxisFlags axes);
}
