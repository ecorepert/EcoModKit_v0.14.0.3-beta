// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Items.PossibleInteractions
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;

#nullable disable
namespace Eco.Shared.Items;

[Flags]
public enum PossibleInteractions
{
  None = 0,
  Placeable = 1,
  BlockItem = 2,
  CarriesItems = 4,
  ToolItem = 8,
  Liquid = 16, // 0x00000010
  Carried = 32, // 0x00000020
  BecomesRubble = 64, // 0x00000040
  WaterPlaceable = 128, // 0x00000080
}
