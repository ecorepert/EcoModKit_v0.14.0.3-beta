// Decompiled with JetBrains decompiler
// Type: Eco.Core.Plugins.SimplePlugin`1
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.Plugins.Interfaces;

#nullable disable
namespace Eco.Core.Plugins;

public abstract class SimplePlugin<TPluginData> : 
  IDisplayablePlugin,
  IGUIPlugin,
  IServerPlugin,
  IHasDisplayTabs,
  IDisplayTab,
  ISaveablePlugin
  where TPluginData : class, ISimplePluginData
{
  protected TPluginData data;
  protected string name;

  protected SimplePlugin();

  public SimplePlugin(string name);

  protected void DoLoad(string name);

  public override string ToString();

  public virtual string GetDisplayText();

  public virtual string GetStatus();

  public virtual string GetCategory();

  public virtual void SaveAll();
}
