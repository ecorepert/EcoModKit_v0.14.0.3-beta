// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Items.ItemAnimationCategory
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

#nullable disable
namespace Eco.Shared.Items;

/// <summary> Maps item type to easy enum def with fixed number that can be used to know item generic type, or in animations on client (merged with old ToolItemName enum).
/// Do not change numbers even even you need to remove some types</summary>
public enum ItemAnimationCategory
{
  Unknown = -1, // 0xFFFFFFFF
  Hammer = 0,
  Axe = 1,
  Shovel = 2,
  Bow = 3,
  Devtool = 4,
  Pickaxe = 5,
  Scythe = 6,
  Hoe = 7,
  Chainsaw = 8,
  FishingPole = 9,
  Torch = 10, // 0x0000000A
  Machete = 11, // 0x0000000B
  Sickle = 12, // 0x0000000C
  ModernRockDrill = 13, // 0x0000000D
  Drill = 14, // 0x0000000E
  ClaimTool = 15, // 0x0000000F
  Food = 16, // 0x00000010
  RoadTool = 17, // 0x00000011
  HandheldCamera = 19, // 0x00000013
  ColorTool = 20, // 0x00000014
  Instant = 99, // 0x00000063
  WorkingSingle = 100, // 0x00000064
  InOut = 101, // 0x00000065
  InLoopOut = 102, // 0x00000066
  LeftRightSingle = 103, // 0x00000067
}
