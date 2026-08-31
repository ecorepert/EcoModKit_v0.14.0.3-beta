// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.ExchangeEntry
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Gameplay.Economy;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Components;

/// <summary>Represents an exchange between two currencies.</summary>
[Serialized]
public class ExchangeEntry : IController, IViewController, IHasUniversalID, INotifyPropertyChanged
{
  [Serialized]
  [SyncToView(null, true)]
  [AutoRPC]
  public Currency OwnerCurrency { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  [AutoRPC]
  public Currency CustomerCurrency { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  [AutoRPC]
  public float Price { get; set; }

  public event PropertyChangedEventHandler PropertyChanged;

  public string Description();

  public ref int ControllerID { get; }

  public enum ApplyLimit
  {
    Giver,
    Receiver,
  }
}
