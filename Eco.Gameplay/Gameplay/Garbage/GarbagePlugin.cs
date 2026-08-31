// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Garbage.GarbagePlugin
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Plugins;
using Eco.Core.Plugins.Interfaces;
using Eco.Core.Utils;
using Eco.Shared.Localization;
using System.Threading.Tasks;

#nullable disable
namespace Eco.Gameplay.Garbage;

[LocDisplayName("GarbagePlugin")]
public class GarbagePlugin : 
  SimplePlugin<GarbageManager>,
  IThreadedPlugin,
  IShutdownablePlugin,
  IServerPlugin,
  IInitializablePlugin
{
  public void Initialize(TimedTask timer);

  public void Run();

  public Task ShutdownAsync();

  public int Tick();
}
