// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.GameValues.Values.DistrictGameValue`1
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Gameplay.LegislationSystem;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Math;

#nullable disable
namespace Eco.Gameplay.Civics.GameValues.Values;

public abstract class DistrictGameValue<T> : GameValue<T>
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The list of districts to query.")]
  public GamePickerList<District> Districts { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Must be inside or outside the listed districts?")]
  public InsideOrOutside Requirements { get; set; }

  protected Eval<bool> CheckPositionMatchesDistrictRequirements(
    Vector3i? position,
    string objectName);
}
