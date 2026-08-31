// Decompiled with JetBrains decompiler
// Type: Eco.World.Blocks.RiverSandBlock
// Assembly: Eco.World, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: B2A8792E-938E-4BB5-B27F-EF3390C48946
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.World.xml

using Eco.Core.Items;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.World.Blocks;

[Serialized]
[MoveEfficiency(0.9f)]
[LookAtTooltip("River Sand")]
[Tillable(Unset = true)]
[Tag("CanBeRoad", Unset = true)]
[Tag("Tillable", Unset = true)]
public class RiverSandBlock : DirtBlock
{
}
