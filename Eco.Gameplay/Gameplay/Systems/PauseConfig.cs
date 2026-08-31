// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.PauseConfig
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Plugins;
using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.Systems;

[Localized(true, false, "", false)]
public class PauseConfig
{
  [IgnoreHostedWorlds]
  [LocDescription("The World will be on Pause if this option is set")]
  public bool Paused { get; set; }

  [LocDescription("The World will resume as soon as first player login to the world")]
  public bool UnpauseAtFirstLogin { get; set; }
}
