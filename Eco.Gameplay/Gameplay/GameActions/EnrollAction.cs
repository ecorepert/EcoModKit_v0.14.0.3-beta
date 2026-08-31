// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.EnrollAction
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Gameplay.Economy;
using Eco.Gameplay.Items;
using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.GameActions;

[Eco.Shared.Networking.Eco(true)]
[LocCategory("Education")]
[LocDescription("A student enrolled in a class.")]
[RelatedFeature("EducationEnabled", true)]
public class EnrollAction : EducationAction
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Tuition fee, held in escrow.")]
  public float TuitionFee { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Currency which tuition is charged in.")]
  public Currency TuitionCurrency { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Percent of tuition to be held for teacher.")]
  public float TeacherPercent { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The subject being taught in this class.")]
  [RequiredTag("Specialty")]
  public Item SubjectBeingTaught { get; set; }
}
