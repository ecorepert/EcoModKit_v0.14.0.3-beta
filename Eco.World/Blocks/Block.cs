// Decompiled with JetBrains decompiler
// Type: Eco.World.Blocks.Block
// Assembly: Eco.World, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B2A8792E-938E-4BB5-B27F-EF3390C48946
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.xml

using Eco.Core.Items;
using Eco.Shared.Serialization;
using Eco.World.Serializers;
using System;
using System.Collections.Generic;

#nullable enable
namespace Eco.World.Blocks;

/// <summary> Base type for all block world blocks. </summary>
[Serialized]
[Tag("NonPlant")]
[SerializedWith(typeof (BlockSerializer<>), typeof (BlockMigrationSerializer<>))]
public abstract class Block
{
  /// <summary>A constant empty block that represents air.</summary>
  public static Block Empty { get; }

  public static IEnumerable<Type> BlockTypesWithAttribute(Type block);

  public static void Initialize();

  /// <summary>Checks if <see cref="T:Eco.World.Blocks.Block" /> is either <typeparamref name="T1" /> or <typeparamref name="T2" />. More efficient than <c>block.Is&lt;T1&gt;() || block.Is&lt;T2&gt;()</c>.</summary>
  public bool IsAny<T1, T2>();

  public bool Is<T>() where T : BlockAttribute;

  public static bool Is<T>(Type blockType) where T : BlockAttribute;

  public T? Get<T>() where T : BlockAttribute;

  public bool TryGet<T>(out T? blockAttribute) where T : BlockAttribute;

  public static T? Get<T>(Type blockType) where T : BlockAttribute;

  public bool IsWater();
}
