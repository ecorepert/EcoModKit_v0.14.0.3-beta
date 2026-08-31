// Decompiled with JetBrains decompiler
// Type: Eco.Plugins.Networking.NetworkManager
// Assembly: Eco.Plugins, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F4134161-E179-4364-AAAD-A17DB32FD1E5
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Plugins.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Plugins.xml

using Eco.Core.Plugins;
using Eco.Core.Plugins.Interfaces;
using Eco.Core.Utils;
using Eco.Shared.Localization;
using Eco.Shared.Networking.Udp;
using Eco.Shared.Utils;
using System;
using System.Net;
using System.Threading;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Plugins.Networking;

[LocDisplayName("NetworkManager")]
[Priority(200)]
public class NetworkManager : 
  Singleton<
  #nullable disable
  NetworkManager>,
  IConfigurablePlugin,
  IEditablePlugin,
  IGUIPlugin,
  IServerPlugin,
  IThreadedPlugin,
  IShutdownablePlugin,
  IDisplayablePlugin,
  IHasDisplayTabs,
  IDisplayTab,
  IInitializablePlugin
{
  public static IPEndPoint RemoteEndPoint;

  public ThreadSafeAction<object, string> ParamChanged { get; set; }

  public static EcoServerConfig Config { get; }

  public static Guid ServerID { get; }

  public static Guid ServerPassport { get; }

  public static IPEndPoint LocalEndPoint { get; }

  public IPluginConfig PluginConfig { get; }

  public string RelayAddress { get; }

  /// <summary></summary>
  public static string DiscordAddress { get; }

  /// <summary>Discord invite code for the configured Discord invite address if present. Otherwise null.</summary>
  public static string DiscordInviteCode { get; }

  public NetworkManager(IUdpLibrary udpLibrary, Eco.Core.Plugins.PluginConfig<EcoServerConfig> config);

  public Task ShutdownAsync();

  public void Initialize(TimedTask timer);

  public void Run();

  public Task DoWork(CancellationToken token);

  public string GetCategory();

  public string GetStatus();

  public override string ToString();

  public string GetDisplayText();

  public void OnDisplayTabVisibilityChange(bool show);

  public object GetEditObject();

  public void OnEditObjectChanged(object o, string param);

  public void SetPublic(bool isPublic);

  public void ResetID(bool showNotice);
}
