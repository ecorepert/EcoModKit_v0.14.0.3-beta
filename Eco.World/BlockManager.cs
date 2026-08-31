// Decompiled with JetBrains decompiler
// Type: Eco.World.BlockManager
// Assembly: Eco.World, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B2A8792E-938E-4BB5-B27F-EF3390C48946
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.xml

using Eco.Shared.Serialization;
using Eco.World.Blocks;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

#nullable enable
namespace Eco.World;

public static class BlockManager
{
  public static Func<string>? GetCurrentEvent;

  public static int NumBlocks { get; }

  public static IEnumerable<Type> BlockTypes { get; }

  public static ushort GetBlockID(Type type);

  public static Type? FromTypeName(string s);

  /// <summary>
  /// Slower than FromTypeName, should be used for cases like commands, etc.
  /// Uses lower case comparison on both sides and applies input validation (trims all whitespaces, adds "block", etc)
  /// </summary>
  public static Type? FromTypeNameNoCase(string s);

  public static Type FromId(ushort blockId);

  public static bool IsShared(Type type);

  public static Func<Type, bool> TrySetBlock { get; }

  public static Action<Type> DestroyBlock { get; }

  public static void SetBlockTestFuncs(Func<Type, bool> func, Action<Type> destroyBlock);

  public static bool TryConvert(Block block, [NotNullWhen(true)] out Block? convert);

  public static Block Create<T>(params object[] args) where T : Block;

  public static Block Create(Type blockType, params object[] args);

  public static BSONObject ToBson();
}
