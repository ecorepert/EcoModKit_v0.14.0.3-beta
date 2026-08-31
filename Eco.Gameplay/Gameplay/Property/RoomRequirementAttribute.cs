// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Property.RoomRequirementAttribute
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Gameplay.Rooms;
using Eco.Shared.Localization;
using System;

#nullable disable
namespace Eco.Gameplay.Property;

public abstract class RoomRequirementAttribute : Attribute
{
  public Type WorldObjectType { get; set; }

  public abstract bool IsMet(Room room, User owner);

  public abstract LocString Describe();

  public abstract LocString Describe(Room room, User owner);

  /// <summary>Host-aware overload. Defaults to the host-less behaviour; <see cref="T:Eco.Gameplay.Property.RequireRoomMaterialTierAttribute" /> overrides it to fold in <see cref="T:Eco.Gameplay.Property.IDynamicRoomTier" /> bumps.</summary>
  public virtual bool IsMet(Room room, User owner, WorldObject host);

  public virtual LocString Describe(Room room, User owner, WorldObject host);
}
