// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.WorkParties.ThresholdPayment
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Shared.Localization;
using System.Text;

#nullable disable
namespace Eco.Gameplay.Economy.WorkParties;

public abstract class ThresholdPayment : Payment
{
  [Eco.Shared.Networking.Eco(true)]
  [LocDescription("Any laborer who contributes at least this percent of the work will receive the reward.")]
  public float MinContributedPercent { get; set; }

  protected string ThresholdDesc { get; }

  public abstract string RewardDesc { get; }

  protected abstract void GainReward(Laborer laborer, StringBuilder sb);

  public override string WorkPerformed(Laborer laborer, float percentPerformed);

  public override Result Valid();

  public override void OnActivated();
}
