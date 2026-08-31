// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.GameDataPlugin
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Plugins.Interfaces;
using Eco.Core.Utils;
using Eco.Shared.Localization;
using Eco.Shared.Utils;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Gameplay.Systems;

[LocDisplayName("GameDataPlugin")]
[Priority(3)]
public class GameDataPlugin : 
  Singleton<
  #nullable disable
  GameDataPlugin>,
  ISaveablePlugin,
  IContainsRegistrars,
  IServerPlugin,
  IInitializablePlugin,
  IThreadedPlugin,
  IShutdownablePlugin
{
  public override string ToString();

  public string GetCategory();

  public string GetStatus();

  public void InitializeRegistrars(TimedTask timer);

  public void SaveAll();

  public void Initialize(TimedTask timer);

  public void Run();

  public Task ShutdownAsync();
}
