// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Tutorial.UserTaskManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Tests;
using Eco.Core.Utils;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;
using Eco.Shared.Items;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable enable
namespace Eco.Gameplay.Tutorial;

/// <summary>Class for handling the tasks (so far just tutorials) that an individual user is given. Manages the creation, tracking,
/// ordering, etc of them.</summary>
[Serialized]
[ChatCommandHandler]
public class UserTaskManager : IController, IViewController, IHasUniversalID, INotifyPropertyChanged
{
  [Serialized]
  public ThreadSafeHashSet<string> ItemsGiven;

  [Serialized]
  [SyncToView(null, true)]
  public bool SkippedAll { get; set; }

  public int CurrentTaskPosition { get; }

  public ThreadSafeAction OnTaskCompleted { get; }

  public ref int ControllerID { get; }

  public void AddSidePanelButton(string id, string icon, Action onClick);

  public SidePanelButton? GetSidePanelButton(string id);

  public void RemoveSidePanelButton(string id);

  [ChatCommand("Shows commands for tutorials.", ChatAuthorizationLevel.DevTier)]
  public static void Tutorials(User user);

  [CITest(true)]
  [ChatSubCommand("Tutorials", "Resets the tutorial, including record of given items (which menu option does not do).", ChatAuthorizationLevel.DevTier)]
  public static void Reset(User user);

  [ChatSubCommand("Tutorials", "Starts specific tutorial task by name. Use without arguments to list all available tasks.", ChatAuthorizationLevel.DevTier)]
  public static void Task(User user, string? taskName = null);

  [ChatSubCommand("Tutorials", "Unlocks all UI panels locked by tutorial.", ChatAuthorizationLevel.DevTier)]
  public static void UnlockUI(User user);

  public void Init(User user);

  public bool IsTaskComplete(string name);

  public bool TasksComplete(IEnumerable<string> names);

  public bool SomeTasksComplete(IEnumerable<string> names);

  public bool TaskAlreadyAdded(string name);

  public UserTask GetUserTask(string name);

  public bool AnyTasksActive();

  public bool TryAddActiveTask(string taskName);

  /// <summary>Show a popup and track it as seen as a tutorial.</summary>
  public void TryShowTutorialPopup(TutorialTaskPopup popup);

  public void TaskComplete(bool skipPopup = false);

  /// <summary>Called from the escape menu on the client, resets all tutorials and clears tutorial cache on the client.</summary>
  [RPC]
  public void ResetTutorial(Player player);

  [RPC]
  public void SkipAllTasks(Player player);

  [RPC]
  public void AddViewedPopup(UserTask task);

  public void UpdatePopupsFromClient(User user);

  public event PropertyChangedEventHandler? PropertyChanged;
}
