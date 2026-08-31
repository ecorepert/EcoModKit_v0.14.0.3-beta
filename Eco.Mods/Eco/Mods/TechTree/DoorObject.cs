// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.DoorObject
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Gameplay.Components;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Wires;
using Eco.Shared.Networking;
using Eco.Shared.Serialization;
using System.Collections.Generic;

#nullable disable
namespace Eco.Mods.TechTree;

[Serialized]
[RequireComponent(typeof (DoorComponent), null)]
[MustBeGridAligned]
public abstract class DoorObject : WorldObject, IWireContainer
{
  IEnumerable<WireConnection> IWireContainer.Wires { get; }

  protected override void Initialize();

  protected override void PostInitialize();

  public override void SendInitialState(BSONObject bsonObj, INetObjectViewer viewer);
}
