// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.StrangeCloudGameplay.StrangeWorldsConfig
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Shared.Localization;
using Eco.Shared.StrangeCloudShared;
using Eco.Shared.View;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.StrangeCloudGameplay;

[Localized(true, false, "", false)]
public class StrangeWorldsConfig : 
  IController,
  IViewController,
  IHasUniversalID,
  IStrangeWorldsConfig,
  INotifyPropertyChanged
{
  [SyncToView(null, false)]
  [LocDescription("If set, we don't care where citizens bought any items, we allow all of them to be used here.")]
  public bool AcceptItemsBoughtInAnyWorld { get; set; }

  [SyncToView(null, false)]
  [LocDescription("If the above option is not enabled and this world doesn't accept all items, this list can contain the IDs of worlds and the IDs of owners of worlds from which this server will allow items. This allows specifying servers together in a network of shared item usage.")]
  public List<Guid> AcceptItemsBoughtInTheseWorlds { get; set; }

  [SyncToView(null, false)]
  [LocDescription("If set, we don't care where citizens got an achievement, we allow all of them to be used displayed and used here.")]
  public bool AcceptAchievementsFromAnyWorld { get; set; }

  [SyncToView(null, false)]
  [LocDescription("If the above option is not enabled and this world doesn't accept all items, this list can contain the IDs of worlds and the IDs of owners of worlds from which this server will allow items. This allows specifying servers together in a network of shared item usage.")]
  public List<Guid> AcceptAchievementsFromTheseWorlds { get; set; }

  [SyncToView(null, false)]
  [LocDescription("If true, paid variants of items will be allowed in stores.")]
  public bool AllowPaidItemsInPlayerStores { get; set; }

  [SyncToView(null, false)]
  [LocDescription("If true, only players owning a blueprint can place items using it.")]
  public bool AllowUsingPaidItemsWithoutBlueprint { get; set; }

  [SyncToView(null, false)]
  [LocDescription("If true, paid variants cannot be crafted at all and the marketplace cannot be opened.")]
  public bool BlockUsingAnyPaidItem { get; set; }

  [DoNotNotify]
  public ref int ControllerID { get; }

  public event PropertyChangedEventHandler PropertyChanged;
}
