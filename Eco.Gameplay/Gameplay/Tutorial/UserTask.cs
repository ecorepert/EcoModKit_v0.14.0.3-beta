// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Tutorial.UserTask
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Players;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using JetBrains.Annotations;
using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable enable
namespace Eco.Gameplay.Tutorial;

[Serialized]
public class UserTask : IController, IViewController, IHasUniversalID, INotifyPropertyChanged
{
  public bool IsOpened;
  public 
  #nullable disable
  ThreadSafeAction<bool> OnComplete;
  [Serialized]
  public int ChainedTasksCompleted;

  public event PropertyChangedEventHandler PropertyChanged;

  [SyncToView(null, true)]
  public LocString LocalizedTitle { get; }

  [SyncToView(null, true)]
  public string UIStateToSet { get; }

  [SyncToView(null, true)]
  public string Popup { get; }

  [SyncToView(null, true)]
  public string TargetUIName { get; }

  [SyncToView(null, true)]
  public bool ActionsAtEnd { get; }

  [SyncToView(null, true)]
  public float TutorialIndex { get; }

  public Func<User, bool> AutoSkip { get; }

  [SyncToView(null, true)]
  public ControllerList<UserSubTask> SubTasks { get; }

  [SyncToView(null, true)]
  public bool Skipped { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public string Title { get; }

  [SyncToView(null, true)]
  public int DisplayPosition { get; set; }

  public bool CompletedOnClient { get; set; }

  public IEnumerable<string> ChainedTaskNames { get; }

  public TutorialTaskPopup GetPopup();

  public ref int ControllerID { get; }

  public bool Complete { get; }

  public bool ShouldSkip { get; }

  [UsedImplicitly]
  public UserTask();

  public void ResetSubTasks();

  public void ResetSubTasksState();

  public void Initialize(User user, UserTaskTemplate template);

  public void Reset();

  internal void MakeActive();

  public void OnEnteredWorld();

  public void DeInit();

  [RPC]
  public void SkipTask(Player player);

  public void GiveItems(User user, bool forceGive = false);

  public virtual void Added();

  public void TriggerFromChainedTaskComplete();

  public override int GetHashCode();

  public override bool Equals(object obj);
}
