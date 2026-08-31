// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.Exhaustion.ExhaustionPlugin
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Plugins;
using Eco.Core.Plugins.Interfaces;
using Eco.Core.Utils;
using Eco.Shared.Utils;

#nullable disable
namespace Eco.Gameplay.Systems.Exhaustion;

/// <summary>Display Exhaustion configs to server GUI</summary>
public class ExhaustionPlugin : 
  Singleton<ExhaustionPlugin>,
  IConfigurablePlugin,
  IEditablePlugin,
  IGUIPlugin,
  IServerPlugin
{
  public ThreadSafeAction<object, string> ParamChanged { get; set; }

  public ExhaustionConfig Config { get; }

  public IPluginConfig PluginConfig { get; }

  public string GetCategory();

  public override string ToString();

  public object GetEditObject();

  public string GetStatus();

  public void OnEditObjectChanged(object o, string param);
}
