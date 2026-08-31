// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Players.DifficultySettings
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Plugins;
using Eco.Core.Plugins.Interfaces;
using Eco.Core.Utils;
using Eco.Shared.Localization;
using Eco.Shared.Services;
using Eco.Shared.Utils;

#nullable disable
namespace Eco.Gameplay.Players;

[LocDisplayName("DifficultySettings")]
[Priority(-100)]
public class DifficultySettings : 
  Singleton<DifficultySettings>,
  IConfigurablePlugin,
  IEditablePlugin,
  IGUIPlugin,
  IServerPlugin,
  IInitializablePlugin
{
  public static ThreadSafeAction OnSettingsChanged;

  public IPluginConfig PluginConfig { get; }

  public DifficultySettingsConfig Config { get; }

  public ThreadSafeAction<object, string> ParamChanged { get; set; }

  public void ApplyParameters();

  public void OnEditObjectChanged(object o, string param);

  public string GetCategory();

  public object GetEditObject();

  public string GetStatus();

  public void Initialize(TimedTask timer);

  public override string ToString();

  public bool SetSettingsAndNotify(User user, GameSettings newSettings);
}
