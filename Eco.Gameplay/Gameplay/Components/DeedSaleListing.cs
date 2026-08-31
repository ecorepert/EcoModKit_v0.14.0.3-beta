// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.DeedSaleListing
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Economy;
using Eco.Gameplay.Players;
using Eco.Gameplay.Property;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Components;

[Serialized]
public class DeedSaleListing : IController, IViewController, IHasUniversalID, INotifyPropertyChanged
{
  public event PropertyChangedEventHandler PropertyChanged;

  public ref int ControllerID { get; }

  [Serialized]
  [SyncToView(null, true)]
  public float Price { get; }

  [Serialized]
  [SyncToView(null, true)]
  public BankAccount Account { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  [AutoRPC]
  public Currency Currency { get; set; }

  [SyncToView(null, true)]
  public Deed Deed { get; }

  public User Lister { get; }

  public Result IsValid { get; }

  public DeedSaleListing(
    Deed deed,
    User lister,
    BankAccount account,
    Currency currency,
    float price);

  [RPC]
  public void SetPrice(Player seller, float price);

  [RPC]
  public void SetAccount(Player seller, BankAccount account);
}
