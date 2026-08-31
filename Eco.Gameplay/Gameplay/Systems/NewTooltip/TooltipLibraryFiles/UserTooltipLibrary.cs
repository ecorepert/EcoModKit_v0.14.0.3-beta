// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.NewTooltip.TooltipLibraryFiles.UserTooltipLibrary
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.PropertyHandling;
using Eco.Gameplay.Players;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using System;

#nullable disable
namespace Eco.Gameplay.Systems.NewTooltip.TooltipLibraryFiles;

[TooltipLibrary]
public static class UserTooltipLibrary
{
  public static void Initialize();

  [TooltipAffectedBy("UserImage", "ReviewState", null)]
  [NewTooltipImage(CacheAs.Instance, 10, TTCat.Default, TTFlags.None, null)]
  public static LocString ImageInTooltip(this User user);

  [TooltipAffectedBy("UserAchievements", "AchievementsChangedEvent", null)]
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 20, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString ChievesTooltip(this User user);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 30, TTCat.Default, TTFlags.None, null, new Type[] {})]
  [TooltipAffectedBy("Reputation", null, null)]
  public static LocString RepTooltip(this User user);

  [TooltipAffectedBy("DirectCitizenship", null, null)]
  [TooltipAffectedBy("DirectCitizenship", "MarkedUpName", null)]
  [TooltipAffectedBy("DirectCitizenship", "SettlementLineageNameChangedEvent", null)]
  [TooltipAffectedBy("DirectCitizenship", "Founded", null)]
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 40, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString CitizenshipTooltip(this User user);

  [TooltipAffectedBy("OverheadName", null, null)]
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 45, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString KnownAsTooltip(this User user);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Disabled, 50, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString TooltipStatus(this User user, User viewer);

  /// <summary>The user's trading stores, behind a link so a prolific trader can't flood the player tooltip.</summary>
  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Disabled, 55, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString StoresTooltip(this User user, User viewer, TooltipOrigin origin);

  [Eco.Gameplay.Systems.NewTooltip.NewTooltip(CacheAs.Instance, 60, TTCat.Default, TTFlags.None, null, new Type[] {})]
  public static LocString DetailsTooltip(this User user);
}
