// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.LocalizationPlugin
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Plugins;
using Eco.Core.Plugins.Interfaces;
using Eco.Core.Utils;
using Eco.Shared.Localization;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Systems;

[LocDisplayName("LocalizationPlugin")]
public class LocalizationPlugin : 
  ICommandablePlugin,
  IServerPlugin,
  IInitializablePlugin,
  IEditablePlugin,
  IGUIPlugin,
  IConfigurablePlugin,
  IHasDisplayTabs,
  IHasInfoLink
{
  public override string ToString();

  public LocString InfoTextFormat { get; }

  public LocString InfoLinkText { get; }

  public string InfoUrl { get; }

  public IPluginConfig PluginConfig { get; }

  public static LocalizationConfig Config { get; }

  public ThreadSafeAction<object, string> ParamChanged { get; set; }

  public IEnumerable<IDisplayTab> DisplayTabs { get; }

  public LocalizationPlugin(bool runLocProcess);

  public void GetCommands(Dictionary<string, Action> nameToFunction);

  public string GetCategory();

  public string GetStatus();

  public void Initialize(TimedTask timer);

  public object GetEditObject();

  public void OnEditObjectChanged(object o, string param);
}
