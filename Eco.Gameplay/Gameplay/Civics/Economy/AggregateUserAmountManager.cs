// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Economy.AggregateUserAmountManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using Eco.Gameplay.Players;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;

#nullable enable
namespace Eco.Gameplay.Civics.Economy;

/// <summary> Aggregates given amounts and gets ticked using <see cref="T:Eco.Gameplay.Civics.CivicsPlugin" /> through <see cref="M:Eco.Gameplay.Civics.Economy.IHasUserAggregatedAmount.OnUserAggregateAmountDue(Eco.Gameplay.Players.User,System.Single)" /> </summary>
/// <inheritdoc cref="T:Eco.Shared.Utils.Singleton`1" />
/// <example> Used for <see cref="T:Eco.Gameplay.Economy.WorkParties.WorkParty" /> Pay as you go feature where fraction payments that can get aggregated over <see cref="F:Eco.Gameplay.Civics.Economy.AggregatedAmount.Delay" /> time. </example>
/// <remarks> This is meant to process transfers in bulk instead of using <see cref="T:Eco.Gameplay.Systems.Messaging.Notifications.AggregatedNotifications" /> to avoid extra processing that isn't meant to be done for notifications.</remarks>
[Serialized]
public class AggregateUserAmountManager : Singleton<AggregateUserAmountManager>
{
  public ThreadSafeAction OnChanged { get; }

  public void Initialize();

  /// <summary>
  /// Adds a delayed amount by <see cref="F:Eco.Gameplay.Civics.Economy.AggregatedAmount.Delay" /> that should aggregate if there is a value with the same handles already delayed.
  /// </summary>
  /// <param name="aggregatedAmountHandler"> The aggregated amount Handler that should be resposible for handling the aggregated value. </param>
  /// <param name="user"> The target user that the amount should go to. </param>
  /// <param name="amountDelta"> The difference in aggregated amount that should applied for the given user, for example in WorkParites the payment is calculated with <see cref="T:Eco.Gameplay.Economy.WorkParties.Payment" />, in which the weight change (aggregated amount) is given and then payment is calculated and paid.</param>
  public void AddOrUpdateAggregatedAmount(
    IHasUserAggregatedAmount aggregatedAmountHandler,
    User user,
    float amountDelta);

  /// <summary> Forces the remaining aggregate amounts for the given amount handler. </summary>
  public void ForceAggregatingAmountsForHandler(IHasUserAggregatedAmount aggregatedAmountHandler);

  /// <summary> When ticked checks if there are aggregate amounts due and pays it. </summary>
  public void Tick();
}
