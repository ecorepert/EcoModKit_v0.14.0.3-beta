// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.PointOfInterest
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Players;
using Eco.Gameplay.Property;
using Eco.Shared.Math;
using Eco.Shared.View;
using PropertyChanged;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Economy;

public abstract class PointOfInterest : 
  IController,
  IViewController,
  IHasUniversalID,
  INotifyPropertyChanged
{
  public event PropertyChangedEventHandler PropertyChanged;

  [DoNotNotify]
  public ref int ControllerID { get; }

  [SyncToView(null, true)]
  public string Name { get; set; }

  [SyncToView(null, true)]
  public Vector3i Pos { get; set; }

  [SyncToView(null, true)]
  public Deed Deed { get; set; }

  [SyncToView(null, true)]
  public string ItemName { get; set; }

  public abstract bool IsAuthorized(User user);

  public abstract void Destroy();
}
