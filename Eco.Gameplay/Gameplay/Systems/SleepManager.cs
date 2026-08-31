// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.SleepManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Plugins;
using Eco.Core.Serialization;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;
using Eco.Shared.View;
using PropertyChanged;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Gameplay.Systems;

[Serialized]
[ChatCommandHandler]
public class SleepManager : 
  Singleton<
  #nullable disable
  SleepManager>,
  IController,
  IViewController,
  IHasUniversalID,
  INotifyPropertyChanged,
  IEditablePluginData,
  ISimplePluginData,
  IStorage,
  ISerializable
{
  public static ThreadSafeAction<User> OnUserSleep;

  public bool IsUserAsleep(User user);

  public IEnumerable<User> GetSleepingUsers(WorldObject bed);

  [SyncToView(null, true)]
  public bool AcceleratingTime { get; set; }

  [SyncToView(null, true)]
  public string SleepStatus { get; set; }

  [SyncToView(null, true)]
  public double SleepTimeStartSim { get; set; }

  public double SleepTimeStartReal { get; set; }

  public event PropertyChangedEventHandler PropertyChanged;

  [DoNotNotify]
  public ref int ControllerID { get; }

  IPersistent IStorage.StorageHandle { get; set; }

  public object EditObject { get; set; }

  public SleepConfig SleepConfig { get; }

  public void OnEditObjectChanged(object o, string param);

  public void Initialize(TimedTask timer);

  public void Run();

  public Task ShutdownAsync();

  [RPC]
  public void UserSleep(User user, WorldObject bed);

  [RPC]
  public void UserWake(User user);

  /// <summary>If the bed that player's sleeping on is destroyed, we need to wake the player up</summary>
  public void WakeUserUp(User user);

  [ChatSubCommand("Time", "Skips ahead time a given number of hours.", "st", ChatAuthorizationLevel.Admin)]
  public static void SkipTime(User user, float hoursToSkip = 24f);

  [ChatSubCommand("Time", "Force the world to fast forward. Pass 0 to stop.", "ff", ChatAuthorizationLevel.Admin)]
  public static void FastForward(User user, bool set = true);

  public string GetDisplayText();

  public string GetStatus();

  public string GetCategory();

  public void OnCreate();

  public void OnLoaded();
}
