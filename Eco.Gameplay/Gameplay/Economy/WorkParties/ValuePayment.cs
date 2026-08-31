// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.WorkParties.ValuePayment
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Economy.WorkParties;

public abstract class ValuePayment : Payment
{
  [Serialized]
  public float AmountPaid;

  [Eco.Shared.Networking.Eco(true)]
  public PayType PayType { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  public float Amount { get; set; }

  [LocDescription("Should the amount be paid out as you do work? Or all at once at the end?")]
  [Eco.Shared.Networking.Eco(true)]
  public bool PayAsYouGo { get; set; }

  public override string WorkPerformed(Laborer laborer, float percentPerformed);

  public override string WorkFinished();

  protected abstract string PayUsers(IEnumerable<Laborer> laborers, float amount);

  protected abstract string PayUser(Laborer laborer, float amount);

  protected string PayDesc();
}
