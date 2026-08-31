// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.ViewEditor
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Plugins.Interfaces;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Civics.Misc;
using Eco.Gameplay.Players;
using Eco.Shared.Networking;
using Eco.Shared.Utils;
using Eco.Shared.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable enable
namespace Eco.Gameplay.Systems;

public class ViewEditor : 
  IController,
  IViewController,
  IHasUniversalID,
  IThreadSafeSubscriptions,
  ISubscriptions<ThreadSafeSubscriptions>,
  ISubscriptions,
  INotifyPropertyChanged,
  IDisplayErrorUI,
  IProvidesContext
{
  public static void Edit(
    #nullable disable
    User user,
    IController toEdit,
    Action<IController> onSubmit = null,
    ISaveablePlugin savePlugin = null,
    string buttonText = null,
    Color? buttonColor = null,
    string overrideTitle = null,
    ViewEditor.WindowType windowType = ViewEditor.WindowType.Civics,
    bool readOnly = false,
    IProvidesContext overrideContext = null,
    Action<IController> onClose = null,
    Action<IController> onBack = null,
    bool showAdminEditableOnlyProperties = false);

  [SyncToView(null, true)]
  [Autogen]
  [AllowNullInView]
  [AutoRPC]
  [HideRoot]
  public IController ObjectToEdit { get; set; }

  [SyncToView(null, true)]
  public List<PropError> Errors { get; set; }

  [SyncToView(null, true)]
  public string OverrideTitle { get; set; }

  [SyncToView(null, true)]
  public string ButtonText { get; set; }

  [SyncToView(null, true)]
  public Color ButtonColor { get; set; }

  [SyncToView(null, true)]
  public bool HasBackButton { get; set; }

  [SyncToView(null, true)]
  public IEnumerable<IContextValue> ContextProvided { get; set; }

  [SyncToView(null, true)]
  public bool ShowAdminEditableProperties { get; set; }

  public ref ThreadSafeSubscriptions Subscriptions { get; }

  public ErrorDisplayData ErrorData { get; set; }

  public event PropertyChangedEventHandler PropertyChanged;

  public void OnPropertyChanged([ControllerPropertyName(null)] string propertyName, object before, object after);

  public void Init();

  ~ViewEditor();

  /// <summary>Tell the user to close an open editor.</summary>
  public static void CloseForUser(User user, ViewEditor.WindowType windowType);

  /// <summary>When the view get closed, we invoke the onClose event.</summary>
  [RPC]
  public void Close(Player player);

  public ref int ControllerID { get; }

  public enum WindowType
  {
    Civics,
    Small,
    ChatTab,
    ChatChannel,
    Simple,
  }
}
