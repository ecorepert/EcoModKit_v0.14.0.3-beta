// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Laws.LawEffectsMonitor
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Settlements;
using Eco.Shared.Utils;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Civics.Laws;

public class LawEffectsMonitor : AutoSingleton<LawEffectsMonitor>
{
  public void Initialize();

  public LazyResult HasAnyIgnoreAuthLaw<T>() where T : GameAction;

  public LazyResult HasIgnoreAuthLaw<T>(IEnumerable<Settlement> sets) where T : GameAction;

  public LazyResult HasIgnoreAuthLaw<T>(Settlement set) where T : GameAction;
}
