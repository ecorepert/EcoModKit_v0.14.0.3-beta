// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.Reputation.Internal.Reputation
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Players;
using Eco.Gameplay.Systems.NewTooltip;
using Eco.Gameplay.Systems.TextLinks;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.Utils;
using Eco.Shared.View;
using System;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Economy.Reputation.Internal;

/// <summary>Stores and manipulates reputation for anything deriving IHasReputation (citizens, artwork)</summary>
[Serialized]
public class Reputation : 
  ILinkable,
  IHasSerializableID,
  IHasUniversalID,
  INotifyPropertyChanged,
  IController,
  IViewController
{
  [Notify]
  public ThreadSafeAction ReputationChangedEvent { get; }

  [Serialized]
  public ThreadSafeDictionary<IGivesReputation, UserReputationRating> Relationships { get; set; }

  [Serialized]
  public IHasReputation RepReceiver { get; set; }

  [Notify]
  public float CachedTotalReputation { get; set; }

  [Notify]
  public float CachedPositiveReputation { get; set; }

  public Color Color { get; set; }

  public string Title { get; set; }

  public LocString ColoredTitle { get; }

  /// <summary>Caluclate a weighted sum, with a passed in mult function. Only counts positive reputation.</summary>
  public float WeightedPositiveSum(Func<IGivesReputation, float, float> weight);

  public UserReputationRating GetOrAddRelationship(IGivesReputation source);

  public float GetRepFromSource(IGivesReputation source);

  public (float ChangeRep, bool ChangeNote) AdjustRelationship(
    IGivesReputation rep,
    float givable,
    string note,
    bool ignoreLimit);

  [Eco.Shared.Serialization.OnPostLoad]
  public void OnPostLoad();

  public void OnCreate(IReputationAssociated target);

  public void OnLinkClicked(TooltipOrigin origin, TooltipClickContext clickContext, User user);

  LocString ILinkable.UILinkContent();

  public ref int ControllerID { get; }

  public event PropertyChangedEventHandler PropertyChanged;
}
