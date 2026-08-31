// Decompiled with JetBrains decompiler
// Type: Eco.World.BlockChange
// Assembly: Eco.World, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B2A8792E-938E-4BB5-B27F-EF3390C48946
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.xml

using Eco.Shared.Math;
using System;

#nullable disable
namespace Eco.World;

public struct BlockChange
{
  public Vector3i Position;
  public Type BlockType;
  public object[] ParamArray;

  public BlockChange(Type blockType, Vector3i position);

  public BlockChange(Type blockType, Vector3i position, params object[] additionalData);
}
