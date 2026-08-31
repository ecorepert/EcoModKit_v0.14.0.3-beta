// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.UserTracker
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Plugins.Interfaces;
using Eco.Core.Utils;
using Eco.Gameplay.Skills;
using Eco.Shared.Localization;
using Eco.Shared.Utils;

#nullable disable
namespace Eco.Gameplay.Economy;

[Localized(true, false, "", false)]
[LocDisplayName("UserTracker")]
public class UserTracker : Singleton<UserTracker>, IInitializablePlugin, IServerPlugin
{
  public void Initialize(TimedTask timer);

  public LocString GetUserSkillTooltip(SkillTree skillTree);

  public string GetCategory();

  public string GetStatus();

  public override string ToString();
}
