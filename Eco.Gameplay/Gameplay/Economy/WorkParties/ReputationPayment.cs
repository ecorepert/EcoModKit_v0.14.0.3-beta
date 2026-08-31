// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.WorkParties.ReputationPayment
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Utils;
using Eco.Shared.Localization;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Economy.WorkParties;

[Eco.Shared.Networking.Eco(true)]
[LocDescription("Payment made with reputation from the work party creator.")]
public class ReputationPayment : ValuePayment
{
  [SyncToView(null, true)]
  public override string Description { get; }

  public override string ShortDescription();

  public override string WorkFinished();

  protected override string PayUsers(IEnumerable<Laborer> laborers, float amount);

  protected override string PayUser(Laborer laborer, float amount);

  public override void OnActivated();

  public override Result Valid();
}
