// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Tutorial.UserSubTask
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.View;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Tutorial;

public class UserSubTask : IController, IViewController, IHasUniversalID, INotifyPropertyChanged
{
  protected User user;
  public ThreadSafeAction<UserSubTask> OnComplete;
  public ThreadSafeAction<UserSubTask> OnReset;

  public string Name { get; set; }

  public bool CompletesPrevious { get; set; }

  public string GiveItem { get; set; }

  public bool WaitForPrevious { get; set; }

  public bool Resettable { get; set; }

  [SyncToView(null, true)]
  public LocString Text { get; set; }

  [SyncToView(null, true)]
  public bool Complete { get; set; }

  [SyncToView(null, true)]
  public bool CheckBox { get; set; }

  [SyncToView(null, true)]
  public string PointToUIElement { get; set; }

  [SyncToView(null, true)]
  public HorzDir ArrowDirection { get; set; }

  [SyncToView(null, true)]
  public bool DiscordLink { get; set; }

  [SyncToView(null, true)]
  public bool HideRestUntilPrevDone { get; set; }

  public void Init(User user);

  public void DeInit();

  protected virtual void OnInit();

  protected virtual void OnDeInit();

  public virtual void SetSelected(bool set);

  public virtual void Added();

  public virtual void Reset(bool forceReset = false);

  public void CompleteTask();

  public event PropertyChangedEventHandler PropertyChanged;

  public ref int ControllerID { get; }
}
