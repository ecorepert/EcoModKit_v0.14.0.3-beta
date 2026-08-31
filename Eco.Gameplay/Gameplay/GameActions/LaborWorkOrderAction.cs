// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.GameActions.LaborWorkOrderAction
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Gameplay.Skills;
using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.GameActions;

[Eco.Shared.Networking.Eco(true, Serialized = false)]
[LocDisplayName("Add Labor To Work Order")]
[LocCategory("Crafting")]
[LocDescription("A citizen performed labor to a work order.")]
[ExtendedDescriptionLocStr("Triggers laws on settlements influencing the location performed.")]
public class LaborWorkOrderAction : WorkOrderAction
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The amount of labor performed.")]
  [CanAutoAssign]
  public float LaborAdded { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The profession needed to perform the labor.")]
  [CanAutoAssign]
  [RequiredTag("Profession")]
  public Skill LaborProfession { get; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The skill needed to perform the labor.")]
  [CanAutoAssign]
  [RequiredTag("Specialty")]
  public Skill LaborSkill { get; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The level of skill needed to perform the labor.")]
  [CanAutoAssign]
  public int SkillLevelNeeded { get; }
}
