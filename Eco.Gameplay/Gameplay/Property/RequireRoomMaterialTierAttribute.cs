// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Property.RequireRoomMaterialTierAttribute
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

public class RequireRoomMaterialTierAttribute : RoomRequirementAttribute
{
  public float Tier;

  public RequireRoomMaterialTierAttribute(float tier, params Type[] talentTypes);

  public override bool IsMet(Room room, User owner);

  public override bool IsMet(Room room, User owner, WorldObject host);

  public override LocString Describe();

  public override LocString Describe(Room room, User owner);

  public override LocString Describe(Room room, User owner, WorldObject host);

  /// <summary>Base tier (talent-modified if owner is set) plus the sum of every <see cref="T:Eco.Gameplay.Property.IDynamicRoomTier" /> bump on <paramref name="host" />,
  /// capped at the highest block tier in game so bumps can't demand a room no material can build.</summary>
  public float EffectiveTier(User owner, WorldObject host);

  /// <summary>Clamps a tier requirement to the highest block tier that exists in game. MaxTier is 0 until block attributes register (unit tests), so no cap applies then.</summary>
  public static float CapAtMaxBlockTier(float tier);
}
