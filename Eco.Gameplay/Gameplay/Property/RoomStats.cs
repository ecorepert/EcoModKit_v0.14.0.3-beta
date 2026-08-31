// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Property.RoomStats
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Controller;
using Eco.Gameplay.Housing.PropertyValues;
using Eco.Gameplay.Objects;
using Eco.Gameplay.Players;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Voxel;
using System;
using System.Collections.Generic;
using System.ComponentModel;

#nullable enable
namespace Eco.Gameplay.Property;

public class RoomStats : INotifyPropertyChanged
{
  public WorldRange Range;
  public WorldRange ChunkRange;
  public LocString FailReason;
  public 
  #nullable disable
  RoomCategory LockToCategory;

  public Func<User, bool> IsResident { get; set; }

  public int WallCount { get; set; }

  public double LastCheckTime { get; set; }

  public float AverageTier { get; set; }

  public bool Contained { get; set; }

  public bool Flooded { get; set; }

  public bool IsClaimed { get; set; }

  public bool IsOutdoor { get; }

  public Vector3i? AverageEmptyPos { get; set; }

  public int LowestEmptyY { get; set; }

  public HashSet<Vector3i> EmptySpace { get; set; }

  public HashSet<Vector3i> Windows { get; set; }

  public HashSet<Vector3i> Doorways { get; set; }

  public HashSet<PlotPos> PlotPositions { get; set; }

  public HashSet<Vector3i> Walls { get; set; }

  public Dictionary<WrappedWorldPosition3i, Axis> WindowAxis { get; set; }

  public Dictionary<RoomStats.WallComposition, int> WallCompositions { get; set; }

  public Dictionary<float, int> WallTierComposition { get; set; }

  public HashSet<WorldObject> WorldObjectWalls { get; set; }

  public int PaintedBlockCount { get; set; }

  public int PaintableBlockCount { get; set; }

  public float PaintedBlockPercentage { get; }

  public int Volume { get; }

  public IEnumerable<WorldObject> ContainedWorldObjects { get; }

  public IEnumerable<WorldObject> ContainedAndTouchingWorldObjects { get; }

  public IEnumerable<WorldObject> ContainedWorldObjectsNull { get; }

  [Notify]
  public LocString DescriptionText { get; set; }

  public event PropertyChangedEventHandler PropertyChanged;

  public bool ShouldCheck { get; }

  public IEnumerable<T> ContainedComponents<T>();

  public void AddContainedWorldObject(WorldObject obj, bool wallObjs);

  public void RemoveContainedWorldObject(IEnumerable<WorldObject> objs, bool wallObjs);

  public void SetContainedWorldObjects(IEnumerable<WorldObject> walls, bool wallObjs);

  public LocString Description();

  public LocString ShortDescription();

  public void Dispose();

  public LocString GetResidencyInfo(User user, float housingXP);

  public struct WallComposition : IEquatable<RoomStats.WallComposition>
  {
    public Type BlockItemType;
    public string PrependText;
    public float Tier;

    public bool Equals(RoomStats.WallComposition other);

    public override int GetHashCode();

    public override bool Equals(object obj);

    public static bool operator ==(RoomStats.WallComposition left, RoomStats.WallComposition right);

    public static bool operator !=(RoomStats.WallComposition left, RoomStats.WallComposition right);
  }
}
