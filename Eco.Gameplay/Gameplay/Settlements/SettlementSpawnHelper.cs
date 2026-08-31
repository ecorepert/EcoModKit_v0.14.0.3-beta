// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Settlements.SettlementSpawnHelper
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Shared.Math;

#nullable disable
namespace Eco.Gameplay.Settlements;

/// <summary> Helper class that precalculates and contains spawn data when spawning settlements. </summary>
/// <remarks> It exists to reduce math calculations and hold all size logic, so spawning code can stay clean and on-point. </remarks>
internal class SettlementSpawnHelper
{
  public Vector2i GovSize { get; }

  public bool SpawnGovernment { get; }

  public SettlementSpawnHelper(SettlementSpawnConfig spawnConfig);

  /// <summary>Quick access to child count, child size, and the amount of columns for children. </summary>
  public (int ChildCount, Vector2i ChildSize, int Columns) GetSettingsForChildSettlement(
    int settlementType);

  public int GetChildCount(int settlementType);

  public Vector2i GetSize(int settlementType);

  public string GetMarkerTypeName(int settlementType);

  public int GetWallHeight(int settlementType);

  public int GetSignHeight(int settlementType);

  public (string GroundMat, string WallMat) GetMaterials(int settlementType);
}
