// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.SkillScroll`2
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Skills;
using System;

#nullable disable
namespace Eco.Gameplay.Items;

public abstract class SkillScroll<TSkill, TBook> : SkillScroll
  where TSkill : Skill, new()
  where TBook : SkillBook
{
  public override Type SkillType { get; }

  public override Type SkillBookType { get; }
}
