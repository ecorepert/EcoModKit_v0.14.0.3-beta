// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.CivicsConfig
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Shared.Localization;
using Eco.Shared.View;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Civics;

[Localized(true, false, "", false)]
public class CivicsConfig : IController, IViewController, IHasUniversalID, INotifyPropertyChanged
{
  public event PropertyChangedEventHandler PropertyChanged;

  [LocDescription("Determines whether overthrowing a government is allowed or not. If set, then a constitution with higher house value than the current can be ratified.  Setting this to true also makes it impossible to make laws about placing/crafting a constitution.")]
  public bool AllowOverthrow { get; set; }

  [LocDescription("To overthrow an existing government, a constitution must be placed in a building that exceeds the previous constitution's value by this percent.  100 = 100%")]
  public float ValueAdditionToOverthrow { get; set; }

  [LocDescription("The 'Active Players' demographic will check this many of the past days to determine the hours played by a user.")]
  public float DayRangeForActiveDemographic { get; set; }

  [LocDescription("Percent of days a user needs to be considered active (as determined by other property) to be in the 'Long Term demographic'.  1 = 100%")]
  public float PercentOfDaysToBeActiveForLongTermDemographic { get; set; }

  [LocDescription("The 'Active Players' demographic will apply to any users who played this many hours within the past number of days specified above.")]
  public float HoursPlayedToBeActiveDemographic { get; set; }

  [LocDescription("The 'Abandoned Players' demographic will check this many past days for hours played by the user")]
  public float DayRangeForAbandonedDemographic { get; set; }

  [LocDescription("The 'Abandoned Players' demographic will apply to any users who have not played more than this many hours in within the past number of days specified above.")]
  public float HoursPlayedToBeAbandonedDemographic { get; set; }

  [LocDescription("The 'Abandoned Players' demographic will only apply to users who have a citizen age greater than this many hours.")]
  public float CitizenAgeForAbandonedDemographic { get; set; }

  [LocDescription("Demographics are updated after this much time has passed.")]
  public float MinutesBetweenCivicsUpdates { get; set; }

  [LocDescription("How much time can a civics object have an invalid/missing host object before it goes invalid?")]
  public float AllowInvalidCivicContainerTimeInMinutes { get; set; }

  [LocDescription("Recurring transfers like rent and wages are paid after this many minutes.")]
  public double RecurringTransferFrequencyInMinutes { get; set; }

  [LocDescription("Can laws prevent someone from logging in or playing?  Enable with caution: users can create a law that blocks everyone from logging in if this is enabled.")]
  public bool AllowLawsToPreventLoginOrPlay { get; set; }

  [LocDescription("Can laws prevent someone from giving reputation to another player?")]
  public bool AllowLawsToPreventReputationTransfer { get; set; }

  [LocDescription("Basic election process will be changed according to these values. This values will also be used as defaults for newly created election processes.")]
  public CivicsConfig.ElectionSettings BasicElectionSettings { get; set; }

  [LocDescription("Setting this to true will allow admins to have more control over some civics (I.E in settlement roster a new admin button will show up).")]
  [Notify]
  public bool EnableAdminUI { get; set; }

  [LocDescription("This will determine how long will it take for a deed to automatically shrink itself removing plots surplus, giving the players more/less time to react to it.")]
  public float HoursAfterDeedOverburdenedBeforeRemovingPlots { get; set; }

  public ref int ControllerID { get; }

  [Localized(true, false, "", false)]
  [TypeConverter(typeof (ExpandableObjectConverter))]
  public class ElectionSettings
  {
    [LocDescriptionClone(typeof (ElectionProcess), "MaximumElectionHours")]
    public float MaximumElectionHours { get; set; }

    [LocDescriptionClone(typeof (ElectionProcess), "MinimumPercentOfEligibleVotersRequired")]
    public float MinimumPercentOfEligibleVotersRequired { get; set; }

    [LocDescriptionClone(typeof (ElectionProcess), "MinimumDaysBetweenElectionsOfThisType")]
    public float MinimumDaysBetweenElectionsOfThisType { get; set; }

    [LocDescriptionClone(typeof (ElectionProcess), "EndElectionEarlyWhenThisPercentHaveVoted")]
    public float EndElectionEarlyWhenThisPercentHaveVoted { get; set; }

    [LocDescriptionClone(typeof (ElectionProcess), "PercentOfAllVotersToInstantWin")]
    public float PercentOfAllVotersToInstantWin { get; set; }

    [LocDescriptionClone(typeof (ElectionProcess), "PercentOfAllVotersToInstantLose")]
    public float PercentOfAllVotersToInstantLose { get; set; }

    [LocDescriptionClone(typeof (ElectionProcess), "AnonymousVoting")]
    public bool AnonymousVoting { get; set; }

    [LocDescriptionClone(typeof (ElectionProcess), "TwitchSubscriberVoteWeight")]
    public float TwitchSubscriberVoteWeight { get; set; }

    [LocDescriptionClone(typeof (ElectionProcess), "TwitchNonSubscriberVoteWeight")]
    public float TwitchNonSubscriberVoteWeight { get; set; }

    [LocDescriptionClone(typeof (ElectionProcess), "MaxPercentTwitchVotes")]
    public float MaxPercentTwitchVotes { get; set; }

    public override string ToString();
  }
}
