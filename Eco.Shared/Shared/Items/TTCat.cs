// Decompiled with JetBrains decompiler
// Type: Eco.Shared.Items.TTCat
// Assembly: Eco.Shared, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: FB5147AF-01F0-45E9-875E-9AD7242B7D47
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Shared.xml

using System;

#nullable disable
namespace Eco.Shared.Items;

/// <summary>Categories of tooltips.</summary>
[Flags]
public enum TTCat
{
  None = 0,
  Controls = 1,
  Crafting = 2,
  Trade = 4,
  LinkControls = 8,
  Details = 16, // 0x00000010
  Title = 32, // 0x00000020
  SpecialPart1 = 64, // 0x00000040
  SpecialPart2 = 128, // 0x00000080
  SpecialPart3 = 256, // 0x00000100
  Default = 512, // 0x00000200
  Image = 1024, // 0x00000400
}
