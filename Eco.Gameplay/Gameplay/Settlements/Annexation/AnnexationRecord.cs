// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Settlements.Annexation.AnnexationRecord
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.PropertyHandling;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Gameplay.Players;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.View;
using PropertyChanged;
using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable enable
namespace Eco.Gameplay.Settlements.Annexation;

/// <summary>Stores a record of every settlement that can annex another, or its progress towards that.</summary>
public class AnnexationRecord : 
  IController,
  IViewController,
  IHasUniversalID,
  INotifyPropertyChanged,
  IThreadSafeSubscriptions,
  ISubscriptions<ThreadSafeSubscriptions>,
  ISubscriptions
{
  public float CultureNotificationThreshold;

  [SyncToView(null, true)]
  public LocString Title { get; set; }

  [SyncToView(null, true)]
  public 
  #nullable disable
  Settlement Source { get; set; }

  [SyncToView(null, true)]
  public IAnnexable Target { get; set; }

  [SyncToView(null, true)]
  public bool CanAnnex { get; set; }

  [SyncToView(null, true)]
  public float CultureRequirementProgress { get; set; }

  [SyncToView(null, true)]
  public LocString ActiveCitizenRequirementProgress { get; set; }

  [SyncToView(null, true)]
  public float SurroundProgress { get; set; }

  [SyncToView(null, true)]
  public float MinPercentSurrounded { get; set; }

  [SyncToView(null, true)]
  public LocString CultureWeightDescription { get; set; }

  [SyncToView(null, true)]
  public bool HasEnoughCitizens { get; set; }

  [SyncToView(null, true)]
  public List<ResourceRequirementProgress> ResourceProgress { get; set; }

  [SyncToView(null, true)]
  public List<ResourceRequirementProgress> ClaimsProgress { get; set; }

  [Notify]
  public Lazy<LocString> PlotsTooltipMaker { get; set; }

  [Notify]
  public Lazy<LocString> CultureTooltipMaker { get; set; }

  [RPC]
  [VisibilityParam("ShowAnnexButton")]
  public void PerformAnnexation(User user);

  [SyncToView(null, true)]
  [DependsOnMember("CanAnnex")]
  public bool ShowAnnexButton(User user);

  public ref ThreadSafeSubscriptions Subscriptions { get; }

  public AnnexationRecord Clone();

  [DoNotNotify]
  public ref int ControllerID { get; }

  public event PropertyChangedEventHandler PropertyChanged;
}
