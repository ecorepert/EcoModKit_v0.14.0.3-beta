// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.LegislationSystem.DistrictCommands
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Gameplay.Civics.Districts;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Gameplay.Settlements;
using Eco.Gameplay.Systems.Messaging.Chat.Commands;

#nullable disable
namespace Eco.Gameplay.LegislationSystem;

[ChatCommandHandler]
public static class DistrictCommands
{
  [ChatCommand("Shows commands related to user-defined districts.", ChatAuthorizationLevel.Admin)]
  public static void Districts();

  [ChatSubCommand("Districts", "Set the current area within a given radius to a given district (or a new district if none is passed).", ChatAuthorizationLevel.Admin)]
  public static void Add(User user, int radiusInPlots = 0, District district = null, DistrictMap map = null);

  [ChatSubCommand("Districts", "Remove all districts from a given map.", ChatAuthorizationLevel.Admin)]
  public static void ClearMap(User user, DistrictMap set);

  [ChatSubCommand("Districts", "Generate some random districts around the user.", ChatAuthorizationLevel.DevTier)]
  public static DistrictMap Spawn(
    User user,
    int numDistricts = 20,
    int size = 5,
    bool useExisting = false,
    DistrictMap districtMap = null,
    Settlement settlement = null);

  public static DistrictMap Spawn(
    User user,
    int numDistricts,
    int size,
    bool useExisting,
    DistrictMap districtMap,
    WorldObject office,
    Settlement settlement);
}
