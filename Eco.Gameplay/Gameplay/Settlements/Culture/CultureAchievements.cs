// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Settlements.Culture.CultureAchievements
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Achievements;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Settlements.Culture;

public class CultureAchievements : IContainsAchievements
{
  public static 
  #nullable disable
  IEnumerable<AchievementDefinition> MakeAchievements();

  private enum TastPrefReq
  {
    None,
    Best,
    Worst,
  }

  private enum HostReq
  {
    None,
    Host,
    Guest,
  }
}
