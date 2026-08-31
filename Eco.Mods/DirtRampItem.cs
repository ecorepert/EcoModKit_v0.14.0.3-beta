// Decompiled with JetBrains decompiler
// Type: DirtRampItem
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Items;
using Eco.Gameplay.Items;
using Eco.Shared.Localization;
using Eco.Shared.Math;
using Eco.Shared.Serialization;
using System;
using System.Collections.Generic;

#nullable disable
[Serialized]
[LocDisplayName("Dirt Ramp")]
[LocDescription("4 x 1 Dirt Ramp.")]
[ItemGroup("Road Items")]
[Tag("Road")]
[Ecopedia("Blocks", "Roads", true, true, null)]
[Eco.Gameplay.Items.Weight(60000)]
public class DirtRampItem : RampItem<DirtRampObject>
{
  public override Dictionary<Vector3i, Type[]> BlockTypes { get; }
}
