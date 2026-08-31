// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Weather.WeatherManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Plugins;
using Eco.Core.Serialization;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;
using Eco.Shared.View;
using Eco.Shared.Weather;
using PropertyChanged;
using System.ComponentModel;
using System.Threading.Tasks;

#nullable disable
namespace Eco.Gameplay.Weather;

[Serialized]
public sealed class WeatherManager : 
  Singleton<WeatherManager>,
  IController,
  IViewController,
  IHasUniversalID,
  INotifyPropertyChanged,
  IEditablePluginData,
  ISimplePluginData,
  IStorage,
  ISerializable
{
  [SyncToView(null, true)]
  [Serialized]
  public WeatherEventType Weather { get; set; }

  [Serialized]
  public bool WeatherSwitchEnabled { get; }

  [Serialized]
  public double StartTime { get; set; }

  [Serialized]
  public double EndTime { get; set; }

  public double TimeRemaining { get; }

  public WeatherConfig Config { get; }

  public void Initialize(TimedTask timer);

  public void Run();

  public Task ShutdownAsync();

  /// <summary> Sets the ability to switch weather by all sources. Useful to block it permanently like after meteor atmosphere destroyed, etc </summary>
  public void SetWeatherSwitch(bool value);

  /// <summary> Sets requested weather. Duration can be overriden with durationSeconds parameter</summary>
  public void SetWeather(WeatherEventType weatherEvent, double durationSeconds = -1.0);

  /// <summary> Sets random weather </summary>
  public void RandomizeWeather();

  /// <summary>Shows a weather type to a single player, on top of the shared weather. Purely visual and transient: not stored, not shared, dropped on reconnect or on any real weather change. Routed through the WorldTime net object because the client weather manager has no net channel of its own.</summary>
  public static void SetLocalWeatherForPlayer(INetClient client, WeatherEventType type);

  /// <summary>Drops a player's personal weather override, putting them back on the shared weather.</summary>
  public static void ClearLocalWeatherForPlayer(INetClient client);

  public string GetCategory();

  public string GetStatus();

  public string GetDisplayText();

  public LocString GetWeatherStatus();

  public void OnCreate();

  public void OnEditObjectChanged(object o, string param);

  public void OnLoaded();

  public event PropertyChangedEventHandler PropertyChanged;

  [DoNotNotify]
  public ref int ControllerID { get; }

  public object EditObject { get; set; }

  IPersistent IStorage.StorageHandle { get; set; }
}
