// Decompiled with JetBrains decompiler
// Type: Eco.Core.Plugins.EditablePlugin`2
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.Plugins.Interfaces;
using Eco.Core.Utils;

#nullable disable
namespace Eco.Core.Plugins;

public abstract class EditablePlugin<TPluginData, TConfig> : 
  SimplePlugin<TPluginData>,
  IConfigurablePlugin,
  IEditablePlugin,
  IGUIPlugin,
  IServerPlugin
  where TPluginData : class, IEditablePluginData
  where TConfig : new()
{
  public IPluginConfig PluginConfig { get; }

  public ThreadSafeAction<object, string> ParamChanged { get; set; }

  public EditablePlugin(string name);

  public void OnEditObjectChanged(object o, string param);

  public object GetEditObject();
}
