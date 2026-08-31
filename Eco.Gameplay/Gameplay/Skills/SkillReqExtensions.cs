// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Skills.SkillReqExtensions
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Players;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Skills;

public static class SkillReqExtensions
{
  public static bool IsAnyMet(this IEnumerable<BaseRequiresSkillAttribute> reqs, User user);

  public static string DescriptionAny(this IEnumerable<BaseRequiresSkillAttribute> reqs);

  public static string DescriptionAnyNoText(this IEnumerable<BaseRequiresSkillAttribute> reqs);
}
