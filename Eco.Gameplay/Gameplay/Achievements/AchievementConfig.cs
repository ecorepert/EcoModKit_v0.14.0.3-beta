// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Achievements.AchievementConfig
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Localization;
using Eco.Shared.Utils;

#nullable disable
namespace Eco.Gameplay.Achievements;

[Localized(true, false, "", false)]
public class AchievementConfig : Singleton<AchievementConfig>
{
  [LocDescription("Only achievements earned on other servers this level of trust and up will be shown in the game.")]
  public ServerTrustLevel ShowAchievementsAtTrustLevel { get; set; }
}
