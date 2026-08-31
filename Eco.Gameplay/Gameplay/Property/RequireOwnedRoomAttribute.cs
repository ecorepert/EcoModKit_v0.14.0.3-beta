// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Property.RequireOwnedRoomAttribute
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Players;
using Eco.Gameplay.Rooms;
using Eco.Shared.Localization;

#nullable disable
namespace Eco.Gameplay.Property;

/// <summary>For objects that need to be on a fully owned room to function</summary>
public class RequireOwnedRoomAttribute : RoomRequirementAttribute
{
  public override bool IsMet(Room room, User owner);

  public override LocString Describe();

  public override LocString Describe(Room room, User owner);
}
