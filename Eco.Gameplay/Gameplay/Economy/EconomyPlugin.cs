// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.EconomyPlugin
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Plugins.Interfaces;
using Eco.Core.Utils;
using Eco.Shared.Localization;
using Eco.Shared.Utils;
using System.Threading.Tasks;

#nullable disable
namespace Eco.Gameplay.Economy;

[LocDisplayName("EconomyPlugin")]
[Priority(-100)]
public class EconomyPlugin : 
  Singleton<EconomyPlugin>,
  IDisplayablePlugin,
  IGUIPlugin,
  IServerPlugin,
  IHasDisplayTabs,
  IDisplayTab,
  IThreadedPlugin,
  IShutdownablePlugin,
  ISaveablePlugin,
  IInitializablePlugin,
  IContainsRegistrars
{
  public string GetCategory();

  public string GetDisplayText();

  public string GetStatus();

  public override string ToString();

  public void Run();

  public Task ShutdownAsync();

  public void InitializeRegistrars(TimedTask timer);

  public void SaveAll();

  public void Initialize(TimedTask timer);
}
