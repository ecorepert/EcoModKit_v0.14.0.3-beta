// Decompiled with JetBrains decompiler
// Type: Eco.Gameplay.Items.InventoryMoveResult
// Assembly: Eco.Gameplay, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: E91D36E0-DE51-4020-BCDC-BDFD4EB61D56
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Gameplay.xml

using Eco.Core.Utils;
using System;
using System.Runtime.CompilerServices;

#nullable disable
namespace Eco.Gameplay.Items;

/// <summary>Result from inventory change set moved items</summary>
/// <param name="Result"> Normal result from item inventory move changes </param>
/// <param name="PartialMove"> whether or not move managed to take all items or only a portion</param>
public struct InventoryMoveResult : IEquatable<InventoryMoveResult>
{
  /// <summary>Result from inventory change set moved items</summary>
  /// <param name="Result"> Normal result from item inventory move changes </param>
  /// <param name="PartialMove"> whether or not move managed to take all items or only a portion</param>
  public InventoryMoveResult(Result Result, bool PartialMove, int NumMoved);

  /// <summary> Normal result from item inventory move changes </summary>
  public Result Result { get; set; }

  /// <summary> whether or not move managed to take all items or only a portion</summary>
  public bool PartialMove { get; set; }

  public int NumMoved { get; set; }

  public static implicit operator InventoryMoveResult(
    (Result Result, bool PartialMove, int NumMoved) value);

  public static implicit operator InventoryMoveResult(Result value);

  public static implicit operator InventoryMoveResult(
    (InventoryMoveResult Result, bool PartialMove, int Nummoved) value);

  [CompilerGenerated]
  public override readonly string ToString();

  [CompilerGenerated]
  public static bool operator !=(InventoryMoveResult left, InventoryMoveResult right);

  [CompilerGenerated]
  public static bool operator ==(InventoryMoveResult left, InventoryMoveResult right);

  [CompilerGenerated]
  public override readonly int GetHashCode();

  [CompilerGenerated]
  public override readonly bool Equals(object obj);

  [CompilerGenerated]
  public readonly bool Equals(InventoryMoveResult other);

  [CompilerGenerated]
  public readonly void Deconstruct(out Result Result, out bool PartialMove, out int NumMoved);
}
