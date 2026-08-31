// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.LoseSpecialty
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Items;
using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.GameActions;

[Eco.Shared.Networking.Eco(true, Serialized = false)]
[LocCategory("Specialties")]
[LocDescription("A citizen lost a specialty.")]
[ExtendedDescriptionLocStr("Triggers laws on settlements that the Citizen is a part of.")]
public class LoseSpecialty : SkillAction
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Number of stars refunded.")]
  [CanAutoAssign]
  public int StarsRefunded { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Amount of XP refunded.")]
  [CanAutoAssign]
  public float XPRefunded { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Was the skill gained by self-teaching or education?")]
  [CanAutoAssign]
  public LearningMethod MethodLearned { get; set; }
}
