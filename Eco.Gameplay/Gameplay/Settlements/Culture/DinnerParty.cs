// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Settlements.Culture.DinnerParty
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Players;
using Eco.Gameplay.Property;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Gameplay.Systems.TextLinks;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable enable
namespace Eco.Gameplay.Settlements.Culture;

[Serialized]
public class DinnerParty : 
  ILinkable,
  IHasSerializableID,
  IHasUniversalID,
  IController,
  IViewController,
  INotifyPropertyChanged
{
  public static 
  #nullable disable
  ThreadSafeAction<User, DinnerParty> UserRequestsFinishEvent;
  [Serialized]
  public ThreadSafeList<ServedGuest> Guests;
  [Serialized]
  public double StartTime;
  [Serialized]
  public double EndTime;
  [Serialized]
  public Deed Deed;
  [Serialized]
  public string DeedName;

  [Serialized]
  public bool SentInitialNotice { get; set; }

  [Serialized]
  public float RawTotal { get; set; }

  [Serialized]
  public string Description { get; set; }

  [Serialized]
  public float DecayedTotal { get; set; }

  [Serialized]
  public Vector3i MarkerPos { get; set; }

  public Eco.Gameplay.UI.WorldMarker.WorldMarker WorldMarker { get; set; }

  [Serialized]
  public int DaysOldAtLastCalculation { get; }

  [SyncToView(null, true)]
  public int GuestsCount { get; }

  [SyncToView(null, true)]
  public string Title { get; set; }

  [SyncToView(null, true)]
  public string StatusText { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public string Error { get; set; }

  [SyncToView(null, true)]
  public bool IsHost(User user);

  public float AverageCourses { get; }

  public int StartingDay { get; }

  public int DaysOld { get; }

  public double TimeOld { get; }

  public bool NeedsUpdate { get; }

  public bool HasGuest(User user);

  public bool Finished { get; }

  public int FinishedDay { get; }

  public double FinishTime { get; }

  public IEnumerable<User> GuestUsers { get; }

  public LocString StatusDescription { get; }

  [RPC]
  [System.ComponentModel.Description("Click this to mark the dinner party finished and provide bonuses.")]
  public void FinishDinnerParty(User user);

  public void Finish();

  public ServedGuest AddGuest(ServedGuest guest);

  public bool UpdateTotal();

  public void Msg(LocString text);

  public void OnLinkClicked(TooltipOrigin origin, TooltipClickContext clickContext, User user);

  public LocString UILinkContent();

  [DoNotNotify]
  public ref int ControllerID { get; }

  public event PropertyChangedEventHandler PropertyChanged;

  /// <summary>
  /// Calculates the culture value of a food item for a given user based on their taste preference.
  /// </summary>
  /// <param name="user">The user whose taste preference to consider</param>
  /// <param name="foodType">The type of food to calculate value for</param>
  /// <returns>The calculated culture value for the food item</returns>
  public static float CalculateFoodValue(User user, Type foodType);
}
