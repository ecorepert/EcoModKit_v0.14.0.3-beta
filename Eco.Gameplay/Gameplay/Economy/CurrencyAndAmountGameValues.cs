// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.CurrencyAndAmountGameValues
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Civics.GameValues;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.Controllers;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using System;
using System.ComponentModel;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Gameplay.Economy;

[Eco.Shared.Networking.Eco(true)]
public class CurrencyAndAmountGameValues : 
  IController,
  IViewController,
  IHasUniversalID,
  INotifyPropertyChanged,
  IDescribable
{
  [Eco.Shared.Networking.Eco(true)]
  public 
  #nullable disable
  GameValue<Eco.Gameplay.Economy.Currency> Currency { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  public GameValue<float> Amount { get; set; }

  [SyncToView(null, true)]
  public LocString Description();

  /// <summary> Try to pay the fee in the given currency, querying for the bank account source. Handles all errors and notifications.</summary>
  /// <param name="propName">Name of the property as you want it displayed in the notifications, ie 'tuition fee'. It will be localized.</param>
  /// <param name="user">The user making the payment.</param>
  /// <param name="context">Context with which we query these params.</param>
  /// <param name="targetAccount">Account that its paid into.</param>
  /// <param name="type">The kind of transfer it classifies as.</param>
  /// <returns></returns>
  public Task<(bool Success, GameActionPack Pack, float Fee, Eco.Gameplay.Economy.Currency Currency)> DoTransferLoc(
    FormattableString propName,
    User user,
    IContextObject context,
    BankAccount targetAccount,
    TransferType type);

  public event PropertyChangedEventHandler PropertyChanged;

  public ref int ControllerID { get; }

  [Serialized]
  public struct CurrencyAndAmount
  {
    [Serialized]
    public Eco.Gameplay.Economy.Currency Currency;
    [Serialized]
    public float Amount;
  }
}
