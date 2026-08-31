// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Objects.WorldObjectHandle
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Property;
using Eco.Shared.Serialization;
using System;

#nullable disable
namespace Eco.Gameplay.Objects;

[Serialized]
public struct WorldObjectHandle : IOwnableHandle
{
  public WorldObjectHandle(WorldObject obj);

  public WorldObjectHandle(Guid id);

  public static bool operator ==(WorldObjectHandle a, WorldObjectHandle b);

  public static bool operator !=(WorldObjectHandle a, WorldObjectHandle b);

  public Guid Id { get; }

  public bool IsSet { get; }

  public bool IsEmpty { get; }

  public WorldObject Object { get; }

  public bool TryGetObject(out WorldObject obj);

  public static implicit operator WorldObject(WorldObjectHandle handle);

  public static implicit operator WorldObjectHandle(WorldObject obj);

  public override bool Equals(object obj);

  public override string ToString();

  public override int GetHashCode();

  IDeedOwned IOwnableHandle.OwnedObject { get; }
}
