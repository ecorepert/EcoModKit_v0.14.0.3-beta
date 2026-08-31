// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.DynamicValues.SkillModifiedValue
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Players;
using Eco.Gameplay.Skills;
using Eco.Shared.Localization;
using Eco.Shared.View;
using System;

#nullable disable
namespace Eco.Gameplay.DynamicValues;

public class SkillModifiedValue : IDynamicValue, IController, IViewController, IHasUniversalID
{
  public ref int ControllerID { get; }

  protected string BenefitsDescription { get; }

  public Type SkillType { get; }

  public DynamicValueType ValueType { get; }

  public string Verb { get; }

  public string ReqSkill { get; }

  public Skill Skill { get; }

  [SyncToView(null, true)]
  public int SkillTypeID { get; }

  [SyncToView(null, true)]
  public float[] Values { get; }

  [SyncToView(null, true)]
  public bool Increases { get; }

  public string[] BonusDescriptions { get; set; }

  public SkillModifiedValue(
    float startValue,
    ModificationStrategy strategy,
    Type skillType,
    Type beneficiary,
    LocString benefitsDescription,
    DynamicValueType valueType);

  public static void Initialize();

  protected void Init(float startValue, ModificationStrategy strategy);

  public float ValueAt(int level);

  public float GetBaseValue { get; }

  public float GetCurrentValue(IDynamicValueContext context, object obj);

  public int GetCurrentValueInt(IDynamicValueContext context, object obj, float multiplier = 1f);

  public string GetBenefitDescription(int level);

  public string BonusText(int level);

  public override string ToString();

  public Skill UserSkill(User user);

  public LocString DescribeBenefits(IDynamicValueContext context, bool includeName = false);

  public LocString DescribeBenefits(User user, bool includeName = false);

  public string SkillUILink(User user);

  public string BonusText(User user, bool atLevelUp = false);
}
