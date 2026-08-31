// Decompiled with JetBrains decompiler
// Type: Eco.Simulation.WorldLayers.Layers.WorldLayer
// Assembly: Eco.Simulation, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 59355B22-2585-4630-8786-F53E2E16876F
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Simulation.xml

using Eco.Core.Controller;
using Eco.Core.Serialization;
using Eco.Core.Systems;
using Eco.Core.Utils;
using Eco.Core.Utils.Threading;
using Eco.Shared.Gameplay;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Serialization;
using Eco.Shared.UI;
using Eco.Shared.Utils;
using Eco.Shared.View;
using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;

#nullable enable
namespace Eco.Simulation.WorldLayers.Layers;

[Serialized]
public class WorldLayer : 
  IStorage,
  ISerializable,
  IController,
  IViewController,
  IHasUniversalID,
  IWorldLayerView,
  IWorldLayerLastTickView,
  IHeatMapOverlay,
  IOverlayWithDescribableUnits,
  IMinimapOption,
  IMinimapCategorizedOption
{
  public const float Epsilon = 0.0001f;
  public int RoundedTotal;
  public float ActualTotal;
  public 
  #nullable disable
  ThreadSafeAction<WorldLayer> ChangedEvent;
  public Array2D<float> PrevEntries;
  public double TimeSpentTicking;
  public int Width;
  public int Height;
  public float NumCells;
  public static readonly ThreadPriorityTaskScheduler LayerScheduler;
  public static readonly TaskFactory LayerTaskFactory;
  public static readonly ParallelOptions LowPriorityParallelOptions;

  public int RoundedResolutionAdjustedTotal { get; }

  public float ActualResolutionAdjustedTotal { get; }

  [SyncToView(SyncFlags.MustRequest)]
  [Serialized]
  public Array2D<float> Map { get; protected set; }

  [SyncToView(null, true)]
  [Serialized]
  public string Name { get; set; }

  [SyncToView(null, true)]
  public LocString MarkedUpName { get; }

  [SyncToView(null, true)]
  public string FolderStructure { get; }

  [SyncToView(null, true)]
  public float Priority { get; }

  [SyncToView(null, true)]
  public bool IsOnByDefault { get; }

  public bool IsVisible { get; }

  [SyncToView(null, true)]
  [DependsOnController("DisplayName", true)]
  public string OverlayName { get; }

  public string DisplayName { get; }

  [SyncToView(null, true)]
  public LocString UnitDescription { get; set; }

  [SyncToView(null, true)]
  public WorldLayerSettings Settings { get; set; }

  public double LastModifiedTime { get; }

  public bool DirtyRawData { get; }

  public IPersistent StorageHandle { get; set; }

  public bool PushPullActive { get; set; }

  public virtual bool PostTick { get; }

  public virtual Type SettingsType { get; }

  public int CellArea { get; }

  [SyncToView(null, true)]
  public Vector2i Size { get; }

  public override string ToString();

  public virtual string ToString(Vector2i layerPos);

  public int CalcSize { get; }

  public void Modify();

  public void Init();

  protected virtual void InitSelf();

  protected void Init(Func<Vector2i, float> func);

  public void NoiseInit(
    float frequency = 2f,
    float scale = 0.5f,
    float bias = 0.5f,
    Func<Vector2i, float, float> multiplier = null);

  public void Tick();

  protected virtual void TickSelf();

  /// <summary>Called after all layer ticks are complete and totals have been reset</summary>
  public virtual void TickFinished();

  public float RawEntry(Vector2i pos);

  public float EntryWorldPos(int x, int y);

  public float EntryWorldPos(Vector2i pos);

  public float SetAtWorldPos(Vector2i pos, float val);

  public float SafeEntry(int x, int y);

  public float SafeEntry(Vector2i pos);

  public Vector2i WrapPos(Vector2i pos);

  public Vector2 PercentToRawPos(Vector2 pos);

  public Vector2 PercentToWorldPos(Vector2 pos);

  public Vector2i WorldPosToLayerPos(Vector2i pos);

  public Vector2i LayerPosToWorldPos(Vector2 pos);

  public WorldArea LayerPosToWorldArea(Vector2i pos);

  public float UpdateAtWorldPos(Vector2i pos, Func<Vector2i, float, float> func);

  /// <summary> Transforms value for each cell in the <paramref name="worldArea" /> using <paramref name="transform" /> function. </summary>
  public void TransformInArea(WorldArea worldArea, Func<float, float> transform);

  public float TranslateEntry(WorldLayer other, Vector2i layerPos);

  /// <summary> Gets the layer at <paramref name="layerPos" />. If granularity different then will translate the value. </summary>
  public float GetValue(LayerPosition layerPos);

  /// <summary>
  /// Query <paramref name="other" /> layer amount at <paramref name="layerPos" />, translating when the other layer resolution is different. Result depends on other layer's <see cref="P:Eco.Simulation.WorldLayers.Layers.WorldLayerSettings.ValueType" />.
  /// For <see cref="F:Eco.Simulation.WorldLayers.Layers.WorldLayerValueType.Amount" /> and <see cref="F:Eco.Simulation.WorldLayers.Layers.WorldLayerValueType.Percent" /> it will return unmodified value, but for <see cref="F:Eco.Simulation.WorldLayers.Layers.WorldLayerValueType.FillRate" /> it will return value multiplied by <see cref="P:Eco.Simulation.WorldLayers.Layers.WorldLayer.CellArea" />.
  /// </summary>
  public float TranslateEntryToAmount(WorldLayer other, Vector2i layerPos);

  public void DoTick();

  public virtual bool MigrateVersion();

  public float this[int x, int y] { get; set; }

  public float this[Vector2i pos] { get; set; }

  public void ForRadius(Vector2i pos, float radius, Func<Vector2i, float, float> func);

  public void ApplyRadius(Vector2i pos, float radius, Func<Vector2i, float, float> func);

  public WorldArea Patch(Vector2i pos);

  public void FillLayerWithSummedPatchValues(Array2D<float> vals);

  public void SetMax(Array2D<float> worldVals);

  public void SetMax(Array2D<bool> worldVals);

  public void ForEach(Action<Vector2i, float> func);

  public IEnumerable<float> Values { get; }

  public void Transform(Func<float, float> func);

  public Color OutputColor { get; set; }

  public ref int ControllerID { get; }

  [SyncToView(null, true)]
  public Eco.Shared.Math.Range Range { get; }

  public void Clear();

  public void PostLoad();

  public void RecordPrevious();

  protected virtual void PostLoadSelf();

  public virtual void BackwardsCompatibilityCheck();

  public void MarkDirty();

  /// <summary> Pulls startup value for layer using <paramref name="puller" />. </summary>
  public void PullStartupLayer(IStartupWorldLayerPuller puller);

  public void PullLayer(IWorldLayerPuller worldLayerPuller);

  public void PullLayerNonExclusive(IWorldLayerPuller worldLayerPuller);

  /// <summary> Invokes <paramref name="action" /> for every cell with <paramref name="voxelsPerEntry" /> granularity with normalized values from <paramref name="dependencies" />. </summary>
  public static void ForEachCell(
    int voxelsPerEntry,
    WorldLayer[] dependencies,
    Action<Vector2i, WorldArea, float[], WorldLayerNeighborInfo[], int> action);

  /// <summary> Push layers with <paramref name="pusher" />. </summary>
  public static void PushLayers(IWorldLayerPusher pusher);

  public void ApplyInteraction(
    IWorldLayerInteraction interaction,
    IWorldLayerLastTickView[] dependencies);

  public float AverageOverBoundaryAlignedWorldPos(Vector2i pos);

  public float AverageOverBoundaryAlignedWorldArea(WorldArea area = default (WorldArea));

  public float AverageOverBoundaryAlignedWorldAreaLastTick(WorldArea area = default (WorldArea));

  public void SumAndCountOverBoundaryAlignedWorldArea(
    WorldArea area,
    bool previousValues,
    out float totalAmount,
    out int numCells);

  /// <summary> Converts <paramref name="layerPos" /> to <see cref="T:Eco.Shared.Math.WorldArea" /> with <paramref name="voxelsPerEntry" /> granularity. </summary>
  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static WorldArea LayerPosToWorldArea(Vector2i layerPos, int voxelsPerEntry);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static void ForEachCell(int voxelsPerEntry, Action<Vector2i, WorldArea> action);

  public void InitInteraction(IWorldLayerInteraction interaction, WorldLayer[] initDependencies);

  public virtual void UpdateLayerTotals();

  /// <summary> Returns a string in HTML format for the <paramref name="val" /> using <see name="Settings" />. Set <paramref name="relative" /> if you wanna to format value difference. </summary>
  public string ValStringHtml(float val, bool relative = false);

  /// <summary> Returns a tooltip string for the <paramref name="val" /> using <see name="Settings" />. Set <paramref name="relative" /> if you wanna to format value difference. </summary>
  public string ValStringTooltip(float val, bool relative = false);
}
