// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Civics.Misc.IProposable
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Civics.Elections;
using Eco.Gameplay.Placement;
using Eco.Gameplay.Players;
using Eco.Gameplay.Settlements;
using Eco.Gameplay.Systems.TextLinks;
using Eco.Gameplay.Utils;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.Shared.View;
using System.Collections.Generic;
using System.ComponentModel;

#nullable enable
namespace Eco.Gameplay.Civics.Misc;

[ForceCreateView]
[Serialized]
[LocDisplayName("Civic Object")]
public interface IProposable : 
  IHasID,
  IController,
  IViewController,
  IHasUniversalID,
  INamed,
  IReInitializable,
  IHasReferenceableSerializableID,
  IHasSerializableID,
  IHostedObject,
  ILinkable,
  IHasTeleportOption,
  ILinkableParameterized<bool>,
  ICustomValidity,
  IValidity,
  ISuffixName,
  ISingleEditingUser,
  IPlayerUseTracking,
  INotifyPropertyChanged,
  IThreadSafeSubscriptions,
  ISubscriptions<ThreadSafeSubscriptions>,
  ISubscriptions,
  ISettlementAssociated
{
  [ClientInterfaceProperty]
  ProposableState State { get; set; }

  void ApplyUpdatedProposable(
  #nullable disable
  IProposable old);

  [ClientInterfaceProperty]
  IProposable TargetToReplace { get; set; }

  void OnBeforeStateChangeInternal(
    ProposableState newState,
    CivicsUtils.StateChangeDetailFlags flags);

  void OnStateChangedInternal(ProposableState oldState, CivicsUtils.StateChangeDetailFlags flags);

  bool DescribedWithTable { get; }

  void InitializeDraftProposable();

  bool Initialized { get; }

  IProposable RevisionParent { get; set; }

  Dictionary<IHasID, IHasID> GetPairsOfOldAndNewRevisions(IProposable old);

  Election Election { get; set; }

  User RemovedBy { get; set; }

  Election RemovalElection { get; set; }

  bool RequiresCivicActionToActivate { get; }
}
