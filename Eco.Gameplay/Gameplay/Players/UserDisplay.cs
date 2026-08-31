// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Players.UserDisplay
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Shared.Localization;
using Eco.Shared.View;
using PropertyChanged;
using System.ComponentModel;

#nullable enable
namespace Eco.Gameplay.Players;

public class UserDisplay : 
  IController,
  IViewController,
  IHasUniversalID,
  INotifyPropertyChanged,
  IThreadSafeSubscriptions,
  ISubscriptions<ThreadSafeSubscriptions>,
  ISubscriptions
{
  public UserDisplay(
  #nullable disable
  User user);

  /// <summary>Add statuses to user's display.</summary>
  public void SetStatus(string key, LocString status);

  /// <summary>Updates property status only by player's current position.</summary>
  /// 
  ///             todo: make this private, and make it trigger via events
  public void UpdatePropertyStatus();

  public event PropertyChangedEventHandler PropertyChanged;

  public ref ThreadSafeSubscriptions Subscriptions { get; }

  [DoNotNotify]
  public ref int ControllerID { get; }
}
