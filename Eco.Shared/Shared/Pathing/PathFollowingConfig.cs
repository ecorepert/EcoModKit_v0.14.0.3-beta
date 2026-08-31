// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Pathing.PathFollowingConfig
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

#nullable disable
namespace Eco.Shared.Pathing;

/// <summary>Constant values that need to be shared between server and client.</summary>
/// <remarks>In the future they will be replaced with variables configured separately for all animal species.</remarks>
public static class PathFollowingConfig
{
  public const float SmoothChasingSpeed = 3f;
  public const float RoughChasingSpeed = 4.5f;
  public const float MinChasingSpeed = 0.5f;
  public const float SharpTurnMinAngle = 70f;
  public const float TightSharpTurnDetectionRange = 1.5f;
  public const float TightSharpTurnSpeedModifier = 0.3f;
  public const float VerticalMovementModifier = 0.85f;
  public const float MaxVerticalSpeed = 2.5f;
  public const float MaxSmoothContinuationAngle = 100f;
}
