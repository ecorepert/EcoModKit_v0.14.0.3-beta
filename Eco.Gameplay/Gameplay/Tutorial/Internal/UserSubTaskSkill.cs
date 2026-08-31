// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Tutorial.Internal.UserSubTaskSkill
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Gameplay.Skills;

#nullable disable
namespace Eco.Gameplay.Tutorial.Internal;

public class UserSubTaskSkill : UserSubTaskSubscribe<Skill>
{
  public string SkillFriendlyName;
  public UserSubTaskSkill.SpecialtyRequirement Specialty;

  protected override ThreadSafeAction<Skill> Subscription { get; }

  protected override bool IsComplete(Skill s);

  public enum SpecialtyRequirement
  {
    MustBeSpecialty,
    MustNotBeSpecialty,
    Either,
  }
}
