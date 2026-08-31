// Decompiled with JetBrains decompiler
// Type: Eco.Core.DebugStatistic.ClientSyncPerformanceTracker
// Assembly: Eco.Core, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 9E4A3B57-8A7C-4A38-869C-34429F143981
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Core.xml

using Eco.Core.Controller;
using Eco.Core.Plugins.Interfaces;
using Eco.Core.Utils;
using Eco.Shared.Localization;
using Eco.Shared.Utils;
using System.Diagnostics;
using System.Text;

#nullable enable
namespace Eco.Core.DebugStatistic;

[Localized(false, true, "", false)]
public class ClientSyncPerformanceTracker : 
  Singleton<
  #nullable disable
  ClientSyncPerformanceTracker>,
  IDisplayablePlugin,
  IGUIPlugin,
  IServerPlugin,
  IHasDisplayTabs,
  IDisplayTab,
  IInitializablePlugin
{
  [Conditional("DEBUG")]
  public void AddControllerPropertyChange(IController controller, string property);

  [Conditional("DEBUG")]
  public void DumpControllerPropertyChanges();

  [Conditional("DEBUG")]
  public void AddControllersStatistic(StringBuilder sb);

  public string GetStatus();

  public void Initialize(TimedTask timer);

  public string GetDisplayText();

  [Conditional("DEBUG")]
  public void AddTime(string timerName, double milliseconds);

  public override string ToString();

  public string GetCategory();
}
