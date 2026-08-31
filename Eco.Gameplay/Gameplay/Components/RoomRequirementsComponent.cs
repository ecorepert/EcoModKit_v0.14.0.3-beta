// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.RoomRequirementsComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Utils;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Property;
using Eco.Gameplay.Rooms;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;
using Eco.Shared.Serialization;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Components;

[Serialized]
[RequireComponent(typeof (StatusComponent), null)]
[ChatCommandHandler]
[NoIcon]
public class RoomRequirementsComponent : WorldObjectComponent, RoomUpdater.IRoomUpdates
{
  public Deed LastDeed;
  public ThreadSafeAction OnRoomCheck;

  public override WorldObjectComponentClientAvailability Availability { get; }

  public RoomStats LastRoomStats { get; set; }

  [SyncToView(null, true)]
  public IEnumerable<string> ContainedWorldObjects { get; }

  public override bool Enabled { get; }

  public double LastCheckTime { get; }

  public override void Tick();

  public void RoomUpdated(Room room);

  public override void Initialize();

  public override void Destroy();

  public void MarkDirty();

  public void SetIgnoreRoomReqs(bool set);
}
