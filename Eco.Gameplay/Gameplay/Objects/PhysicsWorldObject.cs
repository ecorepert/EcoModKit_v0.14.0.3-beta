// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Objects.PhysicsWorldObject
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Items;
using Eco.Shared.Networking;
using Eco.Shared.Networking.Internal;
using Eco.Shared.Serialization;
using System;

#nullable disable
namespace Eco.Gameplay.Objects;

[Serialized]
[Tag("PlaceableOnUnownedLand")]
public abstract class PhysicsWorldObject : WorldObject, INetObjectDebugDescriber
{
  protected override void CreateEntity();

  public void SetPhysicsController(INetObjectViewer owner, Func<bool> canTeleportCheck = null);

  /// <summary>When a client last pushed a simulated pose for this object. Stale means no client is simulating it.</summary>
  public double LastSimulatedTime { get; }

  /// <summary>Counts the stored pose as freshly updated so it flows to every viewer. For server side pose corrections.</summary>
  public void MarkPoseUpdated();

  string INetObjectDebugDescriber.DebugDescribe();
}
