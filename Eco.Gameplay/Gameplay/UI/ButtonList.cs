// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.UI.ButtonList
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.View;
using PropertyChanged;
using System;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.UI;

/// <summary>Display a list of entries with a custom titled and colored button optionally displayed for each.</summary>
public class ButtonList : IController, IViewController, IHasUniversalID, INotifyPropertyChanged
{
  public Action<Player, object> ApplyClickedEvent;
  public Action<Player, object> DeletedClickedEvent;
  public Action<Player> AddClickedEvent;

  [SyncToView(null, true)]
  public LocString Title { get; set; }

  [SyncToView(null, true)]
  public ControllerList<ButtonListEntry> List { get; set; }

  [SyncToView(null, true)]
  public bool HasAddButton { get; set; }

  [RPC]
  public void Add(Player player);

  public event PropertyChangedEventHandler PropertyChanged;

  [DoNotNotify]
  public ref int ControllerID { get; }
}
