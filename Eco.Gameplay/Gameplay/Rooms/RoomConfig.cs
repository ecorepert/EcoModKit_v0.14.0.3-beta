// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Rooms.RoomConfig
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Shared.Localization;
using System.ComponentModel;

#nullable disable
namespace Eco.Gameplay.Rooms;

[Localized(true, false, "", false)]
public class RoomConfig
{
  [LocDescription("If set, rooms can have empty blocks serve as windows and still count as a room.")]
  public bool EmptyBlocksCountAsWindows { get; set; }

  [LocDescription("Repeated rooms earn this multiple value of the previous ones. This makes duplicate rooms less valuable in a house.")]
  public float RoomCategoryDiminishingReturnRate { get; set; }

  [LocDescription("Specifies how much wall blocks required to make one empty window or door block without penalty. It counts all wall blocks in the room, including window blocks itself.")]
  public int WallBlocksPerWindow { get; set; }

  [Category("Rooms")]
  [Notify]
  [LocDescription("Multiplier of room per resident count. Could be used to incentive the shared residencies at certain number of residents. ")]
  public float[] HousePointsMultiplierPerResidentsCount { get; set; }

  [Category("Painted Blocks")]
  [LocDescription("An addition to the tier value of blocks that are painted.")]
  public float PaintedBlockTierBonus { get; set; }

  [Category("Painted Blocks")]
  [LocDescription("Housing value bonus contributed by painted blocks as a percentage bonus. E.g., 0.2 means means if 100% of walls are painted, the room value is increased by 20%.")]
  public float PaintedBlockHousingBonus { get; set; }

  [LocDescription("Rooms values are reduced by the average ground pollution percentage of their area")]
  public PollutionPenalty PollutionPenalty { get; set; }
}
