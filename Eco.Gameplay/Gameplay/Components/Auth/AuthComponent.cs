// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.Auth.AuthComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Core.Utils.PropertyScanning;
using Eco.Gameplay.Aliases;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Gameplay.Property;
using Eco.Shared.Localization;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Components.Auth;

[Serialized]
[Ecopedia(null, "Authorization Component", false, true, null)]
[CreateComponentTabLoc("Auth", true)]
[LocDescription("Set authorization status for people and Demographics.")]
[Priority(-100)]
public abstract class AuthComponent : WorldObjectComponent, IExternalReferencer, ICopyPasteComponent
{
  [Notify]
  public ThreadSafeAction<OwnerChangeType> OwnerChanged { get; }

  public override WorldObjectComponentClientAvailability Availability { get; }

  public ThreadSafeAction<AuthComponent> AuthChanged { get; }

  public bool IsPublicProperty { get; }

  [SyncToView(null, true)]
  public override string IconName { get; }

  [SyncToView(null, true)]
  public abstract Deed Deed { get; }

  [SyncToView(null, true)]
  public ControllerHashSet<IAlias> UsersWithFullAccess { get; }

  [SyncToView(null, true)]
  [Serialized]
  public AliasSelector UsersWithConsumerAccess { get; }

  [SyncToView(null, true)]
  protected string PropertyAuthUILink { get; }

  [SyncToView(null, true)]
  public bool IsAuthorizedConsumerAccess(Player player);

  [SyncToView(null, true)]
  public bool IsAuthorizedFullAccess(Player player);

  [SyncToView(null, true)]
  public override IAlias Owners { get; }

  public void SetPublic();

  [RPC]
  public void OpenDeed(Player player);

  public override void Initialize();

  public override void Destroy();

  protected virtual void OnAuthChanged();

  protected virtual void OnOwnerChanged(OwnerChangeType changeType);

  protected void NotifyNameChanged();

  public Type CopyPasteGroup { get; }

  public Result CopyFrom(WorldObjectComponent source, Player player);

  void IExternalReferencer.SwapRefs(Dictionary<IHasID, IHasID> refsToSwap);
}
