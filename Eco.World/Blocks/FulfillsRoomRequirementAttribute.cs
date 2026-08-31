// Decompiled with JetBrains decompiler
// Type: Eco.World.Blocks.FulfillsRoomRequirementAttribute
// Assembly: Eco.World, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B2A8792E-938E-4BB5-B27F-EF3390C48946
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.xml

using System;

#nullable enable
namespace Eco.World.Blocks;

public sealed class FulfillsRoomRequirementAttribute : BlockAttribute
{
  public Type FulfillsItemType { get; set; }

  public FulfillsRoomRequirementAttribute(Type itemType);
}
