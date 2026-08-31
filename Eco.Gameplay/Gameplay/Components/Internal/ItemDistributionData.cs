// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.Internal.ItemDistributionData
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.PropertyHandling;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Items.SearchAndSelect;
using Eco.Gameplay.Players;
using Eco.Gameplay.Utils;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using System.Collections.Generic;
using System.ComponentModel;

#nullable enable
namespace Eco.Gameplay.Components.Internal;

[Serialized]
public class ItemDistributionData : 
  IController,
  IViewController,
  IHasUniversalID,
  INotifyPropertyChanged,
  IThreadSafeSubscriptions,
  ISubscriptions<ThreadSafeSubscriptions>,
  ISubscriptions
{
  [Serialized]
  public 
  #nullable disable
  ThreadSafeDictionary<User, ItemTracker> UserToItemTracker;

  [Notify]
  public static ThreadSafeAction<ItemDistributionData> ItemsPerPersonChangedEvent { get; }

  [Serialized]
  [SyncToView(null, true)]
  [AutoRPC]
  public float MaxDaysToGetStuff { get; set; }

  [SyncToView(null, true)]
  public bool DataChanged { get; set; }

  public ItemDistributionData DifferenceSource { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  [WatchSubMember("OnSelectionChanged", "RaiseItemsPerPersonChangedEvent", SubPropWatcherFlag.None)]
  public SearchAndSelectInventory ItemsPerPerson { get; set; }

  public void OnPropertyChanged(string propertyName, object before, object after);

  public void CloneFrom(ItemDistributionData data);

  public IEnumerable<LocString> Describe();

  public ref ThreadSafeSubscriptions Subscriptions { get; }

  public event PropertyChangedEventHandler PropertyChanged;

  public ref int ControllerID { get; }
}
