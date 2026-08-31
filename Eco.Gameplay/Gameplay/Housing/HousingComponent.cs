// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Housing.HousingComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Gameplay.Components;
using Eco.Gameplay.Housing.PropertyValues;
using Eco.Gameplay.Objects;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using PropertyChanged;

#nullable disable
namespace Eco.Gameplay.Housing;

[Serialized]
[Tag("Housing Objects")]
[RequireComponent(typeof (StatusComponent), null)]
[NoIcon]
[ForceCreateView]
public class HousingComponent : WorldObjectComponent
{
  public HomeFurnishingValue HomeValue;
  public SchoolFurnishingValue SchoolValue;

  public override WorldObjectComponentClientAvailability Availability { get; }

  public float FurnishingValue { get; }

  [Notify]
  [DependsOn("Status")]
  public LocString Description { get; }

  public override void Initialize();

  public void SetUniquenessCount(int val);

  public void UpdateDescription();
}
