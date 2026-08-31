// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.PowerGridNetworkComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Utils;
using Eco.Gameplay.Objects;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using System;
using System.Collections.Generic;
using System.Collections.Immutable;

#nullable enable
namespace Eco.Gameplay.Components;

[Serialized]
[Priority(-2)]
[RequireComponent(typeof (PowerGridComponent), null)]
[RequireComponent(typeof (StatusComponent), null)]
[CreateComponentTabLoc("Power", false)]
[HasIcon("PowerComponent")]
public class PowerGridNetworkComponent : WorldObjectComponent
{
  public override WorldObjectComponentClientAvailability Availability { get; }

  [SyncToView(null, true)]
  public bool CanActivate { get; }

  [SyncToView(null, true)]
  public 
  #nullable disable
  string NetworkStatusString { get; }

  [SyncToView(null, true)]
  public string RequirementsString { get; }

  [SyncToView(null, true)]
  public override string IconName { get; }

  [Serialized]
  [SyncToView(null, true)]
  public bool CanControl { get; }

  public ImmutableArray<WorldObject> NetworkedObjects { get; }

  public Dictionary<Type, int> NetworkedItemTypes { get; }

  public override bool Enabled { get; }

  public void Initialize(Dictionary<Type, int> requiredItemTypes, bool canControl);

  public override void Initialize();

  public override void Destroy();

  public override void Tick();

  [RPC]
  public void Activate();

  public void Deactivate();
}
