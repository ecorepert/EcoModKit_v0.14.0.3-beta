// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.NewTooltip.TooltipLibraryFiles.AchievementDefinitionTooltipLibrary
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Achievements;
using Eco.Gameplay.Players;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using System;

#nullable enable
namespace Eco.Gameplay.Systems.NewTooltip.TooltipLibraryFiles;

[TooltipLibrary]
public static class AchievementDefinitionTooltipLibrary
{
  public static void Initialize();

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance | CacheAs.User, 100, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString AchievementDescTooltip(this 
  #nullable disable
  AchievementDefinition achievement, User user);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance | CacheAs.User, 100, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString AchievementTooltip(this AchievementInstance achievement, User user);
}
