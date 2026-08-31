// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.DynamicValues.TalentBenefitTooltipManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.DynamicValues;

public static class TalentBenefitTooltipManager
{
  public static 
  #nullable disable
  IEnumerable<LocString> GetDescriptionOfTalentBenefitsFrom<T>(T key, User user);

  public static LocString DescribeTalentBenefitsForTag(string tagName, User user);

  public static LocString DescribeTalentBenefitsForItemType(Type itemType, User user);

  public static void AddTalentBenefit(Type itemType, Type talentType);

  public static void AddTalentBenefit(string targetType, Type talentType);
}
