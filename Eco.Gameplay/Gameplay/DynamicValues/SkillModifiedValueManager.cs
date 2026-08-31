// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.DynamicValues.SkillModifiedValueManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Players;
using Eco.Gameplay.Skills;
using Eco.Shared.Localization;
using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.DynamicValues;

public static class SkillModifiedValueManager
{
  /// <summary>Get UILink based on type using runtime type ids</summary>
  public static LocString GetBenefitNameForType(
  #nullable disable
  Type type);

  public static Tuple<Type, List<SkillModifiedValue>> GetBenefitsFor(Type obj);

  public static Dictionary<Type, List<SkillModifiedValue>> GetBenefitsFor(Skill skill);

  public static IEnumerable<LocString> GetBenefitDescription(object obj, User user);

  public static IEnumerable<LocString> GetBenefitDescription(
    Tuple<Type, List<SkillModifiedValue>> smvs,
    User user);

  public static void AddSkillBenefit(Type type, SkillModifiedValue smv, Type overrideType = null);

  public static void AddBenefitForObject(object obj, SkillModifiedValue smv);
}
