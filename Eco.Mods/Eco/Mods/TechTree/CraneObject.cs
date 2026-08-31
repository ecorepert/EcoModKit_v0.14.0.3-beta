// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.CraneObject
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Items;
using Eco.Gameplay.Components;
using Eco.Gameplay.Components.Auth;
using Eco.Gameplay.Components.Storage;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Occupancy;
using Eco.Gameplay.Skills;
using Eco.Shared.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using System;

#nullable disable
namespace Eco.Mods.TechTree;

[Serialized]
[RequireComponent(typeof (StandaloneAuthComponent), null)]
[RequireComponent(typeof (FuelSupplyComponent), null)]
[RequireComponent(typeof (FuelConsumptionComponent), null)]
[RequireComponent(typeof (AirPollutionComponent), null)]
[RequireComponent(typeof (VehicleComponent), null)]
[RequireComponent(typeof (MinimapComponent), null)]
[RequireComponent(typeof (OccupancyRequirementComponent), null)]
[RequireComponent(typeof (MovableLinkComponent), null)]
[RequireComponent(typeof (CraneToolComponent), null)]
[RequireComponent(typeof (PhysicsValueSyncComponent), null)]
[RequireComponent(typeof (PartsComponent), null)]
[RepairRequiresSkill(typeof (MechanicsSkill), 5)]
[Ecopedia("Crafted Objects", "Vehicles", false, true, "Crane Item")]
[ObjectCanMakeBlockForm(new Type[] {typeof (AqueductFormType), typeof (CubeFormType), typeof (DocksBarrelPlatformFormType), typeof (DocksPlatformFormType), typeof (DocksPlatformFillFormType), typeof (FlatRoofFormType), typeof (FloorFormType), typeof (FullWallFormType), typeof (SimpleFloorFormType), typeof (TwoWhiteEdgeRotateFormType), typeof (WhiteCubeFormType), typeof (WhiteDashLineFormType), typeof (WhiteEdgeFormType), typeof (WhiteEdgeRotateFormType), typeof (WhiteLineFormType), typeof (FloatStairsFormType), typeof (FloatStairsCornerFormType), typeof (FloatStairsTurnFormType), typeof (LadderFormType), typeof (StairsFormType), typeof (StairsCornerFormType), typeof (StairsTurnFormType), typeof (UnderStairsFormType), typeof (DocksRampAFormType), typeof (DocksRampBFormType), typeof (DocksRampCFormType), typeof (DocksRampDFormType), typeof (DocksRampsFormType), typeof (DocksRampsCornerFormType), typeof (DocksRampsCornerInvertedFormType), typeof (RampAFormType), typeof (RampBFormType), typeof (RampCFormType), typeof (RampDFormType), typeof (WhiteRampDashLineAFormType), typeof (WhiteRampDashLineBFormType), typeof (WhiteRampDashLineCFormType), typeof (WhiteRampDashLineDFormType), typeof (WhiteRampEdgeAFormType), typeof (WhiteRampEdgeBFormType), typeof (WhiteRampEdgeCFormType), typeof (WhiteRampEdgeDFormType), typeof (WhiteRampLineAFormType), typeof (WhiteRampLineBFormType), typeof (WhiteRampLineCFormType), typeof (WhiteRampLineDFormType), typeof (RoofFormType), typeof (RoofCornerFormType), typeof (RoofCubeFormType), typeof (RoofPeakFormType), typeof (RoofPeakSetFormType), typeof (RoofSideFormType), typeof (RoofTurnFormType), typeof (BasicSlopeCornerFormType), typeof (BasicSlopePointFormType), typeof (BasicSlopeSideFormType), typeof (BasicSlopeTurnFormType), typeof (HalfSlopeAFormType), typeof (HalfSlopeBFormType), typeof (PeakSetFormType), typeof (SlopeCornerFormType), typeof (SlopeFlatFormType), typeof (SlopePointFormType), typeof (SlopeSideFormType), typeof (SlopeTurnFormType), typeof (UnderInnerPeakFormType), typeof (UnderPeakSetFormType), typeof (UnderSlopeCornerFormType), typeof (UnderSlopePeakFormType), typeof (UnderSlopeSideFormType), typeof (UnderSlopeTurnFormType), typeof (BraceFormType), typeof (BraceCornerFormType), typeof (BraceTurnFormType), typeof (ChimneyFormType), typeof (ColumnFormType), typeof (DocksColumnFormType), typeof (DocksPillarFormType), typeof (DocksPillarBeamFormType), typeof (DocksPillarBeamCornerFormType), typeof (DocksPillarBeamEndFormType), typeof (DocksPillarBeamEndAltFormType), typeof (DocksPillarBeamJunctionFormType), typeof (DocksPillarBeamTFormType), typeof (DocksPillarBeamXFormType), typeof (SideBraceFormType), typeof (SmallCornerBraceFormType), typeof (ThinColumnFormType), typeof (UnderBraceFormType), typeof (UnderBraceCornerFormType), typeof (UnderBraceTurnFormType), typeof (CanopyWindowFormType), typeof (CladWallFormType), typeof (DocksFenceCornerFormType), typeof (DocksFenceEndCapFormType), typeof (DocksFenceEndCapDoubleFormType), typeof (DocksFenceXFormType), typeof (DocksFenceMidFormType), typeof (DocksFenceSoloFormType), typeof (DocksFenceTFormType), typeof (DoubleWindowFormType), typeof (EdgeWallFormType), typeof (EdgeWallTurnFormType), typeof (FenceFormType), typeof (RoadBarrierFormType), typeof (SideFenceFormType), typeof (ThinFloorBottomFormType), typeof (ThinFloorTopFormType), typeof (ThinWallCornerFormType), typeof (ThinWallEdgeFormType), typeof (ThinWallStraightFormType), typeof (WallFormType), typeof (WallTrimFormType), typeof (WindowFormType), typeof (WindowCornersFormType), typeof (WindowEdgeFormType), typeof (WindowGrillesFormType), typeof (WindowGrillesEdgeFormType), typeof (WindowT2FormType), typeof (WindowWallFormType), typeof (FenceSoloFormType), typeof (FenceMidFormType), typeof (FenceEndFormType), typeof (FenceCornerFormType), typeof (FenceXFormType), typeof (FenceTFormType)})]
public class CraneObject : PhysicsWorldObject, IRepresentsItem
{
  public override TableTextureMode TableTexture { get; }

  public override LocString DisplayName { get; }

  public Type RepresentedItemType { get; }

  protected override void Initialize();

  protected override void CreateEntity();
}
