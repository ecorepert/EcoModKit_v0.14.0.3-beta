// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Districts.DistrictUtils
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.LegislationSystem;
using Eco.Gameplay.Property;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Civics.Districts;

public static class DistrictUtils
{
  public static bool BelongsToDistrict(
    this Deed deed,
    District district,
    DeedRelationToDistrict relationType);

  public static bool BelongsToDistrict(this Vector3i position, District district);

  public static bool BelongsToDistrict(this Vector2i position, District district);

  public static IEnumerable<Deed> GetAllDeeds(
    this IEnumerable<District> districts,
    DeedRelationToDistrict relationType);

  public static LocString GetRelationLocStr(this DeedRelationToDistrict relationType);
}
