// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.CatalystState
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using PropertyChanged;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Components;

/// <summary>Per-target catalyst state. Catalyst items are pulled from linked input inventories on demand.</summary>
[Serialized]
public class CatalystState : IController, IViewController, IHasUniversalID, INotifyPropertyChanged
{
  [Serialized]
  [SyncToView(null, true)]
  public int RemainingEnergyMils { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public int PeakEnergyMils { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public bool Enabled { get; set; }

  [SyncToView(null, true)]
  public bool Blocked { get; set; }

  [DoNotNotify]
  public ref int ControllerID { get; }

  public event PropertyChangedEventHandler PropertyChanged;
}
