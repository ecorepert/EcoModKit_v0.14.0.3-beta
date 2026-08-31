// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Players.UserUI
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Systems;
using System;

#nullable disable
namespace Eco.Gameplay.Players;

public class UserUI
{
  public ThreadSafeAction<string> OnOpen { get; }

  public ThreadSafeAction<string> OnClose { get; }

  public ThreadSafeAction MinimapPan { get; }

  public ThreadSafeAction AllSkillsDisplayed { get; }

  public ThreadSafeAction MinimapZoom { get; }

  public ThreadSafeAction MinimapTooltip { get; }

  public ThreadSafeAction MinimapOpened { get; }

  public ThreadSafeAction MinimapWorldLayerSelect { get; }

  public ThreadSafeAction<string> OnTabSelected { get; }

  public ThreadSafeAction FormSelected { get; }

  public ThreadSafeAction<string> OnCreateRubble { get; }

  public ThreadSafeAction OnOpenedDiscordServer { get; }

  public ThreadSafeAction<WorldObject> WorldObjectUIOpened { get; }

  /// <summary> Information of the last tab selected by the user </summary>
  public string CurrentTab { get; set; }

  public ViewEditor CurrentViewEditor { get; set; }

  public void Init(User user);

  internal void UIOpened(string uiName);

  internal void UIClosed(string uiName);

  /// <summary>When the player logout, we close any open ViewEditor and unsubscribe.</summary>
  public void Logout();

  public void UnsubscribeAll();

  public void SubscribeTutorial(string title, ThreadSafeAction onChanged, Func<bool> func);

  public void SubscribeTutorial<T>(string title, ThreadSafeAction<T> onChanged, Func<T, bool> func);

  public void SubscribeTutorial<T1, T2>(
    string title,
    ThreadSafeAction<T1, T2> onChanged,
    Func<T1, T2, bool> func);

  public void SubscribeTutorial<T1, T2>(ThreadSafeAction<T1, T2> onChanged, Func<T1, T2, bool> func);

  public void SubscribeTutorial<T1>(ThreadSafeAction<T1> onChanged, Func<T1, bool> func);

  public void SubscribeTutorial(ThreadSafeAction onChanged, Func<bool> func);
}
