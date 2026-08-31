// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.Reputation.Internal.ReputationConfig
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Shared.Localization;
using Eco.Shared.Utils;

#nullable disable
namespace Eco.Gameplay.Economy.Reputation.Internal;

[Localized(true, false, "", false)]
public class ReputationConfig : Singleton<ReputationConfig>
{
  [LocDescription("The titles players are given for each reputation level.")]
  public SerializedSynchronizedCollection<ReputationTitle> Reputations { get; set; }

  [LocDescription("Max reputation that can be given to another player or artwork by one person.")]
  public float MaxRepFromOnePerson { get; set; }

  [LocDescription("Minimum reputation that can be taken from another player by one person.")]
  public float MinRepFromOnePerson { get; set; }

  [LocDescription("Max size a review can be")]
  public int ReviewSizeLimit { get; set; }

  [LocDescription("Max amount of reputation, either positive or negative, that can be given in a 24 hour period.")]
  public float MaxGivableRepPerDay { get; set; }

  [LocDescription("Max amount of reputation, either positive or negative, that can be given to a single target in a 24 hour period.")]
  public float MaxGivableRepPerDayPerTarget { get; set; }

  [LocDescription("If a citizen gives this much or more positive reputation within a single day, they will get bonus positive reputation themselves.")]
  public float AmountOfPositiveReputationToGiveInOrderToEarnReputationReward { get; set; }

  [LocDescription("If a citizen gives the certain amount of positive reputation in a day, they will be rewarded with this much positive reputation added to them.")]
  public float SpeakingWellOfOthersReward { get; set; }
}
