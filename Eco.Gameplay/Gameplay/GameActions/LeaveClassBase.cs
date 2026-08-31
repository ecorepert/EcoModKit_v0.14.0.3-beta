// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.LeaveClassBase
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Economy;
using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.GameActions;

public abstract class LeaveClassBase : EducationAction
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Final tuition fee (prorated if left early), in total.")]
  public float TuitionFeeTotal { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Tuition paid to teacher.")]
  public float TuitionFeePaidToTeacher { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Tuition paid to table owner.")]
  public float TuitionFeePaidToOwner { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Tuition refunded to the student, if left early.")]
  public float TuitionFeeRefunded { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Currency which tuition is charged in.")]
  public Currency TuitionCurrency { get; set; }
}
