// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Property.RoomRequirements
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Gameplay.Rooms;
using Eco.Shared.Localization;
using System;

#nullable enable
namespace Eco.Gameplay.Property;

public class RoomRequirements
{
  public 
  #nullable disable
  RoomRequirementAttribute[] Requirements { get; }

  public LocString Description();

  public bool AreMet(Room room, User owner);

  public bool AreMet(Room room, User owner, WorldObject host);

  public LocString GetStatus(Room room, User user);

  public LocString GetStatus(Room room, User user, WorldObject host);

  public static float HighestRequiredTier { get; }

  public static RoomRequirements Get(Type worldObjectType);
}
