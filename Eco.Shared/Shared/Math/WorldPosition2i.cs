// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Math.WorldPosition2i
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

#nullable enable
namespace Eco.Shared.Math;

[TypeConverter(typeof (ValueTypeTypeConverter))]
public struct WorldPosition2i : IComparable, IComparable<int>, IEquatable<WorldPosition2i>
{
  private int packedZX;
  private static int xsize;
  private static int zsize;
  private static int max;
  private static int onez;
  private static int halfxsize;
  private static int halfzsize;
  public static readonly WorldPosition2i Invalid;

  public int x { get; set; }

  public int z { get; set; }

  public bool IsValid { get; }

  public static void Initialize(Vector3i worldSize);

  public WorldPosition2i(int x, int y, int z);

  public WorldPosition2i(int x, int z);

  public WorldPosition2i(Vector3i vec);

  public static explicit operator int(WorldPosition2i vec);

  public static explicit operator WorldPosition2i(int i);

  public static implicit operator WorldPosition2i(Vector3i vec);

  public static implicit operator WorldPosition2i(Vector2i vec);

  public static explicit operator Vector2i(WorldPosition2i w);

  public static explicit operator Vector2(WorldPosition2i w);

  public Vector2i XZ { get; }

  public int A2DIndex { get; }

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static WorldPosition2i FromWrapped(Vector2i vec);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static WorldPosition2i FromWrapped(int x, int z);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static int WrapX(int x);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static int WrapZ(int z);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public WorldPosition2i North();

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public WorldPosition2i South();

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public WorldPosition2i East();

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public WorldPosition2i West();

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public WorldPosition2i AddX(int val);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public WorldPosition2i AddZ(int val);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public void Add(Direction val, int count);

  public static float Distance(WorldPosition2i a, WorldPosition2i b);

  public static int DistanceSq(WorldPosition2i a, WorldPosition2i b);

  public 
  #nullable disable
  WorldPosition2i[] XZNeighbors();

  public static IEnumerable<WorldPosition2i> WorldXZIter();

  public IEnumerable<WorldPosition2i> SpiralOutXZIter(int size);

  public IEnumerable<WorldPosition2i> StepToInc(WorldPosition2i other, Direction dir);

  public override int GetHashCode();

  public override string ToString();

  public static bool operator ==(WorldPosition2i a, WorldPosition2i b);

  public static bool operator !=(WorldPosition2i a, WorldPosition2i b);

  public static WorldPosition2i operator +(WorldPosition2i a, Vector2i b);

  public static Vector2i operator -(WorldPosition2i a, WorldPosition2i b);

  public static WorldPosition2i operator -(WorldPosition2i a, Vector2i b);

  public int CompareTo(object value);

  public int CompareTo(int value);

  public override bool Equals(object other);

  public bool Equals(WorldPosition2i other);
}
