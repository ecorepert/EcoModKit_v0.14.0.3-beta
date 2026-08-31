// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Tutorial.TutorialStatus
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Shared.Items;
using Eco.Shared.View;
using System.Collections.Generic;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Tutorial;

/// <summary> Watching system for the tutorial. The flags indicate the client what RPCs are needed </summary>
public class TutorialStatus : IController, IViewController, IHasUniversalID, INotifyPropertyChanged
{
  public Dictionary<TutorialWatch, int> RefCountOnFlags;

  public ref int ControllerID { get; }

  public event PropertyChangedEventHandler PropertyChanged;

  [SyncToView(null, true)]
  public int Flags { get; }

  [SyncToView(null, true)]
  public ControllerHashSet<string> WatchUIs { get; set; }

  public void Clear();

  /// <summary> Adds <paramref name="flag" /> to the current flags and update the client information </summary>
  /// <param name="flag">Flag to include</param>
  public void Add(TutorialWatch flag);

  /// <summary> Removes <paramref name="flag" /> from the current flags and update the client information </summary>
  /// <param name="flag">Flag to remove</param>
  public void Remove(TutorialWatch flag);
}
