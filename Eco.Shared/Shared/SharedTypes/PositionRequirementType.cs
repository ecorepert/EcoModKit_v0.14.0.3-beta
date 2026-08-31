// Decompiled with JetBrains decompiler
// Type: Eco.Shared.SharedTypes.PositionRequirementType
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

#nullable disable
namespace Eco.Shared.SharedTypes;

/// <summary> Occupancy Requirements can vary per position. These are all the used types so far. </summary>
/// <remarks> Used by both server and client to validate the position of a WorldObject's placement. </remarks>
public enum PositionRequirementType
{
  OnSolidGround,
  OnEmptySpace,
  InsideWater,
}
