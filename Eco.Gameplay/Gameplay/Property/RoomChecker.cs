// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Property.RoomChecker
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Math;
using Eco.World.Blocks;

#nullable disable
namespace Eco.Gameplay.Property;

public static class RoomChecker
{
  public const int MaxDistance = 70;
  public static bool EmptyBlocksCountAsWindows;
  public static bool AllowEmptyEdges;
  public static int WallBlocksPerWindow;

  public static RoomStats GetRoomStats(WrappedWorldPosition3i queryPos, bool trackEmptySpace = true);

  public static bool TryGetWindowSides(
    WrappedWorldPosition3i pos,
    out WrappedWorldPosition3i side1,
    out WrappedWorldPosition3i side2);

  public static bool CountsAsWall(Block block);
}
