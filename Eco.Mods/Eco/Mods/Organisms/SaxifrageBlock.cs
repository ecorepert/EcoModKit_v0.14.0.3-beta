// Decompiled with JetBrains decompiler
// Type: Eco.Mods.Organisms.SaxifrageBlock
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Items;
using Eco.Gameplay.Blocks;
using Eco.Gameplay.Plants;
using Eco.Shared.Serialization;
using Eco.World.Blocks;

#nullable disable
namespace Eco.Mods.Organisms;

[Serialized]
[Tag("Reapable")]
[Reapable]
[Clearable]
[Tag("Clearable")]
[MoveEfficiency(0.8f)]
public class SaxifrageBlock : PlantBlock
{
}
