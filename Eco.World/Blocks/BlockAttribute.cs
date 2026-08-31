// Decompiled with JetBrains decompiler
// Type: Eco.World.Blocks.BlockAttribute
// Assembly: Eco.World, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B2A8792E-938E-4BB5-B27F-EF3390C48946
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.xml

using System;

#nullable disable
namespace Eco.World.Blocks;

[AttributeUsage(AttributeTargets.Class, Inherited = true)]
public abstract class BlockAttribute : Attribute
{
  /// <summary>
  /// Set this flag to true to prevent the attribute from being applied to the block.
  /// Ex: See TilledDirtBlock.
  /// </summary>
  public bool Unset { get; set; }
}
