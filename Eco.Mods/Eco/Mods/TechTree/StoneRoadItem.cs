// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.StoneRoadItem
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Items;
using Eco.Gameplay.GameActions;
using Eco.Gameplay.Items;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;
using Eco.World.Blocks;

#nullable disable
namespace Eco.Mods.TechTree;

[Serialized]
[LocDisplayName("Stone Road")]
[LocDescription("A rocky surface formed from smoothed rubble. It's fairly durable and efficient for any wheeled vehicle.")]
[Eco.Gameplay.Items.MaxStackSize(10)]
[Eco.Gameplay.Items.Weight(10000)]
[Eco.Gameplay.Items.MakesRoads]
[Ecopedia("Blocks", "Roads", true, true, null)]
[SalvageCost(new object[] {typeof (StoneRubble), 1f, typeof (Trash), 0.5f})]
[Tag("Road")]
[Tag("Constructable")]
[Tag("RoadType")]
[Road(1.1f, null)]
[ConstructWithoutTool(false)]
public class StoneRoadItem : RoadItem<StoneRoadBlock>
{
}
