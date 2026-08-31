// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.Jobs.RecurringTransferDefinition
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Civics.GameValues;
using Eco.Gameplay.Systems.Controllers;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.View;
using System;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Economy.Jobs;

[Eco.Shared.Networking.Eco(true)]
[LocDescription("Defines the how the cost is determined for a given individual.")]
public class RecurringTransferDefinition : 
  IController,
  IViewController,
  IHasUniversalID,
  ICustomValidity,
  IValidity,
  IReferrerDependentValidity,
  INotifyPropertyChanged,
  IDescribable
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("The currency the charge will be paid in.")]
  [AllowNullInView]
  public GameValue<Eco.Gameplay.Economy.Currency> Currency { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("How much will be transferred per hour.")]
  [AllowNullInView]
  public GameValue<float> AmountPerHour { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Which time counts for purposes of this transfer.")]
  public WageType PaymentType { get; set; }

  public LocString Description();

  public bool IsSet { get; }

  public Result Valid();

  public Result Valid(Type parentType, Type rootType);

  public event PropertyChangedEventHandler PropertyChanged;

  public ref int ControllerID { get; }
}
