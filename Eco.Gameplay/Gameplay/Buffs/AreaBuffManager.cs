// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Buffs.AreaBuffManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Plugins.Interfaces;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Players;
using Eco.Shared.Utils;
using Eco.Shared.View;
using System.Collections.Generic;

#nullable enable
namespace Eco.Gameplay.Buffs;

/// <summary>Tracks all the buffs by location and shares with client.</summary>
public class AreaBuffManager : 
  Singleton<
  #nullable disable
  AreaBuffManager>,
  IController,
  IViewController,
  IHasUniversalID,
  IInitializablePlugin,
  IServerPlugin
{
  [SyncToView(null, true)]
  public ControllerDictionary<string, AreaBuffOverlay> Overlays { get; set; }

  public void RegisterBuff(IAreaBuffer buff);

  public void DeregisterBuff(IAreaBuffer buff);

  public void Initialize(TimedTask timer);

  public void ApplyBuffs(Player player, IEnumerable<IBuffable> buffables);

  public string GetCategory();

  public string GetStatus();

  public override string ToString();

  public ref int ControllerID { get; }
}
