// Decompiled with JetBrains decompiler
// Type: Eco.World.WorldPlugin
// Assembly: Eco.World, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B2A8792E-938E-4BB5-B27F-EF3390C48946
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.xml

using Eco.Core.Plugins;
using Eco.Core.Plugins.Interfaces;
using Eco.Core.Utils;
using Eco.Shared.Localization;
using System.Threading;
using System.Threading.Tasks;

#nullable enable
namespace Eco.World;

[LocDisplayName("WorldPlugin")]
[Priority(100)]
public class WorldPlugin : 
  IThreadedPlugin,
  IShutdownablePlugin,
  IServerPlugin,
  IDisplayablePlugin,
  IGUIPlugin,
  IHasDisplayTabs,
  IDisplayTab,
  IConfigurablePlugin,
  IEditablePlugin,
  IInitializablePlugin
{
  public 
  #nullable disable
  AtmosphereObject Atmosphere { get; }

  public IPluginConfig PluginConfig { get; }

  public ThreadSafeAction<object, string> ParamChanged { get; set; }

  public void Run();

  public Task ShutdownAsync();

  public Task TickAll(CancellationToken cancellationToken);

  public void Initialize(TimedTask initializeTask);

  public string GetStatus();

  public string GetCategory();

  public string GetDisplayText();

  public override string ToString();

  public object GetEditObject();

  public void OnEditObjectChanged(object o, string param);

  [IgnoreHostedWorlds]
  private class WorldConfig
  {
    public const float MinCPU = 0.25f;
    public const float MaxCPU = 1f;

    [LocDescription("Default atmosphere object type for the world.")]
    [LocDisplayName("Atmosphere Type")]
    public AtmosphereType AtmosphereType { get; set; }

    [LocDescription("Max % of one CPU to use for ticking world chunks. (25% - 100%)")]
    [LocDisplayName("World Tick CPU Max")]
    public float WorldTickCPUMax { get; set; }
  }
}
