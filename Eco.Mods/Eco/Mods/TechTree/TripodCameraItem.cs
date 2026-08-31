// Decompiled with JetBrains decompiler
// Type: Eco.Mods.TechTree.TripodCameraItem
// Assembly: Eco.Mods, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 8756697B-2B6C-4F56-B8E4-FD8F5F5392E7
// Assembly location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.dll
// XML documentation location: C:\Users\orfla\OneDrive\Documents\ecoserveur\EcoModKit_v0.14.0.3-beta\ReferenceAssemblies\Eco.Mods.xml

using Eco.Core.Controller;
using Eco.Core.Items;
using Eco.Gameplay.Items;
using Eco.Gameplay.Occupancy;
using Eco.Shared.Localization;
using Eco.Shared.Serialization;

#nullable disable
namespace Eco.Mods.TechTree;

[Serialized]
[LocDisplayName("Tripod Camera")]
[LocDescription("When you want to save the world but in a frame.")]
[Ecopedia("Crafted Objects", "Specialty", true, true, null)]
[RelatedFeature("CameraModeEnabled", true)]
[Eco.Gameplay.Items.Weight(2000)]
[SalvageCost(new object[] {typeof (BioResidue), 0.8f, typeof (CopperScrap), 2.1f, typeof (GlassScrap), 5f, typeof (IronScrap), 0.8f})]
public class TripodCameraItem : WorldObjectItem<TripodCameraObject>
{
  protected override OccupancyContext GetOccupancyContext { get; }
}
