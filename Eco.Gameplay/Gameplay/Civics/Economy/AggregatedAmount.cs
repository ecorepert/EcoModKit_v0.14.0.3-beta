// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Economy.AggregatedAmount
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Players;
using Eco.Shared.Serialization;

#nullable enable
namespace Eco.Gameplay.Civics.Economy;

/// <summary> Holds data for aggregated amount, this is ticked by <see cref="T:Eco.Gameplay.Civics.Economy.AggregateUserAmountManager" /> through <see cref="T:Eco.Gameplay.Civics.CivicsPlugin" />, delay is calculated internally using <see cref="F:Eco.Gameplay.Civics.Economy.AggregatedAmount.Delay" /> </summary>
[Serialized]
internal class AggregatedAmount
{
  public const float Delay = 15f;

  [Serialized]
  public float Amount { get; set; }

  [Serialized]
  public double TimeToSend { get; set; }

  [Serialized]
  public IHasUserAggregatedAmount? AggregatedAmountHandler { get; set; }

  [Serialized]
  public User? User { get; set; }

  public AggregatedAmount();

  public AggregatedAmount(float initAmount, IHasUserAggregatedAmount handler, User user);
}
