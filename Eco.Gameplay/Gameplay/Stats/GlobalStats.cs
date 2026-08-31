// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Stats.GlobalStats
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Shared.View;
using Eco.Stats;

#nullable enable
namespace Eco.Gameplay.Stats;

[HasStatProps]
public class GlobalStats : IController, IViewController, IHasUniversalID
{
  public int PeakActiveCitizenPopulation;

  [StatProp("Citizens", Unit.Citizens, StatType.ContinuousValue)]
  public float CitizenPopulation { get; set; }

  [StatProp("Citizens", Unit.Citizens, StatType.ContinuousValue)]
  [Score(100f)]
  public float ActiveCitizenPopulation { get; set; }

  [StatProp("Citizens", Unit.SkillPoints, StatType.ContinuousValue)]
  [Score(1f)]
  public float MedianHouseValueOfActiveCitizens { get; set; }

  [StatProp("Citizens", Unit.SkillPoints, StatType.ContinuousValue)]
  [Score(1f)]
  public float MedianNutritionValueOfActiveCitizens { get; set; }

  [StatProp("Citizens", Unit.SkillPoints, StatType.ContinuousValue)]
  public float MedianSkillRateOfActiveCitizens { get; set; }

  [StatProp("Citizens", Unit.Citizens, StatType.ContinuousValue)]
  public float MedianUnlockedSkillsOfActiveCitizens { get; set; }

  [StatProp("Citizens", Unit.Percent, StatType.ContinuousValue)]
  [Score(100f)]
  public float MedianSpecialtyPercentOfActiveCitizens { get; set; }

  [StatProp("Environment/Ecosystem", Unit.Organisms, StatType.ContinuousValue)]
  public float AnimalPopulation { get; set; }

  [StatProp("Environment/Ecosystem", Unit.Organisms, StatType.ContinuousValue)]
  public float TreePopulation { get; set; }

  [StatProp("Environment/Ecosystem", Unit.Organisms, StatType.ContinuousValue)]
  public float PlantPopulation { get; set; }

  [StatProp("Environment/Ecosystem", Unit.Count, StatType.ContinuousValue)]
  public float ExtinctSpecies { get; set; }

  [StatProp("Civics", Unit.Count, StatType.ContinuousValue)]
  [Score(1f)]
  public float Laws { get; set; }

  [StatProp("Civics", Unit.Count, StatType.ContinuousValue)]
  [Score(1f)]
  public float ElectedTitles { get; set; }

  [StatProp("Civics", Unit.Count, StatType.ContinuousValue)]
  [Score(1f)]
  public float ActiveCivicElements { get; set; }

  [StatProp("Civics", Unit.Count, StatType.ContinuousValue)]
  [Score(10f)]
  public float ActiveElectedOfficials { get; set; }

  [StatProp("Economy/Currency", Unit.CurrencyAmount, StatType.ContinuousValue)]
  public float PersonalWealthInDefaultCurrency { get; set; }

  [StatProp("Economy/Currency", Unit.CurrencyAmount, StatType.ContinuousValue)]
  public float GovernmentHoldingsInDefaultCurrency { get; set; }

  [StatProp("Economy/Currency", Unit.CurrencyAmount, StatType.ContinuousValue)]
  [Score(5f)]
  public float TradesInLast7Days { get; set; }

  [StatProp("Economy/Currency", Unit.Count, StatType.ContinuousValue)]
  [Score(10f)]
  public float ActiveCurrencies { get; set; }

  [StatProp("Economy/Currency", Unit.Count, StatType.ContinuousValue)]
  [Score(0.1f)]
  public float TaxedTransactions { get; set; }

  [StatProp("Economy/Currency", Unit.CurrencyAmount, StatType.ContinuousValue)]
  public float GDP { get; set; }

  [StatProp("Economy/Currency", Unit.CurrencyAmount, StatType.ContinuousValue)]
  public float Debt { get; set; }

  [StatProp("Economy/Currency", Unit.CurrencyAmount, StatType.ContinuousValue)]
  public float DebtPerActiveCitizen { get; set; }

  [StatProp("Economy/Trades", Unit.Count, StatType.ContinuousValue)]
  [Score(20f)]
  public float ItemTypesForSale { get; set; }

  [StatProp("Economy/Trades", Unit.Count, StatType.ContinuousValue)]
  [Score(1f)]
  public float ItemsForSale { get; set; }

  [StatProp("Economy/Trades", Unit.Count, StatType.ContinuousValue)]
  [Score(20f)]
  public float ActiveStores { get; set; }

  [StatProp("Economy/Trades", Unit.Count, StatType.ContinuousValue)]
  [Score(100f)]
  public float ActiveContractsAndWorkParties { get; set; }

  [StatProp("Economy/Trades", Unit.Count, StatType.ContinuousValue)]
  [Score(50f)]
  public float CompletedContractsAndWorkPartiesLast7Days { get; set; }

  public ref int ControllerID { get; }
}
