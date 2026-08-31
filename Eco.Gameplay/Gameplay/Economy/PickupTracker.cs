// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.PickupTracker
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Shared.View;
using System.ComponentModel;
using System.Numerics;

#nullable disable
namespace Eco.Gameplay.Economy;

/// <summary>Economy-viewer row for a pickup bounty: a storage whose owner lets non-owners collect priced items.
/// Positive TotalPrice = the collector pays the owner; negative = the owner pays the collector.</summary>
public class PickupTracker : IController, IViewController, IHasUniversalID, INotifyPropertyChanged
{
  public event PropertyChangedEventHandler PropertyChanged;

  [SyncToView(null, true)]
  public string ObjectWithPickup { get; set; }

  [SyncToView(null, true)]
  public int ItemCount { get; set; }

  [SyncToView(null, true)]
  public float TotalPrice { get; set; }

  [SyncToView(null, true)]
  public Currency Currency { get; set; }

  [SyncToView(null, true)]
  public string Items { get; set; }

  [SyncToView(null, true)]
  public Vector3 Position { get; set; }

  public ref int ControllerID { get; }

  public ref ThreadSafeSubscriptions Subscriptions { get; }
}
