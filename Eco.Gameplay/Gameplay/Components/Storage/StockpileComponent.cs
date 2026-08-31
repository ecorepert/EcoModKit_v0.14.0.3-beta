// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.Storage.StockpileComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Core.Utils;
using Eco.Gameplay.Items;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Shared.Math;
using Eco.Shared.Serialization;
using System;
using System.Collections.Generic;

#nullable disable
namespace Eco.Gameplay.Components.Storage;

[Serialized]
[NoIcon]
[RequireComponent(typeof (PublicStorageComponent), null)]
[Tag("Storage Container")]
[MustBeGridAligned]
public class StockpileComponent : WorldObjectComponent, ITickOnDemand
{
  public static readonly Vector3i DefaultDimensions;
  public ThreadSafeAction<HashSet<Vector3i>> OnBlocksChanged;

  public Vector3i Dimensions { get; }

  public int YOffset { get; }

  public Type[] BlockTypes { get; }

  public double NextTickTime { get; }

  public void Initialize(Vector3i dimensions, int yOffset = 0);

  public override void Initialize();

  public bool TickOnDemand();

  public static void ClearPlacementArea(
    User actor,
    Vector3i pos,
    Vector3i dim,
    Quaternion rotation,
    int outline = 0);

  public override void Destroy();

  /// <summary> Updates contents of <see cref="P:Eco.Gameplay.Components.Storage.StockpileComponent.BlockTypes" /> to match contents of <see cref="F:Eco.Gameplay.Components.Storage.StockpileComponent.storage" /> </summary>
  public void UpdateStockpileFromInventory();

  private class StockInfo
  {
    public Item Item;
    public int Remaining;
    public float Allotment;
  }
}
