// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.PauseManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Plugins;
using Eco.Core.Serialization;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;
using Eco.Shared.View;

#nullable disable
namespace Eco.Gameplay.Systems;

[Serialized]
public class PauseManager : 
  Singleton<PauseManager>,
  IEditablePluginData,
  ISimplePluginData,
  IStorage,
  ISerializable,
  IController,
  IViewController,
  IHasUniversalID
{
  public ThreadSafeAction<PauseConfig> ConfigChanged;

  public object EditObject { get; set; }

  public PauseConfig Config { get; }

  public IPersistent StorageHandle { get; set; }

  public ref int ControllerID { get; }

  [SyncToView(null, true)]
  public bool Paused { get; }

  public string GetDisplayText();

  public string GetStatus();

  public string GetCategory();

  public void OnCreate();

  public void OnLoaded();

  public void OnEditObjectChanged(object o, string param);

  public void Unpause();
}
