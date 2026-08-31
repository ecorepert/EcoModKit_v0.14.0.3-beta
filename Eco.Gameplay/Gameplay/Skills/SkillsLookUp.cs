// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Skills.SkillsLookUp
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Skills;

public class SkillsLookUp
{
  public static Dictionary<Type, Type> SkillToSkillBook;
  public static Dictionary<Type, Type> SkillToSkillScroll;
  public static Dictionary<Type, Type> SkillScrollToSkillbook;
  public Dictionary<Type, SkillTree> SkillToRootTree;
  public Dictionary<Type, SkillTree> SkillToSpecialityTree;
  public Dictionary<Type, SkillTree> SkillToSkillTree;
  public Dictionary<Type, RequiresSkillAttribute> SkillToSkillReq;
  public Dictionary<Type, List<RequiresSkillAttribute>> SkillToResearchSkillReq;
}
