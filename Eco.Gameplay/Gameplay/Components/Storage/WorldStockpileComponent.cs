// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Components.Storage.WorldStockpileComponent
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Core.Utils;
using Eco.Gameplay.Objects;
using Eco.Shared.Math;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Gameplay.Components.Storage;

/// <summary> This stockpile has all its contents represented in the world as blocks (e.g. DirtBlock for dirt. Non-block items are represented as StockpileCrateBlocks). </summary>
/// <remarks> Changes are synced in the world real time when the content of the stockpile's inventory changes. </remarks>
[Serialized]
[Priority(-100)]
[RequireComponent(typeof (StockpileComponent), null)]
[NoIcon]
public class WorldStockpileComponent : WorldObjectComponent
{
  public Vector3i StockpilePosition { get; }

  public Vector3i BlockContainerPosition { get; }

  public override void Initialize();

  public override void OnBeforeObjectMoved();

  public override void OnAfterObjectMoved();

  public override void Destroy();
}
