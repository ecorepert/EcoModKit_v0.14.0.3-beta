// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Economy.IHasUserAggregatedAmount
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Systems;
using Eco.Gameplay.Players;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Civics.Economy;

/// <summary> Interface meant for handling aggregated amounts using <see cref="T:Eco.Gameplay.Civics.Economy.AggregateUserAmountManager" /> </summary>
/// <example> Check <see cref="T:Eco.Gameplay.Economy.WorkParties.WorkParty" /> for an example implementation. </example>
[Serialized]
public interface IHasUserAggregatedAmount : IHasUniversalID
{
  /// <summary> Process the final aggregated amount for the given user. </summary>
  /// <param name="user">The targeted user reference.</param>
  /// <param name="amount">The final amount to be applied after aggregating for <see cref="F:Eco.Gameplay.Civics.Economy.AggregatedAmount.Delay" /> seconds</param>
  void OnUserAggregateAmountDue(User user, float amount);
}
