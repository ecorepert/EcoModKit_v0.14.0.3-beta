// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Players.AvatarTool
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;
using Eco.Shared.View;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Players;

/// <summary> Controller for avatar tool states. Helps to sync current tool across players and local views. </summary>
[Serialized]
public class AvatarTool : IController, IViewController, IHasUniversalID, INotifyPropertyChanged
{
  public ref int ControllerID { get; }

  public event PropertyChangedEventHandler PropertyChanged;

  [SyncToView(null, true)]
  [AutoRPC]
  public int Working { get; }

  [SyncToView(null, true)]
  [AutoRPC]
  public bool HasContents { get; }

  [SyncToView(null, true)]
  [AutoRPC]
  public bool HasAmmo { get; }

  [SyncToView(null, true)]
  [AutoRPC]
  public bool HeadlightEnabled { get; }

  [SyncToView(null, true)]
  [AutoRPC]
  public int InputX { get; }

  [SyncToView(null, true)]
  [AutoRPC]
  public int InputY { get; }

  [SyncToView(null, true)]
  [AutoRPC]
  public bool IsSwimming { get; }

  [Serialized]
  [SyncToView(null, true)]
  [AutoRPC]
  public ByteColor SelectedColor { get; set; }

  public bool IsWorking { get; }
}
