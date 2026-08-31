// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Objects.MemoryManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Plugins;
using Eco.Core.Plugins.Interfaces;
using Eco.Core.Utils;
using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.Objects;

/// <summary> Used to find memory leaks, by example, world objects that are still exists in memory even after removal from the world. </summary>
[LocDisplayName("MemoryManager")]
public class MemoryManager : 
  IInitializablePlugin,
  IServerPlugin,
  IDisplayablePlugin,
  IGUIPlugin,
  IHasDisplayTabs,
  IDisplayTab,
  IConfigurablePlugin,
  IEditablePlugin
{
  public string GetCategory();

  public void Initialize(TimedTask timer);

  public string GetStatus();

  public override string ToString();

  public string GetDeadObjectsInMemoryReport();

  public string GetDisplayText();

  public IPluginConfig PluginConfig { get; }

  public ThreadSafeAction<object, string> ParamChanged { get; set; }

  public object GetEditObject();

  public void OnEditObjectChanged(object o, string param);

  [Localized(true, false, "", false)]
  [IgnoreHostedWorlds]
  private class MemoryManagerConfig
  {
    [LocDescription("Tracks the world objects that are still in memory even after removal. Helps to find memory leaks. ")]
    public bool TrackUnremovedWorldObjects { get; set; }
  }
}
