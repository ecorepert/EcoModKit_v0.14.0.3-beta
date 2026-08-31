// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.PerformCivicActionComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Core.PropertyHandling;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Components;

[Serialized]
[LocDisplayName("Civic Actions")]
[LocDescription("Allows citizens to perform certain civic actions, which affect the government associated with this object.")]
[CreateComponentTabLoc(null, true)]
[HasIcon(null)]
[Ecopedia(null, "Civic Action Component", false, true, null)]
public class PerformCivicActionComponent : WorldObjectComponent, INotifyPropertyChanged
{
  public override WorldObjectComponentClientAvailability Availability { get; }

  [SyncToView(null, true)]
  public override LocString ComponentTabName { get; }

  [Autogen]
  [SyncToView(null, true)]
  [EnabledParam("CivicActionEnabled")]
  [UIListTypeName("ButtonGrid")]
  public IEnumerable<Type> AvailableCivicActions { get; }

  [SyncToView(null, true)]
  [DependsOnMember("Settlement")]
  public IEnumerable<bool> CivicActionEnabled(Player player);

  [SyncToView(null, true)]
  [DependsOnMember("Settlement")]
  public LocString CivicPowers(Player player);

  public override void Initialize();

  /// <summary></summary>
  /// <param name="player"></param>
  /// <returns></returns>
  [RPC]
  public void Select(Player player, Type type);
}
