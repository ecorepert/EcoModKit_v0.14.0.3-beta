// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Economy.Common.Workable
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Gameplay.Civics.Misc;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using PropertyChanged;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Economy.Common;

[ForceCreateView]
[Serialized]
[RPCAuthMaxProposableState(ProposableState.Proposed)]
public abstract class Workable : SimpleProposable
{
  [SuppressPropertyChangedWarnings]
  public abstract ContainedWorkables HostContainer { get; set; }

  public abstract User Owner { get; }

  public abstract string UIName { get; }

  public abstract bool ShowLocationTooltip { get; }

  public abstract IEnumerable<User> RelevantUsers();

  [RPC]
  public virtual void Open(Player player);

  public override void OnStateChangedInternal(
    ProposableState oldState,
    CivicsUtils.StateChangeDetailFlags flags);

  /// <summary>This will take care of updating the host object of the workable while at the same time assigning its parent settlement.</summary>
  public void SetHostObject(WorldObject worldObject);

  public virtual void SetupDefault(User user);

  public override LocString CreatorText(Player reader);

  public LocString LocationText(Player reader);
}
