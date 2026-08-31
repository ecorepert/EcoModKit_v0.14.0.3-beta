// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Systems.ViewEditorUtils
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Civics.GameValues;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using Eco.Shared.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Systems;

public static class ViewEditorUtils
{
  /// <summary>Static function to retrieve a GameValue of type T from the player via a dialog box.</summary>
  public static void PopupUserEditValue(
    User user,
    Type type,
    LocString title,
    object existing,
    IProvidesContext contextProvider,
    Action<object> setVal);

  /// <summary>Static function to edit entry itself, without holder.
  /// Note: rename of simple entry within this editor will rename existing object (because this will cause Registrar.Rename)</summary>
  public static void PopupUserEditValueNoHolder(
    User user,
    Type type,
    LocString? title,
    IController existing,
    Action<object> setVal,
    ViewEditor.WindowType windowType = ViewEditor.WindowType.Small,
    LocString? buttonName = null);

  private class BoolHolder : ViewEditorUtils.Holder
  {
    [Eco.Shared.Networking.Eco(true)]
    [HideDescription]
    [AllowNullInView]
    public GameValue<bool> Value { get; set; }

    public override object ObjValue { get; }
  }

  private class NumberHolder : ViewEditorUtils.Holder
  {
    [Eco.Shared.Networking.Eco(true)]
    [HideDescription]
    [AllowNullInView]
    public GameValue<float> Value { get; set; }

    public override object ObjValue { get; }
  }

  private class GeneralHolder : ViewEditorUtils.Holder
  {
    [Eco.Shared.Networking.Eco(true)]
    [HideDescription]
    [HasTypeLimiter]
    public IController Value { get; set; }

    [SyncToView(null, true)]
    public Type ValueTypeLimiter { get; set; }

    public override object ObjValue { get; }

    public GeneralHolder(Type t, object val);
  }

  private abstract class Holder : 
    IController,
    IViewController,
    IHasUniversalID,
    INotifyPropertyChanged,
    IProvidesContext
  {
    public static ViewEditorUtils.Holder MakeHolder(Type t, object val);

    [SyncToView(null, true)]
    public IEnumerable<IContextValue> ContextProvided { get; set; }

    public abstract object ObjValue { get; }

    public event PropertyChangedEventHandler PropertyChanged;

    ref int IHasUniversalID.ControllerID { get; }
  }
}
