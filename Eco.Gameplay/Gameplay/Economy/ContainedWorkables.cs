// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.ContainedWorkables
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Economy.Common;
using Eco.Gameplay.Economy.Contracts;
using Eco.Gameplay.Economy.WorkParties;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable enable
namespace Eco.Gameplay.Economy;

[Serialized]
public class ContainedWorkables : 
  IClearRequestHandler,
  IController,
  IViewController,
  IHasUniversalID,
  INotifyPropertyChanged,
  IThreadSafeSubscriptions,
  ISubscriptions<ThreadSafeSubscriptions>,
  ISubscriptions
{
  [Serialized]
  [Notify]
  public 
  #nullable disable
  ControllerList<Workable> AllWorkables { get; set; }

  public void Subscribe(Action onChange);

  public void Unsubscribe(Action onChange);

  public IEnumerable<Workable> Workables { get; }

  public IEnumerable<Contract> Contracts { get; }

  public IEnumerable<WorkParty> WorkParties { get; }

  public bool Any { get; }

  public LocString Description { get; }

  public bool HasDataThatCanBeCleared { get; }

  public ref int ControllerID { get; }

  public ref ThreadSafeSubscriptions Subscriptions { get; }

  public event PropertyChangedEventHandler PropertyChanged;

  public void RemovedWorkable(INetObject arg1, object arg2);

  ~ContainedWorkables();

  public void GetFromRegistrars(WorldObject hostObject);

  public void GetFromRegistrars(User user);

  public void RecalculateWorkables();

  public void UpdateHostName();

  public void Remove(Workable workable);

  public void Add(Workable workable);

  public Result TryHandleClearRequest(Player player);
}
