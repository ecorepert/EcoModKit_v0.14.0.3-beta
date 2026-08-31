// Decompiled with JetBrains decompiler
// Type: Eco.Shared.SharedTypes.WorldObjectPlacementRequirements
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Math;
using System.Collections.Generic;

#nullable disable
namespace Eco.Shared.SharedTypes;

/// <summary> Contains all placement requirements that should be met for a WorldObject to be placed. </summary>
/// <remarks> Can be used from the client to make pre-emptive validations and render helpful stuff (e.g.: occupancy box). </remarks>
public struct WorldObjectPlacementRequirements
{
  public DirectionAxisFlags RequiredAttachedSide;
  public Dictionary<Vector3i, int> WaterDepthRequirements;
  public Dictionary<PositionRequirementType, List<Vector3i>> PositionRequirements;
  public bool CanBePlacedInWater;
  public bool MustBeGridAligned;
  public bool WallMounted;
  public bool IsCustomAttachmentLogic;
}
