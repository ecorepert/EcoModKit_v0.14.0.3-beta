// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.StrangeCloudGameplay.StrangeWorldsPlugin
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Plugins;
using Eco.Core.Plugins.Interfaces;
using Eco.Core.Utils;
using Eco.Shared.Localization;
using Eco.Shared.Utils;
using System;
using System.ComponentModel;
using System.Threading.Tasks;

#nullable disable
namespace Eco.Gameplay.StrangeCloudGameplay;

[TypeConverter(typeof (ExpandableObjectConverter))]
[Localized(true, false, "", false)]
public class StrangeWorldsPlugin : 
  Singleton<StrangeWorldsPlugin>,
  IConfigurablePlugin,
  IEditablePlugin,
  IGUIPlugin,
  IServerPlugin
{
  internal StrangeBlueprintMonitor StrangeBlueprintMonitor;
  public static Func<Task> ForceHeartbeat;

  public IPluginConfig PluginConfig { get; }

  public StrangeWorldsConfig Config { get; }

  public ThreadSafeAction<object, string> ParamChanged { get; set; }

  public string GetCategory();

  public object GetEditObject();

  public string GetStatus();

  public override string ToString();

  public void OnEditObjectChanged(object o, string param);
}
