// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.AsphaltConcreteItem
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
[LocDisplayName("Asphalt Concrete")]
[LocDescription("A paved surface constructed with asphalt and concrete. It's durable and extremely efficient for any wheeled vehicle.")]
[Eco.Gameplay.Items.MaxStackSize(10)]
[Eco.Gameplay.Items.Weight(10000)]
[Eco.Gameplay.Items.MakesRoads]
[Ecopedia("Blocks", "Roads", true, true, null)]
[SalvageCost(new object[] {typeof (StoneRubble), 0.25f})]
[Tag("Road")]
[Tag("Constructable")]
[Tag("RoadType")]
[Road(1.2f, null)]
[ConstructWithoutTool(false)]
public class AsphaltConcreteItem : RoadItem<AsphaltConcreteBlock>
{
  public override LocString DisplayNamePlural { get; }
}
