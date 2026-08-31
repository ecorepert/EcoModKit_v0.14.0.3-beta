// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.WorkParties.GrantTitlePayment
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Utils;
using Eco.Gameplay.Civics.Titles;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using System.Text;

#nullable disable
namespace Eco.Gameplay.Economy.WorkParties;

[Eco.Shared.Networking.Eco(true)]
[LocDescription("Grants a title as payment.")]
public class GrantTitlePayment : ThresholdPayment
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Which titles to grant.")]
  public AppointedTitle Title { get; set; }

  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Type of access to grant.")]
  public AccountAccess AccessType { get; set; }

  [SyncToView(null, true)]
  public override string Description { get; }

  public override string ShortDescription();

  public override string RewardDesc { get; }

  protected string DescribedType { get; }

  protected override void GainReward(Laborer laborer, StringBuilder sb);

  public override Result Valid();

  public override void OnActivated();
}
