// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Pathing.TraversalData
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

#nullable disable
namespace Eco.Shared.Pathing;

/// <summary>Struct describing how an agent pathfinds along a route.</summary>
public readonly struct TraversalData
{
  public readonly float WanderingSpeed;
  public readonly float RunningSpeed;
  public readonly float Speed;
  public readonly float RotationSpeed;
  public readonly bool IsWander;

  public TraversalData(
    float speed,
    float runningSpeed,
    float rotationSpeed,
    float wanderingSpeed,
    bool isWander);
}
