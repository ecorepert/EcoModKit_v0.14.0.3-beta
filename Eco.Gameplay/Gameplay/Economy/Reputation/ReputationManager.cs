// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.Reputation.ReputationManager
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Plugins;
using Eco.Core.Serialization;
using Eco.Core.Utils;
using Eco.Gameplay.Players;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;
using System;

#nullable disable
namespace Eco.Gameplay.Economy.Reputation;

/// <summary>Primary interface for getting and setting rep on a class that implements IHasReputation</summary>
[Serialized]
public class ReputationManager : 
  Singleton<ReputationManager>,
  ISimplePluginData,
  IStorage,
  ISerializable
{
  public static readonly ThreadSafeAction<User> UserReputationChangedEvent;
  public double TimeLastChanged;

  /// <summary>Return the reputation title, and the total in parens.</summary>
  public LocString RepAndTotal(IHasReputation target);

  public void AddAsTableRow(IHasReputation target, LocStringBuilder sb);

  public (LocString Left, LocString Right) GetRepDisplay(IHasReputation target);

  public LocString GetRepMarkedupName(IHasReputation target);

  public LocString GetRepMarkedupName(IHasReputation target, LocString title);

  public LocString GetReputationWordWithMarkedupName(IHasReputation target);

  /// <summary>Caluclate a weighted sum, with a passed in mult function.</summary>
  public float CalculateWeightedPositiveRep(
    IHasReputation target,
    Func<IGivesReputation, float, float> weight);

  /// <summary>Return a string of the name colored by the reputation level.</summary>
  public Color RepColor(IHasReputation source);

  public float GetRep(IHasReputation target);

  public float GetPositiveReputation(IHasReputation target);

  public float ReputationGivenToday(IGivesReputation source);

  public float ReputationGivenToday(IGivesReputation source, IHasReputation target);

  public float ReputationGivenTotal(IGivesReputation source, IHasReputation target);

  public Eco.Gameplay.Economy.Reputation.Internal.Reputation GetReputation(IHasReputation target);

  /// <summary>Return the relative rep of a target to me, and only count rep of people I like, and who they like, etc.</summary>
  public float GetRelativeRep(IGivesReputation source, IHasReputation target);

  public void OpenGiveRepUI(Player player, IHasReputation target, Vector3i? actionLocation = null);

  /// <summary>Give reputation from a source to a target, attaching an optional note.</summary>
  public ValResult<float> GiveRep(
    IGivesReputation source,
    IHasReputation target,
    float desiredRepToGive,
    string note = null,
    bool ignoreLimit = false,
    ReputationSource reputationSource = ReputationSource.TransferredManually,
    bool sendNotice = true,
    Vector3i? actionLocation = null);

  /// <summary>Accepts a callback that will be invoked whenever the reputation of the passed thing changes.</summary>
  public void SubscribeReputationChanged(IHasReputation target, Action onChanged);

  /// <summary>Output a big string of all the reputation given in game.</summary>
  /// <returns></returns>
  public string GetDisplayText();

  public void Tick();

  /// <summary>Replenishes the givable reputation of a user.</summary>
  public void ForceReplenishReputation(User user);

  public void ReplenishAllReputation();

  public string GetStatus();

  public string GetCategory();

  public void MarkDirty();

  public IPersistent StorageHandle { get; set; }
}
