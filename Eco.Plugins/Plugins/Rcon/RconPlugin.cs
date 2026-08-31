// Decompiled with JetBrains decompiler
// Type: Eco.Plugins.Rcon.RconPlugin
// Assembly: Eco.Plugins, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: F4134161-E179-4364-AAAD-A17DB32FD1E5
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Plugins.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Plugins.xml

using Eco.Core.Plugins.Interfaces;
using Eco.Core.Utils;
using Eco.Shared.Localization;
using Eco.Shared.Utils;
using System.Threading;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Plugins.Rcon;

/// <summary>
/// <para>
/// This plugin adds Remote Console (RCON) support to the Eco Server. It follows the Source RCON standard used by majority of the industry. The plugin exposes
/// a TCP socket (Default on port 3002) for allowing remote administrative command execution and automated command handling for tasks, tools, and shutdown procedures.
/// </para>
/// 
/// <para>A complete how-to for RCON and a complete protocol breakdown can be found on the Wiki here: https://wiki.play.eco/en/RCON </para>
/// </summary>
[LocDisplayName("RconPlugin")]
[Worker(Repeatable = true)]
public sealed class RconPlugin : 
  Singleton<
  #nullable disable
  RconPlugin>,
  IWorkerPlugin,
  IServerPlugin,
  IShutdownablePlugin,
  IInitializablePlugin
{
  public string GetStatus();

  public void Initialize(TimedTask timer);

  public Task DoWork(CancellationToken token);

  public Task ShutdownAsync();

  public override string ToString();

  public string GetCategory();
}
