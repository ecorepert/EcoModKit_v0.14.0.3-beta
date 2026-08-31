// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Utils.Array2D`1
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using Eco.Shared.Math;
using Eco.Shared.Serialization;
using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;

#nullable enable
namespace Eco.Shared.Utils;

[Serialized]
public class Array2D<T> : IEnumerable<
#nullable disable
T>, IEnumerable, ICloneable
{
  [Serialized]
  public T[] Array { get; set; }

  [Serialized]
  public Vector2i Size { get; set; }

  public int Length { get; }

  public int CalcSize { get; }

  public Array2D();

  public Array2D(Vector2i size);

  public Array2D(Array2D<T> other);

  public object Clone();

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public int Index(Vector2i v);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public int Index(int x, int y);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public static int Index(int x, int y, int size);

  [MethodImpl(MethodImplOptions.AggressiveInlining)]
  public Vector2i IndexToPos(int index);

  public T Val(Vector2i v);

  public T Val(int index);

  public T this[int index] { get; set; }

  public T this[Vector2i v] { get; set; }

  public T this[int x, int y] { get; set; }

  public T this[WorldPosition3i v] { get; set; }

  public void ForEach(Action<Vector2i, T> func);

  /// <summary>Transforms the map using the given transformation function.</summary>
  public IEnumerable<TOut> Select<TOut>(Func<Vector2i, T, TOut> func);

  /// <summary>Runs a function on each entry, but accepts the value by ref so it can change the array</summary>
  public void ForEachRef(ActionRef<T, Vector2i> func);

  public void Fill(T value);

  public void Clear();

  /// <summary>Creates <see cref="T:Eco.Shared.Utils.Array2D`1" /> from <paramref name="stream" />.</summary>
  public static Array2D<T> ReadFromStream(MemoryStream stream);

  public IEnumerator<T> GetEnumerator();

  IEnumerator IEnumerable.GetEnumerator();

  public ref T GetRef(Vector2i pos);
}
