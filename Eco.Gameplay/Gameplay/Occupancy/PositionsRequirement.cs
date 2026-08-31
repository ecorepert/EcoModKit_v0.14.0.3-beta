// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Occupancy.PositionsRequirement
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.SharedTypes;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Occupancy;

/// <summary>Contains list of positions relative to the world object and the requirement they should abide to when placing it, as well as which part of the world object is it referring to
/// and the placement message the requirement refers to</summary>
public class PositionsRequirement
{
  public List<Vector3i> Positions;
  public PositionRequirementType Requirement;
  public LocString PartName;
  public LocString PlacementMsg;

  public PositionsRequirement(
    List<Vector3i> positions,
    PositionRequirementType requirement,
    LocString partName,
    LocString placementMessage);

  public bool PassesRequirements(Vector3i pos);
}
