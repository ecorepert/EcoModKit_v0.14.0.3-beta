// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.ConstitutionComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Civics;
using Eco.Gameplay.Civics.Elections;
using Eco.Gameplay.Civics.Misc;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Gameplay.Rooms;
using Eco.Gameplay.Settlements;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Gameplay.Components;

[Serialized]
[CreateComponentTabLoc(null, false)]
[HasIcon(null)]
public class ConstitutionComponent : 
  TrackPlacementComponent,
  INotifyPropertyChanged,
  IPersistentData,
  IDisplayErrorUI,
  RoomUpdater.IRoomUpdates,
  IPickupConfirmationComponent
{
  public static 
  #nullable disable
  ThreadSafeAction<Election, Player> RatificationElectionDraftedEvent;

  [SyncToView(null, true)]
  public override LocString ComponentTabName { get; }

  [Eco.Shared.Networking.Eco(true)]
  [UITypeName("StringDisplay")]
  public string DisplayText { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public bool EnableRatifyButton { get; set; }

  [SyncToView(null, true)]
  public string CivicTitle { get; }

  [Eco.Shared.Networking.Eco(true)]
  [ShowFullObject]
  [HideRoot]
  public Constitution Constitution { get; set; }

  [Serialized]
  [SyncToView(null, true)]
  public SettlementType SettlementType { get; set; }

  [SyncToView(null, true)]
  public bool Founded { get; }

  protected override IEnumerable<IProposable> TrackedObjects { get; }

  protected override object Data { get; set; }

  [SyncToView(null, true)]
  public List<PropError> Errors { get; set; }

  public ErrorDisplayData ErrorData { get; set; }

  public override void Initialize();

  public override void PostInitialize();

  public override void Destroy();

  public LocString GetComponentPickupConfirmation();

  public override void OnPickup(Player player);

  public void RoomUpdated(Room room);

  protected override void CheckValidity(bool updateText);

  public void ForceUpdateConstitutionStatus();

  public Settlement ConstitutionSettlement { get; }

  public void UpdateConstitutionStatus(object o);

  public void UpdateConstitutionStatus(object c, object s);

  public void UpdateConstitutionStatus();

  public void UpdateConstitutionStatus(bool updateText);

  public Election RatificationElection { get; }

  [SyncToView(null, true)]
  public bool ShowRatifyButton();

  [RPC]
  [EnabledParam("EnableRatifyButton")]
  [VisibilityParam("ShowRatifyButton")]
  [LocDescription("When this object is fully enabled, and the Constitution is valid, an election can be started to ratify the constitution and found the settlement.")]
  public Task StartRatificationElection(Player player);

  public Task<Election> StartRatificationElection(User user, bool force);

  protected override void InitializePersistentData();

  public override void ForceAdd(IProposable entry);
}
