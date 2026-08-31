// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.GameActionAccumulator
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Plugins.Interfaces;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Players;
using Eco.Shared.Utils;
using System.Threading.Tasks;

#nullable disable
namespace Eco.Gameplay.Civics;

/// <summary>Accumulator to aggregate <see cref="T:Eco.Gameplay.GameActions.GameAction" />'s property every intervalTime seconds.</summary>
public class GameActionAccumulator : 
  Singleton<GameActionAccumulator>,
  IThreadedPlugin,
  IShutdownablePlugin,
  IServerPlugin
{
  /// <summary>Add <see cref="T:Eco.Gameplay.GameActions.GameAction" /> every time it's need to accumulate.</summary>
  public void AddGameActions(AccumulatableAction gameAction, User user);

  public void Run();

  public Task ShutdownAsync();

  public override string ToString();

  public string GetCategory();

  public string GetStatus();
}
