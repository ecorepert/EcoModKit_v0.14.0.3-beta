// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.WorkParties.CurrencyPayment
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Utils;
using Eco.Shared.Localization;
using PropertyChanged;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Economy.WorkParties;

[Eco.Shared.Networking.Eco(true)]
[LocDescription("Payment made as a currency transfer.")]
public class CurrencyPayment : ValuePayment
{
  [Eco.Shared.Networking.Eco(true)]
  public Currency Currency { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  public BankAccount PayFromAccount { get; set; }

  [SyncToView(null, true)]
  [DependsOn("Currency")]
  public override string Description { get; }

  public override string ShortDescription();

  public override void OnActivated();

  public override string WorkFinished();

  public override Result Valid();

  protected override string PayUsers(IEnumerable<Laborer> laborers, float amount);

  protected override string PayUser(Laborer laborer, float amount);
}
